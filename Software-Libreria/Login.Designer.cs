namespace Software_Libreria
{
    partial class WindowLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnIngresar = new Button();
            label1 = new Label();
            label3 = new Label();
            nombreUsuario = new TextBox();
            panel1 = new Panel();
            contrasenia = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.LemonChiffon;
            btnIngresar.Font = new Font("Book Antiqua", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.Location = new Point(216, 208);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(230, 39);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += Ingresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(78, 67);
            label1.Name = "label1";
            label1.Padding = new Padding(4, 0, 4, 0);
            label1.Size = new Size(97, 23);
            label1.TabIndex = 1;
            label1.Text = "Usuario :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(47, 152);
            label3.Name = "label3";
            label3.Padding = new Padding(4, 0, 4, 0);
            label3.Size = new Size(128, 23);
            label3.TabIndex = 2;
            label3.Text = "Contraseña :";
            // 
            // nombreUsuario
            // 
            nombreUsuario.BackColor = SystemColors.HighlightText;
            nombreUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nombreUsuario.ForeColor = SystemColors.ActiveCaptionText;
            nombreUsuario.Location = new Point(235, 58);
            nombreUsuario.Name = "nombreUsuario";
            nombreUsuario.PlaceholderText = "Ingresar nombre";
            nombreUsuario.Size = new Size(192, 29);
            nombreUsuario.TabIndex = 3;
            nombreUsuario.TextChanged += nombreUsuario_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.OldLace;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(contrasenia);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnIngresar);
            panel1.Controls.Add(nombreUsuario);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(293, 229);
            panel1.Name = "panel1";
            panel1.Size = new Size(518, 268);
            panel1.TabIndex = 6;
            // 
            // contrasenia
            // 
            contrasenia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            contrasenia.ForeColor = SystemColors.ActiveCaptionText;
            contrasenia.Location = new Point(235, 152);
            contrasenia.Name = "contrasenia";
            contrasenia.PlaceholderText = "Ingresar contraseña";
            contrasenia.Size = new Size(192, 29);
            contrasenia.TabIndex = 4;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // WindowLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackgroundImage = Properties.Resources.palacio_nacional_de_mafra_g8427d07ba_1280;
            ClientSize = new Size(1008, 729);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "WindowLogin";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnIngresar;
        private Label label1;
        private Label label3;
        private TextBox nombreUsuario;
        private Panel panel1;
        private ErrorProvider errorProvider1;
        private TextBox contrasenia;
    }
}