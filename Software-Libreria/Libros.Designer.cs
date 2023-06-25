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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaLibros));
            btnRegistraLibro = new Button();
            btnLibrosDisponibles = new Button();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // btnRegistraLibro
            // 
            btnRegistraLibro.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistraLibro.ForeColor = Color.Sienna;
            btnRegistraLibro.Image = (Image)resources.GetObject("btnRegistraLibro.Image");
            btnRegistraLibro.Location = new Point(259, 205);
            btnRegistraLibro.Margin = new Padding(4, 5, 4, 5);
            btnRegistraLibro.Name = "btnRegistraLibro";
            btnRegistraLibro.Size = new Size(166, 113);
            btnRegistraLibro.TabIndex = 0;
            btnRegistraLibro.Text = "Registrar Libro";
            btnRegistraLibro.UseVisualStyleBackColor = true;
            btnRegistraLibro.Click += btnRegistraLibro_Click;
            // 
            // btnLibrosDisponibles
            // 
            btnLibrosDisponibles.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLibrosDisponibles.ForeColor = Color.Sienna;
            btnLibrosDisponibles.Image = (Image)resources.GetObject("btnLibrosDisponibles.Image");
            btnLibrosDisponibles.Location = new Point(654, 205);
            btnLibrosDisponibles.Margin = new Padding(4, 5, 4, 5);
            btnLibrosDisponibles.Name = "btnLibrosDisponibles";
            btnLibrosDisponibles.Size = new Size(171, 113);
            btnLibrosDisponibles.TabIndex = 1;
            btnLibrosDisponibles.Text = "Libros Disponibles";
            btnLibrosDisponibles.UseVisualStyleBackColor = true;
            btnLibrosDisponibles.Click += btnLibrosDisponibles_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(74, 652);
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
            ClientSize = new Size(1143, 748);
            Controls.Add(btnRegistrar);
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
        private Label prueba;
        private Button btnRegistrar;
    }
}