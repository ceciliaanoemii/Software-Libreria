namespace Software_Libreria
{
    partial class RegistroDeVenta
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
            lblFecha = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnCancelar = new Button();
            btnRegistrar = new Button();
            btnSalir = new Button();
            lblPrecio = new Label();
            groupBox1 = new GroupBox();
            btnSelecCliente = new Button();
            txtCantidad = new TextBox();
            button1 = new Button();
            lblNombreCliente = new Label();
            labelTitulo = new Label();
            txtDniCliente = new TextBox();
            textIdLibro = new TextBox();
            dataGridLibro = new DataGridView();
            Cantidad = new DataGridViewTextBoxColumn();
            Titulo = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Importe = new DataGridViewTextBoxColumn();
            label3 = new Label();
            lblTotal = new Label();
            lblDescuento = new Label();
            label10 = new Label();
            btnExportarPDF = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridLibro).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(282, 9);
            label1.Name = "label1";
            label1.Size = new Size(225, 32);
            label1.TabIndex = 0;
            label1.Text = "Registro de ventas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(553, 38);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "Fecha actual :";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(638, 38);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(51, 15);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "lblFecha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 16);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 3;
            label4.Text = "Seleccione libro:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(223, 17);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 5;
            label6.Text = "Cantidad:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(617, 19);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 6;
            label7.Text = "Precio de libro:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(309, 194);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(404, 194);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(679, 415);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecio.Location = new Point(610, 38);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(104, 30);
            lblPrecio.TabIndex = 10;
            lblPrecio.Text = "LblPrecio";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSelecCliente);
            groupBox1.Controls.Add(txtCantidad);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(lblNombreCliente);
            groupBox1.Controls.Add(labelTitulo);
            groupBox1.Controls.Add(txtDniCliente);
            groupBox1.Controls.Add(textIdLibro);
            groupBox1.Controls.Add(lblPrecio);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(21, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(767, 122);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Control de ventas";
            // 
            // btnSelecCliente
            // 
            btnSelecCliente.Location = new Point(128, 88);
            btnSelecCliente.Name = "btnSelecCliente";
            btnSelecCliente.Size = new Size(75, 23);
            btnSelecCliente.TabIndex = 19;
            btnSelecCliente.Text = "Buscar";
            btnSelecCliente.UseVisualStyleBackColor = true;
            btnSelecCliente.Click += btnSelecCliente_Click_1;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(223, 35);
            txtCantidad.Margin = new Padding(2);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(62, 23);
            txtCantidad.TabIndex = 18;
            // 
            // button1
            // 
            button1.Location = new Point(106, 35);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(78, 20);
            button1.TabIndex = 17;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.BackColor = SystemColors.ActiveBorder;
            lblNombreCliente.Location = new Point(223, 93);
            lblNombreCliente.Margin = new Padding(2, 0, 2, 0);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(12, 15);
            lblNombreCliente.TabIndex = 13;
            lblNombreCliente.Text = "-";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = SystemColors.ActiveBorder;
            labelTitulo.Location = new Point(13, 58);
            labelTitulo.Margin = new Padding(2, 0, 2, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(12, 15);
            labelTitulo.TabIndex = 13;
            labelTitulo.Text = "-";
            // 
            // txtDniCliente
            // 
            txtDniCliente.Location = new Point(10, 89);
            txtDniCliente.Margin = new Padding(2);
            txtDniCliente.Name = "txtDniCliente";
            txtDniCliente.PlaceholderText = "Ingrese DNI cliente";
            txtDniCliente.Size = new Size(113, 23);
            txtDniCliente.TabIndex = 16;
            // 
            // textIdLibro
            // 
            textIdLibro.Location = new Point(10, 35);
            textIdLibro.Margin = new Padding(2);
            textIdLibro.Name = "textIdLibro";
            textIdLibro.PlaceholderText = "Ingrese ID Libro";
            textIdLibro.Size = new Size(91, 23);
            textIdLibro.TabIndex = 16;
            // 
            // dataGridLibro
            // 
            dataGridLibro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridLibro.Columns.AddRange(new DataGridViewColumn[] { Cantidad, Titulo, dataGridViewTextBoxColumn1, Importe });
            dataGridLibro.Location = new Point(71, 222);
            dataGridLibro.Margin = new Padding(2);
            dataGridLibro.Name = "dataGridLibro";
            dataGridLibro.RowHeadersWidth = 62;
            dataGridLibro.RowTemplate.Height = 33;
            dataGridLibro.Size = new Size(664, 135);
            dataGridLibro.TabIndex = 12;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 8;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 150;
            // 
            // Titulo
            // 
            Titulo.HeaderText = "Título";
            Titulo.MinimumWidth = 8;
            Titulo.Name = "Titulo";
            Titulo.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Precio Unitario";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // Importe
            // 
            Importe.HeaderText = "Importe";
            Importe.MinimumWidth = 8;
            Importe.Name = "Importe";
            Importe.Width = 150;
            // 
            // label3
            // 
            label3.AccessibleRole = AccessibleRole.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(476, 395);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 21);
            label3.TabIndex = 14;
            label3.Text = "Total";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(555, 398);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(32, 15);
            lblTotal.TabIndex = 15;
            lblTotal.Text = "Total";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(555, 365);
            lblDescuento.Margin = new Padding(2, 0, 2, 0);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(32, 15);
            lblDescuento.TabIndex = 15;
            lblDescuento.Text = "Total";
            // 
            // label10
            // 
            label10.AccessibleRole = AccessibleRole.None;
            label10.AutoSize = true;
            label10.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(475, 368);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(60, 17);
            label10.TabIndex = 14;
            label10.Text = "Descuento";
            // 
            // btnExportarPDF
            // 
            btnExportarPDF.Location = new Point(557, 415);
            btnExportarPDF.Name = "btnExportarPDF";
            btnExportarPDF.Size = new Size(103, 23);
            btnExportarPDF.TabIndex = 16;
            btnExportarPDF.Text = "Imprimir Factura";
            btnExportarPDF.UseVisualStyleBackColor = true;
            btnExportarPDF.Click += btnExportarPDF_Click_1;
            // 
            // RegistroDeVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 449);
            Controls.Add(btnExportarPDF);
            Controls.Add(lblDescuento);
            Controls.Add(lblTotal);
            Controls.Add(label10);
            Controls.Add(label3);
            Controls.Add(dataGridLibro);
            Controls.Add(groupBox1);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrar);
            Controls.Add(btnCancelar);
            Controls.Add(lblFecha);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistroDeVenta";
            Text = "Registro de venta";
            Load += RegistroDeVenta_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridLibro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblFecha;
        private Label label4;
        private Label label6;
        private Label label7;
        private Button btnCancelar;
        private Button btnRegistrar;
        private Button btnSalir;
        private Label lblPrecio;
        private GroupBox groupBox1;
        private Label labelTitulo;
        private TextBox textIdLibro;
        private Button button1;
        private DataGridView dataGridLibro;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Importe;
        private TextBox txtCantidad;
        private Label label3;
        private Label lblTotal;
        private Label lblDescuento;
        private Label label10;
        private Button btnExportarPDF;
        private Label lblNombreCliente;
        private TextBox txtDniCliente;
        private Button btnSelecCliente;
    }
}