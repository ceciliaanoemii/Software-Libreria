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
            txtSeleccionTipoPago = new TextBox();
            txtSeleccionLibro = new TextBox();
            txtCantidad = new TextBox();
            listView1 = new ListView();
            groupBox1.SuspendLayout();
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
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 3;
            label4.Text = "Seleccione libro:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 72);
            label5.Name = "label5";
            label5.Size = new Size(136, 15);
            label5.TabIndex = 4;
            label5.Text = "Seleccione tipo de pago:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(170, 19);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 5;
            label6.Text = "Cantidad:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(571, 19);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 6;
            label7.Text = "Precio de libro:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(313, 239);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(394, 239);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(679, 415);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecio.Location = new Point(564, 38);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(104, 30);
            lblPrecio.TabIndex = 10;
            lblPrecio.Text = "LblPrecio";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSeleccionTipoPago);
            groupBox1.Controls.Add(txtSeleccionLibro);
            groupBox1.Controls.Add(lblPrecio);
            groupBox1.Controls.Add(txtCantidad);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(21, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(767, 122);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Control de ventas";
            // 
            // txtSeleccionTipoPago
            // 
            txtSeleccionTipoPago.Location = new Point(7, 90);
            txtSeleccionTipoPago.Name = "txtSeleccionTipoPago";
            txtSeleccionTipoPago.Size = new Size(141, 23);
            txtSeleccionTipoPago.TabIndex = 15;
            // 
            // txtSeleccionLibro
            // 
            txtSeleccionLibro.Location = new Point(6, 37);
            txtSeleccionLibro.Name = "txtSeleccionLibro";
            txtSeleccionLibro.Size = new Size(142, 23);
            txtSeleccionLibro.TabIndex = 13;
            txtSeleccionLibro.TextChanged += txtSeleccionLibro_TextChanged;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(170, 38);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 14;
            // 
            // listView1
            // 
            listView1.Location = new Point(21, 280);
            listView1.Name = "listView1";
            listView1.Size = new Size(767, 129);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // RegistroDeVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
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
        private TextBox txtSeleccionTipoPago;
        private TextBox txtSeleccionLibro;
        private TextBox txtCantidad;
        private ListView listView1;
    }
}