namespace Software_Libreria
{
    partial class VentanaCliente
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
            btnRegresar = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegresar.Location = new Point(359, 238);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(96, 51);
            btnRegresar.TabIndex = 3;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(228, 84);
            button1.Name = "button1";
            button1.Size = new Size(161, 90);
            button1.TabIndex = 4;
            button1.Text = "Registrar Cliente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(441, 84);
            button2.Name = "button2";
            button2.Size = new Size(141, 90);
            button2.TabIndex = 5;
            button2.Text = "Lista de Clientes";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // VentanaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 612);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnRegresar);
            Name = "VentanaCliente";
            Text = "Cliente";
            Load += VentanaCliente_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboListaClientes;
        private Label label1;
        private TextBox txtNombreCliente;
        private Button btnRegresar;
        private Button button1;
        private Button button2;
    }
}