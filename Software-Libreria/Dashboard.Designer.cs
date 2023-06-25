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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowDashboard));
            button1 = new Button();
            btnBooks = new Button();
            btnSales = new Button();
            btnClients = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ScrollBar;
            button1.Font = new Font("Bell MT", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(13, 24);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(84, 41);
            button1.TabIndex = 0;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // btnBooks
            // 
            btnBooks.FlatStyle = FlatStyle.Flat;
            btnBooks.Font = new Font("Bauhaus 93", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnBooks.ForeColor = Color.Sienna;
            btnBooks.Image = (Image)resources.GetObject("btnBooks.Image");
            btnBooks.Location = new Point(382, 99);
            btnBooks.Margin = new Padding(4, 5, 4, 5);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(337, 63);
            btnBooks.TabIndex = 3;
            btnBooks.Text = "LIBROS";
            btnBooks.UseVisualStyleBackColor = true;
            btnBooks.Click += btnBooks_Click;
            // 
            // btnSales
            // 
            btnSales.Font = new Font("Bauhaus 93", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnSales.ForeColor = Color.Sienna;
            btnSales.Image = (Image)resources.GetObject("btnSales.Image");
            btnSales.Location = new Point(382, 294);
            btnSales.Margin = new Padding(4, 5, 4, 5);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(337, 73);
            btnSales.TabIndex = 4;
            btnSales.Text = "REALIZAR VENTA";
            btnSales.UseVisualStyleBackColor = true;
            btnSales.Click += btnSales_Click_1;
            // 
            // btnClients
            // 
            btnClients.Font = new Font("Bauhaus 93", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnClients.ForeColor = Color.Sienna;
            btnClients.Image = (Image)resources.GetObject("btnClients.Image");
            btnClients.Location = new Point(382, 192);
            btnClients.Margin = new Padding(4, 5, 4, 5);
            btnClients.Name = "btnClients";
            btnClients.Size = new Size(337, 63);
            btnClients.TabIndex = 2;
            btnClients.Text = "CLIENTES";
            btnClients.UseVisualStyleBackColor = true;
            btnClients.Click += btnClients_Click;
            // 
            // WindowDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1120, 510);
            Controls.Add(btnSales);
            Controls.Add(button1);
            Controls.Add(btnBooks);
            Controls.Add(btnClients);
            ForeColor = SystemColors.ActiveCaption;
            Margin = new Padding(4, 5, 4, 5);
            Name = "WindowDashboard";
            Text = "Dashboard";
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button btnBooks;
        private Button btnSales;
        private EventHandler button1_Click_1;
        private Button btnClients;
    }
}