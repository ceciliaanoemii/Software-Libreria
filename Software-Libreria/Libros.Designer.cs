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
            prueba = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnRegistraLibro
            // 
            btnRegistraLibro.Location = new Point(118, 174);
            btnRegistraLibro.Name = "btnRegistraLibro";
            btnRegistraLibro.Size = new Size(94, 42);
            btnRegistraLibro.TabIndex = 0;
            btnRegistraLibro.Text = "Registra Libro";
            btnRegistraLibro.UseVisualStyleBackColor = true;
            btnRegistraLibro.Click += btnRegistraLibro_Click;
            // 
            // btnLibrosDisponibles
            // 
            btnLibrosDisponibles.Location = new Point(367, 174);
            btnLibrosDisponibles.Name = "btnLibrosDisponibles";
            btnLibrosDisponibles.Size = new Size(108, 42);
            btnLibrosDisponibles.TabIndex = 1;
            btnLibrosDisponibles.Text = "Libros Disponibles";
            btnLibrosDisponibles.UseVisualStyleBackColor = true;
            btnLibrosDisponibles.Click += btnLibrosDisponibles_Click;
            // 
            // btnEliminarLibro
            // 
            btnEliminarLibro.Location = new Point(603, 174);
            btnEliminarLibro.Name = "btnEliminarLibro";
            btnEliminarLibro.Size = new Size(94, 42);
            btnEliminarLibro.TabIndex = 2;
            btnEliminarLibro.Text = "Eliminar Libros";
            btnEliminarLibro.UseVisualStyleBackColor = true;
            // 
            // prueba
            // 
            prueba.AutoSize = true;
            prueba.Location = new Point(353, 302);
            prueba.Name = "prueba";
            prueba.Size = new Size(38, 15);
            prueba.TabIndex = 3;
            prueba.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(455, 288);
            button1.Name = "button1";
            button1.Size = new Size(94, 42);
            button1.TabIndex = 4;
            button1.Text = "prueba";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // VentanaLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(prueba);
            Controls.Add(btnEliminarLibro);
            Controls.Add(btnLibrosDisponibles);
            Controls.Add(btnRegistraLibro);
            Name = "VentanaLibros";
            Text = "Ventana Libros";
            Load += VentanaLibros_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistraLibro;
        private Button btnLibrosDisponibles;
        private Button btnEliminarLibro;
        private Label prueba;
        private Button button1;
    }
}