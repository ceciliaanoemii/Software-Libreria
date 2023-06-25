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
            dataGridLibro.BackgroundColor = Color.DarkGoldenrod;
            dataGridLibro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridLibro.Columns.AddRange(new DataGridViewColumn[] { Id, Titulo, Autor, Editorial, Precio, Portada });
            dataGridLibro.Location = new Point(103, 257);
            dataGridLibro.Margin = new Padding(4, 5, 4, 5);
            dataGridLibro.MinimumSize = new Size(0, 100);
            dataGridLibro.Name = "dataGridLibro";
            dataGridLibro.RowHeadersWidth = 62;
            dataGridLibro.RowTemplate.Height = 25;
            dataGridLibro.Size = new Size(920, 100);
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
            txtBusqueda.Location = new Point(103, 193);
            txtBusqueda.Margin = new Padding(4, 5, 4, 5);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(185, 31);
            txtBusqueda.TabIndex = 1;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // btnRegresar
            // 
            btnRegresar.Font = new Font("Bauhaus 93", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegresar.Location = new Point(752, 409);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(129, 81);
            btnRegresar.TabIndex = 2;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(254, 193);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(103, 163);
            label1.Name = "label1";
            label1.Size = new Size(187, 20);
            label1.TabIndex = 4;
            label1.Text = "Ingrese el Id del libro:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(103, 57);
            label2.Name = "label2";
            label2.Size = new Size(596, 54);
            label2.TabIndex = 5;
            label2.Text = "Búsqueda de libros por ID";
            // 
            // btnEliminar_Click
            // 
            btnEliminar_Click.Font = new Font("Bauhaus 93", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar_Click.Location = new Point(580, 409);
            btnEliminar_Click.Margin = new Padding(4, 5, 4, 5);
            btnEliminar_Click.Name = "btnEliminar_Click";
            btnEliminar_Click.Size = new Size(133, 81);
            btnEliminar_Click.TabIndex = 6;
            btnEliminar_Click.Text = "Eliminar libro";
            btnEliminar_Click.UseVisualStyleBackColor = true;
            btnEliminar_Click.Click += btnEliminar_Click_Click;
            // 
            // LibrosDisponibles
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1143, 748);
            Controls.Add(btnEliminar_Click);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnRegresar);
            Controls.Add(txtBusqueda);
            Controls.Add(dataGridLibro);
            Margin = new Padding(4, 5, 4, 5);
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