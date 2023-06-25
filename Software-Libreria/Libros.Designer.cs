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
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // btnRegistraLibro
            // 
            btnRegistraLibro.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistraLibro.Location = new Point(181, 123);
            btnRegistraLibro.Name = "btnRegistraLibro";
            btnRegistraLibro.Size = new Size(116, 68);
            btnRegistraLibro.TabIndex = 0;
            btnRegistraLibro.Text = "Registrar Libro";
            btnRegistraLibro.UseVisualStyleBackColor = true;
            btnRegistraLibro.Click += btnRegistraLibro_Click;
            // 
            // btnLibrosDisponibles
            // 
            btnLibrosDisponibles.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLibrosDisponibles.Location = new Point(458, 123);
            btnLibrosDisponibles.Name = "btnLibrosDisponibles";
            btnLibrosDisponibles.Size = new Size(120, 68);
            btnLibrosDisponibles.TabIndex = 1;
            btnLibrosDisponibles.Text = "Libros Disponibles";
            btnLibrosDisponibles.UseVisualStyleBackColor = true;
            btnLibrosDisponibles.Click += btnLibrosDisponibles_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(52, 391);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 42);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Regresar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += button1_Click;
            // 
            // VentanaLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 449);
            Controls.Add(btnRegistrar);
            Controls.Add(btnLibrosDisponibles);
            Controls.Add(btnRegistraLibro);
            Name = "VentanaLibros";
            Text = "Ventana Libros";
            Load += VentanaLibros_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegistraLibro;
        private Button btnLibrosDisponibles;
        private Label prueba;
        private Button btnRegistrar;
    }
}