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
            txtCantidad = new TextBox();
            button1 = new Button();
            labelTitulo = new Label();
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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridLibro).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(403, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(331, 48);
            label1.TabIndex = 0;
            label1.Text = "Registro de ventas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(790, 63);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 1;
            label2.Text = "Fecha actual :";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(911, 63);
            lblFecha.Margin = new Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(76, 25);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "lblFecha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 27);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(139, 25);
            label4.TabIndex = 3;
            label4.Text = "Seleccione libro:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 120);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(207, 25);
            label5.TabIndex = 4;
            label5.Text = "Seleccione tipo de pago:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(318, 29);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 5;
            label6.Text = "Cantidad:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(881, 32);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(130, 25);
            label7.TabIndex = 6;
            label7.Text = "Precio de libro:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(442, 323);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(107, 38);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(577, 323);
            btnRegistrar.Margin = new Padding(4, 5, 4, 5);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(107, 38);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(970, 692);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(107, 38);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecio.Location = new Point(871, 63);
            lblPrecio.Margin = new Padding(4, 0, 4, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(159, 45);
            lblPrecio.TabIndex = 10;
            lblPrecio.Text = "LblPrecio";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboSeleccionTipoPago);
            groupBox1.Controls.Add(txtCantidad);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(labelTitulo);
            groupBox1.Controls.Add(textIdLibro);
            groupBox1.Controls.Add(lblPrecio);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(30, 110);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1096, 203);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Control de ventas";
            // 
            // comboSeleccionTipoPago
            // 
            comboSeleccionTipoPago.FormattingEnabled = true;
            comboSeleccionTipoPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta", "MercadoPago" });
            comboSeleccionTipoPago.Location = new Point(18, 153);
            comboSeleccionTipoPago.Name = "comboSeleccionTipoPago";
            comboSeleccionTipoPago.Size = new Size(182, 33);
            comboSeleccionTipoPago.TabIndex = 19;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(318, 59);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(87, 31);
            txtCantidad.TabIndex = 18;
            // 
            // button1
            // 
            button1.Location = new Point(119, 56);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 17;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = SystemColors.ActiveBorder;
            labelTitulo.Location = new Point(18, 96);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(19, 25);
            labelTitulo.TabIndex = 13;
            labelTitulo.Text = "-";
            // 
            // textIdLibro
            // 
            textIdLibro.Location = new Point(15, 58);
            textIdLibro.Name = "textIdLibro";
            textIdLibro.Size = new Size(86, 31);
            textIdLibro.TabIndex = 16;
            // 
            // dataGridLibro
            // 
            dataGridLibro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridLibro.Columns.AddRange(new DataGridViewColumn[] { Cantidad, Titulo, dataGridViewTextBoxColumn1, Importe });
            dataGridLibro.Location = new Point(212, 374);
            dataGridLibro.Name = "dataGridLibro";
            dataGridLibro.RowHeadersWidth = 62;
            dataGridLibro.RowTemplate.Height = 33;
            dataGridLibro.Size = new Size(668, 225);
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
            label3.Location = new Point(680, 659);
            label3.Name = "label3";
            label3.Size = new Size(74, 32);
            label3.TabIndex = 14;
            label3.Text = "Total";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(793, 663);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(49, 25);
            lblTotal.TabIndex = 15;
            lblTotal.Text = "Total";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(793, 608);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(49, 25);
            lblDescuento.TabIndex = 15;
            lblDescuento.Text = "Total";
            // 
            // label10
            // 
            label10.AccessibleRole = AccessibleRole.None;
            label10.AutoSize = true;
            label10.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(679, 614);
            label10.Name = "label10";
            label10.Size = new Size(88, 24);
            label10.TabIndex = 14;
            label10.Text = "Descuento";
            // 
            // RegistroDeVenta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1320, 907);
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
            Margin = new Padding(4, 5, 4, 5);
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
        private Label label5;
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
        private ComboBox comboSeleccionTipoPago;
        private Label label3;
        private Label lblTotal;
        private Label lblDescuento;
        private Label label10;
    }
}