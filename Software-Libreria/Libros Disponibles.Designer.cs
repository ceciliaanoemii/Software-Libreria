namespace Software_Libreria
{
    partial class LibrosDisponibles
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
            dataGridLibro = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Titulo = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            Editorial = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Portada = new DataGridViewImageColumn();
            txtBusqueda = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridLibro).BeginInit();
            SuspendLayout();
            // 
            // dataGridLibro
            // 
            dataGridLibro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridLibro.Columns.AddRange(new DataGridViewColumn[] { Id, Titulo, Autor, Editorial, Precio, Portada });
            dataGridLibro.Location = new Point(51, 157);
            dataGridLibro.MinimumSize = new Size(0, 60);
            dataGridLibro.Name = "dataGridLibro";
            dataGridLibro.RowTemplate.Height = 25;
            dataGridLibro.Size = new Size(644, 150);
            dataGridLibro.TabIndex = 0;
            dataGridLibro.CellContentClick += dataGridLibro_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Resizable = DataGridViewTriState.True;
            // 
            // Titulo
            // 
            Titulo.HeaderText = "Titulo";
            Titulo.Name = "Titulo";
            // 
            // Autor
            // 
            Autor.HeaderText = "Autor";
            Autor.Name = "Autor";
            // 
            // Editorial
            // 
            Editorial.HeaderText = "Editorial";
            Editorial.Name = "Editorial";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // Portada
            // 
            Portada.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Portada.HeaderText = "Portada";
            Portada.Name = "Portada";
            Portada.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(72, 116);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(100, 23);
            txtBusqueda.TabIndex = 1;
        //    txtBusqueda.TextChanged += textBox1_TextChanged;
            // 
            // LibrosDisponibles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBusqueda);
            Controls.Add(dataGridLibro);
            Name = "LibrosDisponibles";
            Text = "Libros Disponibles";
            Load += LibrosDisponibles_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridLibro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridLibro;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn Editorial;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewImageColumn Portada;
        private TextBox txtBusqueda;
    }
}