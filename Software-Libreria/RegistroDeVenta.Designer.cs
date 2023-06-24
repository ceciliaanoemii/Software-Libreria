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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnCancelar = new Button();
            btnRegistrar = new Button();
            btnSalir = new Button();
            lblPrecio = new Label();
            groupBox1 = new GroupBox();
            comboSeleccionTipoPago = new ComboBox();
            comboSeleccionLibro = new ComboBox();
            txtCantidad = new TextBox();
            listVenta = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            btnGenFac = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(322, 12);
            label1.Name = "label1";
            label1.Size = new Size(278, 41);
            label1.TabIndex = 0;
            label1.Text = "Registro de ventas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(632, 51);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 1;
            label2.Text = "Fecha actual :";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(729, 51);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(64, 20);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "lblFecha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 25);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 3;
            label4.Text = "Seleccione libro:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 96);
            label5.Name = "label5";
            label5.Size = new Size(174, 20);
            label5.TabIndex = 4;
            label5.Text = "Seleccione tipo de pago:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(266, 25);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 5;
            label6.Text = "Cantidad:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(653, 25);
            label7.Name = "label7";
            label7.Size = new Size(109, 20);
            label7.TabIndex = 6;
            label7.Text = "Precio de libro:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(358, 319);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 31);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(450, 319);
            btnRegistrar.Margin = new Padding(3, 4, 3, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(86, 31);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(776, 553);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(86, 31);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecio.Location = new Point(645, 51);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(137, 37);
            lblPrecio.TabIndex = 10;
            lblPrecio.Text = "LblPrecio";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboSeleccionTipoPago);
            groupBox1.Controls.Add(comboSeleccionLibro);
            groupBox1.Controls.Add(lblPrecio);
            groupBox1.Controls.Add(txtCantidad);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(24, 88);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(877, 163);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Control de ventas";
            // 
            // comboSeleccionTipoPago
            // 
            comboSeleccionTipoPago.FormattingEnabled = true;
            comboSeleccionTipoPago.Items.AddRange(new object[] { "Efectivo", "Mercado Pago", "Tarjeta" });
            comboSeleccionTipoPago.Location = new Point(8, 124);
            comboSeleccionTipoPago.Margin = new Padding(3, 4, 3, 4);
            comboSeleccionTipoPago.Name = "comboSeleccionTipoPago";
            comboSeleccionTipoPago.Size = new Size(239, 28);
            comboSeleccionTipoPago.TabIndex = 15;
            // 
            // comboSeleccionLibro
            // 
            comboSeleccionLibro.FormattingEnabled = true;
            comboSeleccionLibro.Items.AddRange(new object[] { "Harry Potter - Las reliquias de la muerte", "El señor de los anillos - Las dos torres", "Agatha Christie - Asesinado en Mesopotamia" });
            comboSeleccionLibro.Location = new Point(7, 51);
            comboSeleccionLibro.Margin = new Padding(3, 4, 3, 4);
            comboSeleccionLibro.Name = "comboSeleccionLibro";
            comboSeleccionLibro.Size = new Size(241, 28);
            comboSeleccionLibro.TabIndex = 13;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(266, 51);
            txtCantidad.Margin = new Padding(3, 4, 3, 4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(114, 27);
            txtCantidad.TabIndex = 14;
            // 
            // listVenta
            // 
            listVenta.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listVenta.Location = new Point(24, 373);
            listVenta.Margin = new Padding(3, 4, 3, 4);
            listVenta.Name = "listVenta";
            listVenta.Size = new Size(876, 171);
            listVenta.TabIndex = 12;
            listVenta.UseCompatibleStateImageBehavior = false;
            listVenta.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Producto";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Cantidad";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Precio";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Tipo de Pago";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Descuento";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Recargo";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Precio Final";
            // 
            // btnGenFac
            // 
            btnGenFac.Location = new Point(617, 553);
            btnGenFac.Margin = new Padding(3, 4, 3, 4);
            btnGenFac.Name = "btnGenFac";
            btnGenFac.Size = new Size(152, 31);
            btnGenFac.TabIndex = 13;
            btnGenFac.Text = "Generar Factura";
            btnGenFac.UseVisualStyleBackColor = true;
            btnGenFac.Click += btnGenFac_Click;
            // 
            // RegistroDeVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnGenFac);
            Controls.Add(listVenta);
            Controls.Add(groupBox1);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrar);
            Controls.Add(btnCancelar);
            Controls.Add(lblFecha);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegistroDeVenta";
            Text = "Registro de venta";
            Load += RegistroDeVenta_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblFecha;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnCancelar;
        public Button btnRegistrar;
        private Button btnSalir;
        private Label lblPrecio;
        private GroupBox groupBox1;
        private TextBox txtCantidad;
        public ListView listVenta;
        private ComboBox comboSeleccionTipoPago;
        private ComboBox comboSeleccionLibro;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Button btnGenFac;
    }
}