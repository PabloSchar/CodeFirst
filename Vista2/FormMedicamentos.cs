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
    public partial class FormMedicamentos : Form
    {
        private ControladoraMedicamentos controladoraMedicamentos;
        public FormMedicamentos()
        {
            InitializeComponent();
            controladoraMedicamentos = new ControladoraMedicamentos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form formAgregar = new FormMedicamento();
            formAgregar.ShowDialog();
            ActualizarVista();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvMedicamentos.Rows.Count > 0)
            {
                var medicamento = (Medicamento)dgvMedicamentos.CurrentRow.DataBoundItem;
                Form formModificar = new FormMedicamento(medicamento);
                formModificar.ShowDialog();
                ActualizarVista();
            }
            else
            {
                MessageBox.Show("No hay ningun medicamento para modificar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMedicamentos.Rows.Count > 0)
            {
                var medicamento = (Medicamento)dgvMedicamentos.CurrentRow.DataBoundItem;
                var eliminado = controladoraMedicamentos.EliminarMedicamento(medicamento);
                if (eliminado)
                {
                    MessageBox.Show("Medicamento eliminado correctamente");
                }
                else
                {
                    MessageBox.Show("Error: no se pudo eliminar el medicamento");
                }
                ActualizarVista();
            }
            else
            {
                MessageBox.Show("No hay ningun medicamento para eliminar");
            }
        }

        private void ActualizarVista()
        {
            dgvMedicamentos.DataSource = null;
            dgvMedicamentos.DataSource = controladoraMedicamentos.RecuperarMedicamentos();
        }

        private void FormMedicamentos_Load(object sender, EventArgs e)
        {
            ActualizarVista();
        }
    }
}
