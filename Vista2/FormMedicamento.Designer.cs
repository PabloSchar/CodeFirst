namespace Vista2
{
    partial class FormMedicamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            checkBoxVentaLibre = new CheckBox();
            cBoxMonodroga = new ComboBox();
            groupBox1 = new GroupBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            btnEliminarDrogueria = new Button();
            dgvDroguerias = new DataGridView();
            btnAgregarDrogueria = new Button();
            cBoxDroguerias = new ComboBox();
            txtStockMinimo = new TextBox();
            txtStock = new TextBox();
            txtPrecioVenta = new TextBox();
            txtNombreComercial = new TextBox();
            label7 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDroguerias).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 31);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre Comercial:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 64);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 1;
            label2.Text = "Precio De Venta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 95);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Stock:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 127);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 3;
            label4.Text = "Stock Minimo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 157);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 4;
            label5.Text = "Venta Libre:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 198);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 5;
            label6.Text = "Monodroga:";
            // 
            // checkBoxVentaLibre
            // 
            checkBoxVentaLibre.AutoSize = true;
            checkBoxVentaLibre.Location = new Point(146, 158);
            checkBoxVentaLibre.Name = "checkBoxVentaLibre";
            checkBoxVentaLibre.Size = new Size(15, 14);
            checkBoxVentaLibre.TabIndex = 6;
            checkBoxVentaLibre.UseVisualStyleBackColor = true;
            // 
            // cBoxMonodroga
            // 
            cBoxMonodroga.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxMonodroga.FormattingEnabled = true;
            cBoxMonodroga.Location = new Point(146, 195);
            cBoxMonodroga.Name = "cBoxMonodroga";
            cBoxMonodroga.Size = new Size(121, 23);
            cBoxMonodroga.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnAceptar);
            groupBox1.Controls.Add(btnEliminarDrogueria);
            groupBox1.Controls.Add(dgvDroguerias);
            groupBox1.Controls.Add(btnAgregarDrogueria);
            groupBox1.Controls.Add(cBoxDroguerias);
            groupBox1.Controls.Add(txtStockMinimo);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(txtPrecioVenta);
            groupBox1.Controls.Add(txtNombreComercial);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cBoxMonodroga);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(checkBoxVentaLibre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 392);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Medicamento";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(253, 260);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(15, 260);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 17;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnEliminarDrogueria
            // 
            btnEliminarDrogueria.Location = new Point(494, 334);
            btnEliminarDrogueria.Name = "btnEliminarDrogueria";
            btnEliminarDrogueria.Size = new Size(132, 23);
            btnEliminarDrogueria.TabIndex = 16;
            btnEliminarDrogueria.Text = "Eliminar Drogueria";
            btnEliminarDrogueria.UseVisualStyleBackColor = true;
            btnEliminarDrogueria.Click += btnEliminarDrogueria_Click;
            // 
            // dgvDroguerias
            // 
            dgvDroguerias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDroguerias.Location = new Point(357, 95);
            dgvDroguerias.Name = "dgvDroguerias";
            dgvDroguerias.RowTemplate.Height = 25;
            dgvDroguerias.Size = new Size(397, 233);
            dgvDroguerias.TabIndex = 15;
            // 
            // btnAgregarDrogueria
            // 
            btnAgregarDrogueria.Location = new Point(483, 56);
            btnAgregarDrogueria.Name = "btnAgregarDrogueria";
            btnAgregarDrogueria.Size = new Size(143, 23);
            btnAgregarDrogueria.TabIndex = 14;
            btnAgregarDrogueria.Text = "Agregar Drogueria";
            btnAgregarDrogueria.UseVisualStyleBackColor = true;
            btnAgregarDrogueria.Click += btnAgregarDrogueria_Click;
            // 
            // cBoxDroguerias
            // 
            cBoxDroguerias.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxDroguerias.FormattingEnabled = true;
            cBoxDroguerias.Location = new Point(457, 28);
            cBoxDroguerias.Name = "cBoxDroguerias";
            cBoxDroguerias.Size = new Size(196, 23);
            cBoxDroguerias.TabIndex = 13;
            // 
            // txtStockMinimo
            // 
            txtStockMinimo.Location = new Point(146, 124);
            txtStockMinimo.Name = "txtStockMinimo";
            txtStockMinimo.Size = new Size(121, 23);
            txtStockMinimo.TabIndex = 12;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(146, 92);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(121, 23);
            txtStock.TabIndex = 11;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(146, 61);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(121, 23);
            txtPrecioVenta.TabIndex = 10;
            // 
            // txtNombreComercial
            // 
            txtNombreComercial.Location = new Point(146, 28);
            txtNombreComercial.Name = "txtNombreComercial";
            txtNombreComercial.Size = new Size(182, 23);
            txtNombreComercial.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(384, 31);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 8;
            label7.Text = "Droguerias:";
            // 
            // FormMedicamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 415);
            ControlBox = false;
            Controls.Add(groupBox1);
            Name = "FormMedicamento";
            ShowIcon = false;
            Load += FormMedicamento_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDroguerias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckBox checkBoxVentaLibre;
        private ComboBox cBoxMonodroga;
        private GroupBox groupBox1;
        private Label label7;
        private Button btnCancelar;
        private Button btnAceptar;
        private Button btnEliminarDrogueria;
        private DataGridView dgvDroguerias;
        private Button btnAgregarDrogueria;
        private ComboBox cBoxDroguerias;
        private TextBox txtStockMinimo;
        private TextBox txtStock;
        private TextBox txtPrecioVenta;
        private TextBox txtNombreComercial;
    }
}