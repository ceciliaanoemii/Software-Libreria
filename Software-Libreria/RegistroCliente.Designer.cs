namespace Software_Libreria
{
    partial class RegistroCliente
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtdni = new TextBox();
            txtcelular = new TextBox();
            txtnombre = new TextBox();
            dgvClientes = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            button2 = new Button();
            label4 = new Label();
            errorProvider1 = new ErrorProvider(components);
            btnAddClient = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(293, 85);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Dni Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(293, 149);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 1;
            label2.Text = "Número de Teléfono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(293, 115);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre y Apellido";
            // 
            // txtdni
            // 
            txtdni.Location = new Point(424, 82);
            txtdni.Name = "txtdni";
            txtdni.Size = new Size(138, 23);
            txtdni.TabIndex = 3;
            txtdni.TextChanged += txtdni_TextChanged;
            // 
            // txtcelular
            // 
            txtcelular.Location = new Point(424, 141);
            txtcelular.Name = "txtcelular";
            txtcelular.Size = new Size(138, 23);
            txtcelular.TabIndex = 4;
            txtcelular.TextChanged += txtcelular_TextChanged;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(424, 112);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(138, 23);
            txtnombre.TabIndex = 5;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvClientes.Location = new Point(260, 197);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowTemplate.Height = 25;
            dgvClientes.Size = new Size(342, 84);
            dgvClientes.TabIndex = 7;
            // 
            // Column1
            // 
            Column1.HeaderText = "Dni";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre y Apellido";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Teléfono";
            Column3.Name = "Column3";
            // 
            // button2
            // 
            button2.Location = new Point(278, 315);
            button2.Name = "button2";
            button2.Size = new Size(140, 29);
            button2.TabIndex = 8;
            button2.Text = "Regresar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(278, 9);
            label4.Name = "label4";
            label4.Size = new Size(305, 32);
            label4.TabIndex = 9;
            label4.Text = "Registro de nuevo cliente";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnAddClient
            // 
            btnAddClient.Location = new Point(478, 315);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(124, 29);
            btnAddClient.TabIndex = 11;
            btnAddClient.Text = "Registrar";
            btnAddClient.UseVisualStyleBackColor = true;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // RegistroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddClient);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(dgvClientes);
            Controls.Add(txtnombre);
            Controls.Add(txtcelular);
            Controls.Add(txtdni);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistroCliente";
            Text = "RegistroCliente";
            Load += RegistroCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtdni;
        private TextBox txtcelular;
        private TextBox txtnombre;
        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button button2;
        private Label label4;
        private ErrorProvider errorProvider1;
        private Button button1;
        private Button btnAddClient;
    }
}