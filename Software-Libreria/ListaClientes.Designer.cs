namespace Software_Libreria
{
    partial class ListaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaClientes));
            label1 = new Label();
            label2 = new Label();
            txtdni = new TextBox();
            dataGridListClientes = new DataGridView();
            Dni = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            btnRegresar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridListClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(157, 21);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(689, 54);
            label1.TabIndex = 0;
            label1.Text = "Búsqueda de Clientes por DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bauhaus 93", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(301, 126);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(328, 32);
            label2.TabIndex = 1;
            label2.Text = "Ingrese el Dni del cliente";
            // 
            // txtdni
            // 
            txtdni.Location = new Point(363, 173);
            txtdni.Margin = new Padding(4, 5, 4, 5);
            txtdni.Name = "txtdni";
            txtdni.Size = new Size(191, 31);
            txtdni.TabIndex = 2;
            txtdni.TextChanged += txtdni_TextChanged;
            // 
            // dataGridListClientes
            // 
            dataGridListClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridListClientes.Columns.AddRange(new DataGridViewColumn[] { Dni, Nombre, Telefono });
            dataGridListClientes.Location = new Point(231, 234);
            dataGridListClientes.Margin = new Padding(4, 5, 4, 5);
            dataGridListClientes.Name = "dataGridListClientes";
            dataGridListClientes.RowHeadersWidth = 62;
            dataGridListClientes.RowTemplate.Height = 25;
            dataGridListClientes.Size = new Size(481, 88);
            dataGridListClientes.TabIndex = 3;
            // 
            // Dni
            // 
            Dni.HeaderText = "Dni";
            Dni.MinimumWidth = 8;
            Dni.Name = "Dni";
            Dni.Width = 150;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.Width = 150;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 8;
            Telefono.Name = "Telefono";
            Telefono.Width = 150;
            // 
            // btnRegresar
            // 
            btnRegresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnRegresar.Location = new Point(734, 356);
            btnRegresar.Margin = new Padding(4, 5, 4, 5);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(107, 38);
            btnRegresar.TabIndex = 6;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // ListaClientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(940, 482);
            Controls.Add(btnRegresar);
            Controls.Add(dataGridListClientes);
            Controls.Add(txtdni);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ListaClientes";
            Text = "ListaClientes";
            Load += ListaClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridListClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtdni;
        private DataGridView dataGridListClientes;
        private DataGridViewTextBoxColumn Dni;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Telefono;
        private Button btnRegresar;
    }
}