namespace Software_Libreria
{
    partial class WindowDashboard
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
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            btnClients = new Button();
            btnBooks = new Button();
            btnSales = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.NavajoWhite;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 64);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(497, 20);
            label1.Name = "label1";
            label1.Size = new Size(73, 32);
            label1.TabIndex = 1;
            label1.Text = "Hola ";
            // 
            // button1
            // 
            button1.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(14, 14);
            button1.Name = "button1";
            button1.Size = new Size(125, 38);
            button1.TabIndex = 0;
            button1.Text = "VOLVER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnClients
            // 
            btnClients.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClients.ForeColor = SystemColors.ActiveCaptionText;
            btnClients.Location = new Point(68, 143);
            btnClients.Name = "btnClients";
            btnClients.Size = new Size(125, 38);
            btnClients.TabIndex = 2;
            btnClients.Text = "CLIENTES";
            btnClients.UseVisualStyleBackColor = true;
            btnClients.Click += btnClients_Click;
            // 
            // btnBooks
            // 
            btnBooks.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBooks.ForeColor = SystemColors.ActiveCaptionText;
            btnBooks.Location = new Point(321, 143);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(125, 38);
            btnBooks.TabIndex = 3;
            btnBooks.Text = "LIBROS";
            btnBooks.UseVisualStyleBackColor = true;
            // 
            // btnSales
            // 
            btnSales.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSales.ForeColor = SystemColors.ActiveCaptionText;
            btnSales.Location = new Point(550, 143);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(222, 38);
            btnSales.TabIndex = 4;
            btnSales.Text = "REALIZAR VENTA";
            btnSales.UseVisualStyleBackColor = true;
            btnSales.Click += btnSales_Click;
            // 
            // WindowDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSales);
            Controls.Add(btnBooks);
            Controls.Add(btnClients);
            Controls.Add(panel1);
            Name = "WindowDashboard";
            Text = "Dashboard";
            Load += WindowDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Button btnBooks;
        private Button btnClients;
        private Button btnSales;
    }
}