﻿namespace Software_Libreria
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
            label1 = new Label();
            label2 = new Label();
            txtdni = new TextBox();
            dataGridListClientes = new DataGridView();
            label3 = new Label();
            prueba = new Button();
            Dni = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridListClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(206, 18);
            label1.Name = "label1";
            label1.Size = new Size(357, 32);
            label1.TabIndex = 0;
            label1.Text = "Búsqueda de Clientes por DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 101);
            label2.Name = "label2";
            label2.Size = new Size(135, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingrese el Dni del cliente";
            // 
            // txtdni
            // 
            txtdni.Location = new Point(79, 119);
            txtdni.Name = "txtdni";
            txtdni.Size = new Size(135, 23);
            txtdni.TabIndex = 2;
            txtdni.TextChanged += txtdni_TextChanged;
            // 
            // dataGridListClientes
            // 
            dataGridListClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridListClientes.Columns.AddRange(new DataGridViewColumn[] { Dni, Nombre, Telefono });
            dataGridListClientes.Location = new Point(168, 198);
            dataGridListClientes.Name = "dataGridListClientes";
            dataGridListClientes.RowTemplate.Height = 25;
            dataGridListClientes.Size = new Size(337, 82);
            dataGridListClientes.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(282, 127);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // prueba
            // 
            prueba.Location = new Point(359, 123);
            prueba.Name = "prueba";
            prueba.Size = new Size(75, 23);
            prueba.TabIndex = 5;
            prueba.Text = "prueba";
            prueba.UseVisualStyleBackColor = true;
            prueba.Click += prueba_Click;
            // 
            // Dni
            // 
            Dni.HeaderText = "Dni";
            Dni.Name = "Dni";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            // 
            // ListaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(prueba);
            Controls.Add(label3);
            Controls.Add(dataGridListClientes);
            Controls.Add(txtdni);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label3;
        private Button prueba;
        private DataGridViewTextBoxColumn Dni;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Telefono;
    }
}