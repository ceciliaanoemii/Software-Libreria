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
            comboListaClientes = new ComboBox();
            label1 = new Label();
            txtNombreCliente = new TextBox();
            btnAgregarCliente = new Button();
            SuspendLayout();
            // 
            // comboListaClientes
            // 
            comboListaClientes.BackColor = SystemColors.Info;
            comboListaClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboListaClientes.FormattingEnabled = true;
            comboListaClientes.Items.AddRange(new object[] { "Cecilia", "Andres" });
            comboListaClientes.Location = new Point(61, 79);
            comboListaClientes.Name = "comboListaClientes";
            comboListaClientes.Size = new Size(273, 23);
            comboListaClientes.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(428, 87);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(549, 88);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(100, 23);
            txtNombreCliente.TabIndex = 2;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(543, 211);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(75, 23);
            btnAgregarCliente.TabIndex = 3;
            btnAgregarCliente.Text = "Agregar";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            // 
            // VentanaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 612);
            Controls.Add(btnAgregarCliente);
            Controls.Add(txtNombreCliente);
            Controls.Add(label1);
            Controls.Add(comboListaClientes);
            Name = "VentanaCliente";
            Text = "Cliente";
            Load += VentanaCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboListaClientes;
        private Label label1;
        private TextBox txtNombreCliente;
        private Button btnAgregarCliente;
    }
}