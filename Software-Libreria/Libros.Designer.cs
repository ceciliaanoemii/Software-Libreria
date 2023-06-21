namespace Software_Libreria
{
    partial class VentanaLibros
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
            btnRegistraLibro = new Button();
            btnLibrosDisponibles = new Button();
            btnEliminarLibro = new Button();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // btnRegistraLibro
            // 
            btnRegistraLibro.Location = new Point(169, 290);
            btnRegistraLibro.Margin = new Padding(4, 5, 4, 5);
            btnRegistraLibro.Name = "btnRegistraLibro";
            btnRegistraLibro.Size = new Size(134, 70);
            btnRegistraLibro.TabIndex = 0;
            btnRegistraLibro.Text = "Registra Libro";
            btnRegistraLibro.UseVisualStyleBackColor = true;
            btnRegistraLibro.Click += btnRegistraLibro_Click;
            // 
            // btnLibrosDisponibles
            // 
            btnLibrosDisponibles.Location = new Point(524, 290);
            btnLibrosDisponibles.Margin = new Padding(4, 5, 4, 5);
            btnLibrosDisponibles.Name = "btnLibrosDisponibles";
            btnLibrosDisponibles.Size = new Size(154, 70);
            btnLibrosDisponibles.TabIndex = 1;
            btnLibrosDisponibles.Text = "Libros Disponibles";
            btnLibrosDisponibles.UseVisualStyleBackColor = true;
            btnLibrosDisponibles.Click += btnLibrosDisponibles_Click;
            // 
            // btnEliminarLibro
            // 
            btnEliminarLibro.Location = new Point(861, 290);
            btnEliminarLibro.Margin = new Padding(4, 5, 4, 5);
            btnEliminarLibro.Name = "btnEliminarLibro";
            btnEliminarLibro.Size = new Size(134, 70);
            btnEliminarLibro.TabIndex = 2;
            btnEliminarLibro.Text = "Eliminar Libros";
            btnEliminarLibro.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(74, 651);
            btnRegistrar.Margin = new Padding(4, 5, 4, 5);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(134, 70);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Regresar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += button1_Click;
            // 
            // VentanaLibros
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(btnRegistrar);
            Controls.Add(btnEliminarLibro);
            Controls.Add(btnLibrosDisponibles);
            Controls.Add(btnRegistraLibro);
            Margin = new Padding(4, 5, 4, 5);
            Name = "VentanaLibros";
            Text = "Ventana Libros";
            Load += VentanaLibros_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegistraLibro;
        private Button btnLibrosDisponibles;
        private Button btnEliminarLibro;
        private Label prueba;
        private Button btnRegistrar;
    }
}