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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibrosDisponibles));
            dataGridLibro = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Titulo = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            Editorial = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Portada = new DataGridViewImageColumn();
            txtBusqueda = new TextBox();
            btnRegresar = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            btnEliminar_Click = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridLibro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridLibro
            // 
            dataGridLibro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridLibro.Columns.AddRange(new DataGridViewColumn[] { Id, Titulo, Autor, Editorial, Precio, Portada });
            dataGridLibro.Location = new Point(72, 154);
            dataGridLibro.MinimumSize = new Size(0, 60);
            dataGridLibro.Name = "dataGridLibro";
            dataGridLibro.RowHeadersWidth = 62;
            dataGridLibro.RowTemplate.Height = 25;
            dataGridLibro.Size = new Size(644, 150);
            dataGridLibro.TabIndex = 0;
            dataGridLibro.CellContentClick += dataGridLibro_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.Resizable = DataGridViewTriState.True;
            Id.Width = 150;
            // 
            // Titulo
            // 
            Titulo.HeaderText = "Titulo";
            Titulo.MinimumWidth = 8;
            Titulo.Name = "Titulo";
            Titulo.Width = 150;
            // 
            // Autor
            // 
            Autor.HeaderText = "Autor";
            Autor.MinimumWidth = 8;
            Autor.Name = "Autor";
            Autor.Width = 150;
            // 
            // Editorial
            // 
            Editorial.HeaderText = "Editorial";
            Editorial.MinimumWidth = 8;
            Editorial.Name = "Editorial";
            Editorial.Width = 150;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 8;
            Precio.Name = "Precio";
            Precio.Width = 150;
            // 
            // Portada
            // 
            Portada.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Portada.HeaderText = "Portada";
            Portada.MinimumWidth = 8;
            Portada.Name = "Portada";
            Portada.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(72, 116);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(131, 23);
            txtBusqueda.TabIndex = 1;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(617, 342);
            btnRegresar.Margin = new Padding(2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(78, 40);
            btnRegresar.TabIndex = 2;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(178, 116);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 19);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 98);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 4;
            label1.Text = "Ingrese el Id del libro:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(72, 34);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(282, 30);
            label2.TabIndex = 5;
            label2.Text = "Búsqueda de libros por ID";
            // 
            // btnEliminar_Click
            // 
            btnEliminar_Click.Location = new Point(502, 342);
            btnEliminar_Click.Name = "btnEliminar_Click";
            btnEliminar_Click.Size = new Size(76, 40);
            btnEliminar_Click.TabIndex = 6;
            btnEliminar_Click.Text = "Eliminar libro";
            btnEliminar_Click.UseVisualStyleBackColor = true;
            btnEliminar_Click.Click += btnEliminar_Click_Click;
            // 
            // LibrosDisponibles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 449);
            Controls.Add(btnEliminar_Click);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnRegresar);
            Controls.Add(txtBusqueda);
            Controls.Add(dataGridLibro);
            Name = "LibrosDisponibles";
            Text = "Libros Disponibles";
            Load += LibrosDisponibles_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridLibro).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Button btnRegresar;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button btnEliminar_Click;
    }
}