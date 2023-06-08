namespace Software_Libreria
{
    partial class Form1
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
            textBox1 = new TextBox();
            Prueba = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(68, 55);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(599, 270);
            textBox1.TabIndex = 0;
            textBox1.Text = "Lucia";
            // 
            // Prueba
            // 
            Prueba.Location = new Point(555, 347);
            Prueba.Name = "Prueba";
            Prueba.Size = new Size(112, 34);
            Prueba.TabIndex = 1;
            Prueba.Text = "Prueba";
            Prueba.UseVisualStyleBackColor = true;
            Prueba.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 457);
            Controls.Add(Prueba);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button Prueba;
    }
}