namespace Software_Libreria
{
    partial class RegistroLibros
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
            components = new System.ComponentModel.Container();
            erperror = new ErrorProvider(components);
            gbRegistroLibros = new GroupBox();
            txtEditorial = new TextBox();
            txtprecio = new TextBox();
            txttitulo = new TextBox();
            txtautor = new TextBox();
            txtidlibro = new TextBox();
            lblprecio = new Label();
            lbleditorial = new Label();
            lblautor = new Label();
            lbltitulo = new Label();
            lblidlibro = new Label();
            btnRegistrar = new Button();
            dgvRegistrosTotales = new DataGridView();
            column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            column5 = new DataGridViewTextBoxColumn();
            btnSeleccionPic = new Button();
            boxPicture = new PictureBox();
            btnCopiarPic = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)erperror).BeginInit();
            gbRegistroLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistrosTotales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boxPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // erperror
            // 
            erperror.ContainerControl = this;
            // 
            // gbRegistroLibros
            // 
            gbRegistroLibros.Controls.Add(txtEditorial);
            gbRegistroLibros.Controls.Add(txtprecio);
            gbRegistroLibros.Controls.Add(txttitulo);
            gbRegistroLibros.Controls.Add(txtautor);
            gbRegistroLibros.Controls.Add(txtidlibro);
            gbRegistroLibros.Controls.Add(lblprecio);
            gbRegistroLibros.Controls.Add(lbleditorial);
            gbRegistroLibros.Controls.Add(lblautor);
            gbRegistroLibros.Controls.Add(lbltitulo);
            gbRegistroLibros.Controls.Add(lblidlibro);
            gbRegistroLibros.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gbRegistroLibros.Location = new Point(53, 41);
            gbRegistroLibros.Name = "gbRegistroLibros";
            gbRegistroLibros.Size = new Size(512, 171);
            gbRegistroLibros.TabIndex = 14;
            gbRegistroLibros.TabStop = false;
            gbRegistroLibros.Text = "Registro de Libros";
            gbRegistroLibros.Enter += groupBox1_Enter;
            // 
            // txtEditorial
            // 
            txtEditorial.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEditorial.Location = new Point(326, 102);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(157, 25);
            txtEditorial.TabIndex = 25;
            txtEditorial.TextChanged += txtEditorial_TextChanged;
            // 
            // txtprecio
            // 
            txtprecio.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtprecio.Location = new Point(90, 148);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(93, 25);
            txtprecio.TabIndex = 22;
            txtprecio.TextChanged += txtprecio_TextChanged;
            // 
            // txttitulo
            // 
            txttitulo.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txttitulo.Location = new Point(326, 57);
            txttitulo.Name = "txttitulo";
            txttitulo.Size = new Size(157, 25);
            txttitulo.TabIndex = 21;
            txttitulo.TextChanged += txttitulo_TextChanged_1;
            // 
            // txtautor
            // 
            txtautor.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtautor.Location = new Point(88, 102);
            txtautor.Name = "txtautor";
            txtautor.Size = new Size(133, 25);
            txtautor.TabIndex = 20;
            txtautor.TextChanged += txtautor_TextChanged;
            // 
            // txtidlibro
            // 
            txtidlibro.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtidlibro.Location = new Point(88, 57);
            txtidlibro.Name = "txtidlibro";
            txtidlibro.Size = new Size(133, 25);
            txtidlibro.TabIndex = 19;
            txtidlibro.TextChanged += txtidlibro_TextChanged;
            // 
            // lblprecio
            // 
            lblprecio.AutoSize = true;
            lblprecio.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblprecio.Location = new Point(26, 151);
            lblprecio.Name = "lblprecio";
            lblprecio.Size = new Size(58, 18);
            lblprecio.TabIndex = 18;
            lblprecio.Text = "Precio :";
            // 
            // lbleditorial
            // 
            lbleditorial.AutoSize = true;
            lbleditorial.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbleditorial.Location = new Point(246, 105);
            lbleditorial.Name = "lbleditorial";
            lbleditorial.Size = new Size(74, 18);
            lbleditorial.TabIndex = 17;
            lbleditorial.Text = "Editorial :";
            // 
            // lblautor
            // 
            lblautor.AutoSize = true;
            lblautor.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblautor.Location = new Point(31, 105);
            lblautor.Name = "lblautor";
            lblautor.Size = new Size(51, 18);
            lblautor.TabIndex = 16;
            lblautor.Text = "Autor:";
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbltitulo.Location = new Point(246, 60);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(56, 18);
            lbltitulo.TabIndex = 15;
            lbltitulo.Text = "Titulo :";
            // 
            // lblidlibro
            // 
            lblidlibro.AutoSize = true;
            lblidlibro.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblidlibro.Location = new Point(11, 60);
            lblidlibro.Name = "lblidlibro";
            lblidlibro.Size = new Size(71, 18);
            lblidlibro.TabIndex = 14;
            lblidlibro.Text = "Id Libro :";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrar.Location = new Point(299, 391);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(133, 37);
            btnRegistrar.TabIndex = 24;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // dgvRegistrosTotales
            // 
            dgvRegistrosTotales.BackgroundColor = SystemColors.ButtonHighlight;
            dgvRegistrosTotales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistrosTotales.Columns.AddRange(new DataGridViewColumn[] { column1, Column2, column3, Column4, column5 });
            dgvRegistrosTotales.Location = new Point(37, 248);
            dgvRegistrosTotales.Name = "dgvRegistrosTotales";
            dgvRegistrosTotales.RowTemplate.Height = 25;
            dgvRegistrosTotales.Size = new Size(512, 137);
            dgvRegistrosTotales.TabIndex = 10;
            dgvRegistrosTotales.CellContentClick += dataGridView1_CellContentClick;
            // 
            // column1
            // 
            column1.HeaderText = "Id Libro";
            column1.Name = "column1";
            column1.Width = 72;
            // 
            // Column2
            // 
            Column2.HeaderText = "Titulo";
            Column2.Name = "Column2";
            // 
            // column3
            // 
            column3.HeaderText = "Autor";
            column3.Name = "column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Editorial";
            Column4.Name = "Column4";
            // 
            // column5
            // 
            column5.HeaderText = "Precio";
            column5.Name = "column5";
            // 
            // btnSeleccionPic
            // 
            btnSeleccionPic.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSeleccionPic.ImageAlign = ContentAlignment.TopCenter;
            btnSeleccionPic.Location = new Point(644, 192);
            btnSeleccionPic.Margin = new Padding(1);
            btnSeleccionPic.Name = "btnSeleccionPic";
            btnSeleccionPic.Size = new Size(52, 41);
            btnSeleccionPic.TabIndex = 25;
            btnSeleccionPic.Text = "+";
            btnSeleccionPic.UseVisualStyleBackColor = true;
            btnSeleccionPic.Click += btnSeleccionPic_Click;
            // 
            // boxPicture
            // 
            boxPicture.BorderStyle = BorderStyle.FixedSingle;
            boxPicture.Location = new Point(582, 41);
            boxPicture.Name = "boxPicture";
            boxPicture.Size = new Size(170, 202);
            boxPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            boxPicture.TabIndex = 26;
            boxPicture.TabStop = false;
            // 
            // btnCopiarPic
            // 
            btnCopiarPic.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCopiarPic.Location = new Point(599, 249);
            btnCopiarPic.Name = "btnCopiarPic";
            btnCopiarPic.Size = new Size(133, 39);
            btnCopiarPic.TabIndex = 27;
            btnCopiarPic.Text = "Guardar imagen";
            btnCopiarPic.UseVisualStyleBackColor = true;
            btnCopiarPic.Click += btnCopiarPic_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(143, 391);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(133, 37);
            btnCancelar.TabIndex = 28;
            btnCancelar.Text = "Regresar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(266, 8);
            label1.Name = "label1";
            label1.Size = new Size(283, 32);
            label1.TabIndex = 29;
            label1.Text = "Registro de nuevo libro";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // RegistroLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(764, 440);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnSeleccionPic);
            Controls.Add(btnCopiarPic);
            Controls.Add(btnRegistrar);
            Controls.Add(gbRegistroLibros);
            Controls.Add(dgvRegistrosTotales);
            Controls.Add(boxPicture);
            ForeColor = SystemColors.ControlText;
            Name = "RegistroLibros";
            Opacity = 0.7D;
            Text = "Registrar Libros";
            TransparencyKey = Color.FromArgb(255, 192, 192);
            Load += RegistroLibros_Load;
            ((System.ComponentModel.ISupportInitialize)erperror).EndInit();
            gbRegistroLibros.ResumeLayout(false);
            gbRegistroLibros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistrosTotales).EndInit();
            ((System.ComponentModel.ISupportInitialize)boxPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ErrorProvider erperror;
        private GroupBox gbRegistroLibros;
        private Button btnRegistrar;
        private TextBox txtprecio;
        private TextBox txttitulo;
        private TextBox txtautor;
        private TextBox txtidlibro;
        private Label lblprecio;
        private Label lbleditorial;
        private Label lblautor;
        private Label lbltitulo;
        private Label lblidlibro;
        private DataGridView dgvRegistrosTotales;
        private DataGridViewTextBoxColumn column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn column5;
        private TextBox txtEditorial;
        private Button btnSeleccionPic;
        private Label label1;
        private Button btnCancelar;
        private Button btnCopiarPic;
        private PictureBox boxPicture;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
    }
}