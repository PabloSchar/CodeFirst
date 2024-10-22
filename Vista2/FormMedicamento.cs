using Modelo2;
using Controladora2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista2
{
    public partial class FormMedicamento : Form
    {
        private ControladoraMedicamentos controladoraMedicamentos;
        private Medicamento medicamento;
        private bool modifica = false;

        public FormMedicamento()
        {
            InitializeComponent();
            medicamento = new Medicamento();
            controladoraMedicamentos = new ControladoraMedicamentos();
        }

        public FormMedicamento(Medicamento medicamento)
        {
            InitializeComponent();
            controladoraMedicamentos = new ControladoraMedicamentos();
            this.medicamento = medicamento;
            modifica = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                medicamento.EsVentaLibre = checkBoxVentaLibre.Checked;
                medicamento.Stock = Convert.ToInt32(txtStock.Text);
                medicamento.StockMinimo = Convert.ToInt32(txtStockMinimo.Text);
                medicamento.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
                var monodrogas = controladoraMedicamentos.RecuperarMonodrogas();
                medicamento.Monodroga = monodrogas.FirstOrDefault(c => c.Nombre == (cBoxMonodroga.SelectedItem).ToString());
                medicamento.NombreComercial = txtNombreComercial.Text;
                var droguerias = medicamento.Droguerias;
                if (droguerias.Count() > 0)
                {
                    if (modifica)
                    {
                        var modifica = controladoraMedicamentos.ModificarMedicamento(medicamento);
                        if (modifica)
                        {
                            MessageBox.Show("Medicamento modificado con exito");
                        }
                        else
                        {
                            MessageBox.Show("Error: no se pudo modificar el Medicamento");
                        }
                        Close();
                    }
                    else
                    {
                        var agregado = controladoraMedicamentos.AgregarMedicamento(medicamento);
                        if (agregado)
                        {
                            MessageBox.Show("Medicamento agregado con exito");
                        }
                        else
                        {
                            MessageBox.Show("Error: no se pudo agregar el Medicamento");
                        }
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Es obligatorio que el medicamento tenga una drogueria como minimo asignada");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarDrogueria_Click(object sender, EventArgs e)
        {
            if (cBoxDroguerias.Items.Count > 0) 
            {
                var droguerias = controladoraMedicamentos.RecuperarDroguerias(); 
                var drogueriaCuit = cBoxDroguerias.SelectedItem;
                var drogueria = droguerias.FirstOrDefault(d => d.Cuit == Convert.ToInt64(drogueriaCuit));
                var agregado = medicamento.AgregarDrogueria(drogueria);
                if (agregado)
                {
                    MessageBox.Show("Drogueria agregada correctamente al medicamento");
                }
                else
                {
                    MessageBox.Show("Error: No se pudo agregar la Drogueria al medicamento");
                }
                ActualizarCBoxDroguerias();
                ActualizarDgvDroguerias();
            }
            else
            {
                MessageBox.Show("Error: no hay droguerias para agregar en el medicamento");
            }
        }

        private void btnEliminarDrogueria_Click(object sender, EventArgs e)
        {
            if (dgvDroguerias.Rows.Count > 0) 
            {
                var drogueria = (Drogueria)dgvDroguerias.CurrentRow.DataBoundItem;
                var eliminado = medicamento.EliminarDrogueria(drogueria);
                if (eliminado)
                {
                    MessageBox.Show("Drogueria eliminada correctamente del medicamento");
                }
                else 
                {
                    MessageBox.Show("Error: No se pudo eliminar la Drogueria del medicamento");
                }
                ActualizarCBoxDroguerias();
                ActualizarDgvDroguerias();
            }
            else
            {
                MessageBox.Show("Error: no hay droguerias en el medicamento para eliminar");
            }
        }

        private void ActualizarCBoxDroguerias()
        {
            cBoxDroguerias.Items.Clear();
            var droguerias = controladoraMedicamentos.RecuperarDroguerias();
            foreach (var drogueria in droguerias)
            {
                var existeDrogueria = medicamento.Droguerias.FirstOrDefault(c => c.Cuit == drogueria.Cuit);
                if (existeDrogueria == null)
                {
                    cBoxDroguerias.Items.Add(drogueria.Cuit.ToString());
                }
            }
        }

        private void ActualizarDgvDroguerias()
        {
            dgvDroguerias.DataSource = null;
            dgvDroguerias.DataSource = medicamento.Droguerias;
        }

        private void FormMedicamento_Load(object sender, EventArgs e)
        {
            ActualizarCBoxDroguerias();
            ActualizarDgvDroguerias();
            var monodrogas = controladoraMedicamentos.RecuperarMonodrogas();
            foreach(var monodroga in monodrogas)
            {
                cBoxMonodroga.Items.Add(monodroga.Nombre.ToString());
            }
            if (modifica)
            {
                txtNombreComercial.Text = medicamento.NombreComercial.ToString();
                txtPrecioVenta.Text = medicamento.PrecioVenta.ToString();
                txtStock.Text = medicamento.Stock.ToString();
                txtStockMinimo.Text = medicamento.StockMinimo.ToString();
                checkBoxVentaLibre.Checked = medicamento.EsVentaLibre;
                cBoxMonodroga.SelectedItem = medicamento.Monodroga;
                cBoxMonodroga.DisplayMember = "Nombre";
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtNombreComercial.Text))
            {
                MessageBox.Show("El nombre comercial no puede ser nulo");
                return false;
            }
            if (string.IsNullOrEmpty(txtPrecioVenta.Text))
            {
                MessageBox.Show("El precio de venta no puede ser nulo");
                return false;
            }
            if (string.IsNullOrEmpty(txtStock.Text))
            {
                MessageBox.Show("El stock no puede ser nulo");
                return false;
            }
            if (string.IsNullOrEmpty(txtStockMinimo.Text))
            {
                MessageBox.Show("El stock minimo no puede ser nulo");
                return false;
            }

            if (!Decimal.TryParse(txtPrecioVenta.Text, out var val))
            {
                MessageBox.Show("El precio de venta debe ser un numero entero o decimal");
                return false;
            }
            if (!int.TryParse(txtStock.Text, out var val2))
            {
                MessageBox.Show("El stock debe ser un numero entero");
                return false;
            }
            if (!int.TryParse(txtStockMinimo.Text, out var val3))
            {
                MessageBox.Show("El stock minimo debe ser un numero entero");
                return false;
            }
            return true;
        }
    }
}
