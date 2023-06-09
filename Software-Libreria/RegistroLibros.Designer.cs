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
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsleliminar = new System.Windows.Forms.ToolStripLabel();
            this.tslbuscar = new System.Windows.Forms.ToolStripLabel();
            this.tslRegresar = new System.Windows.Forms.ToolStripLabel();
            this.erperror = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbRegistroLibros = new System.Windows.Forms.GroupBox();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.txtautor = new System.Windows.Forms.TextBox();
            this.txtidlibro = new System.Windows.Forms.TextBox();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lbleditorial = new System.Windows.Forms.Label();
            this.lblautor = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblidlibro = new System.Windows.Forms.Label();
            this.dgvRegistrosTotales = new System.Windows.Forms.DataGridView();
            this.column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir2 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erperror)).BeginInit();
            this.gbRegistroLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrosTotales)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsleliminar,
            this.tslbuscar,
            this.tslRegresar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(764, 29);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsleliminar
            // 
            this.tsleliminar.Name = "tsleliminar";
            this.tsleliminar.Size = new System.Drawing.Size(81, 26);
            this.tsleliminar.Text = "Eliminar";
            // 
            // tslbuscar
            // 
            this.tslbuscar.Name = "tslbuscar";
            this.tslbuscar.Size = new System.Drawing.Size(74, 26);
            this.tslbuscar.Text = "Buscar";
            this.tslbuscar.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // tslRegresar
            // 
            this.tslRegresar.Name = "tslRegresar";
            this.tslRegresar.Size = new System.Drawing.Size(93, 26);
            this.tslRegresar.Text = "Regresar";
            this.tslRegresar.Click += new System.EventHandler(this.tslsalir_Click);
            // 
            // erperror
            // 
            this.erperror.ContainerControl = this;
            // 
            // gbRegistroLibros
            // 
            this.gbRegistroLibros.Controls.Add(this.txtEditorial);
            this.gbRegistroLibros.Controls.Add(this.btnRegistrar);
            this.gbRegistroLibros.Controls.Add(this.txtprecio);
            this.gbRegistroLibros.Controls.Add(this.txttitulo);
            this.gbRegistroLibros.Controls.Add(this.txtautor);
            this.gbRegistroLibros.Controls.Add(this.txtidlibro);
            this.gbRegistroLibros.Controls.Add(this.lblprecio);
            this.gbRegistroLibros.Controls.Add(this.lbleditorial);
            this.gbRegistroLibros.Controls.Add(this.lblautor);
            this.gbRegistroLibros.Controls.Add(this.lbltitulo);
            this.gbRegistroLibros.Controls.Add(this.lblidlibro);
            this.gbRegistroLibros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbRegistroLibros.Location = new System.Drawing.Point(42, 47);
            this.gbRegistroLibros.Name = "gbRegistroLibros";
            this.gbRegistroLibros.Size = new System.Drawing.Size(678, 171);
            this.gbRegistroLibros.TabIndex = 14;
            this.gbRegistroLibros.TabStop = false;
            this.gbRegistroLibros.Text = "Registro de Libros";
            this.gbRegistroLibros.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtEditorial
            // 
            this.txtEditorial.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEditorial.Location = new System.Drawing.Point(326, 102);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(157, 25);
            this.txtEditorial.TabIndex = 25;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrar.Location = new System.Drawing.Point(535, 105);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(133, 37);
            this.btnRegistrar.TabIndex = 24;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtprecio
            // 
            this.txtprecio.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtprecio.Location = new System.Drawing.Point(564, 57);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(93, 25);
            this.txtprecio.TabIndex = 22;
            // 
            // txttitulo
            // 
            this.txttitulo.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txttitulo.Location = new System.Drawing.Point(326, 57);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(157, 25);
            this.txttitulo.TabIndex = 21;
            // 
            // txtautor
            // 
            this.txtautor.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtautor.Location = new System.Drawing.Point(88, 102);
            this.txtautor.Name = "txtautor";
            this.txtautor.Size = new System.Drawing.Size(133, 25);
            this.txtautor.TabIndex = 20;
            // 
            // txtidlibro
            // 
            this.txtidlibro.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtidlibro.Location = new System.Drawing.Point(88, 57);
            this.txtidlibro.Name = "txtidlibro";
            this.txtidlibro.Size = new System.Drawing.Size(133, 25);
            this.txtidlibro.TabIndex = 19;
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblprecio.Location = new System.Drawing.Point(502, 60);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(58, 18);
            this.lblprecio.TabIndex = 18;
            this.lblprecio.Text = "Precio :";
            // 
            // lbleditorial
            // 
            this.lbleditorial.AutoSize = true;
            this.lbleditorial.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbleditorial.Location = new System.Drawing.Point(246, 105);
            this.lbleditorial.Name = "lbleditorial";
            this.lbleditorial.Size = new System.Drawing.Size(74, 18);
            this.lbleditorial.TabIndex = 17;
            this.lbleditorial.Text = "Editorial :";
            // 
            // lblautor
            // 
            this.lblautor.AutoSize = true;
            this.lblautor.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblautor.Location = new System.Drawing.Point(31, 105);
            this.lblautor.Name = "lblautor";
            this.lblautor.Size = new System.Drawing.Size(51, 18);
            this.lblautor.TabIndex = 16;
            this.lblautor.Text = "Autor:";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltitulo.Location = new System.Drawing.Point(246, 60);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(56, 18);
            this.lbltitulo.TabIndex = 15;
            this.lbltitulo.Text = "Titulo :";
            // 
            // lblidlibro
            // 
            this.lblidlibro.AutoSize = true;
            this.lblidlibro.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblidlibro.Location = new System.Drawing.Point(11, 60);
            this.lblidlibro.Name = "lblidlibro";
            this.lblidlibro.Size = new System.Drawing.Size(71, 18);
            this.lblidlibro.TabIndex = 14;
            this.lblidlibro.Text = "Id Libro :";
            // 
            // dgvRegistrosTotales
            // 
            this.dgvRegistrosTotales.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRegistrosTotales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistrosTotales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column1,
            this.Column2,
            this.column3,
            this.Column4,
            this.column5});
            this.dgvRegistrosTotales.Location = new System.Drawing.Point(130, 224);
            this.dgvRegistrosTotales.Name = "dgvRegistrosTotales";
            this.dgvRegistrosTotales.RowTemplate.Height = 25;
            this.dgvRegistrosTotales.Size = new System.Drawing.Size(512, 137);
            this.dgvRegistrosTotales.TabIndex = 10;
            this.dgvRegistrosTotales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // column1
            // 
            this.column1.HeaderText = "Id Libro";
            this.column1.Name = "column1";
            this.column1.Width = 72;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Titulo";
            this.Column2.Name = "Column2";
            // 
            // column3
            // 
            this.column3.HeaderText = "Autor";
            this.column3.Name = "column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Editorial";
            this.Column4.Name = "Column4";
            // 
            // column5
            // 
            this.column5.HeaderText = "Precio";
            this.column5.Name = "column5";
            // 
            // btnSalir2
            // 
            this.btnSalir2.Location = new System.Drawing.Point(651, 386);
            this.btnSalir2.Name = "btnSalir2";
            this.btnSalir2.Size = new System.Drawing.Size(101, 42);
            this.btnSalir2.TabIndex = 15;
            this.btnSalir2.Text = "SALIR";
            this.btnSalir2.UseVisualStyleBackColor = true;
            this.btnSalir2.Click += new System.EventHandler(this.btnSalir2_Click);
            // 
            // RegistroLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 440);
            this.Controls.Add(this.btnSalir2);
            this.Controls.Add(this.gbRegistroLibros);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvRegistrosTotales);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "RegistroLibros";
            this.Text = "la";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erperror)).EndInit();
            this.gbRegistroLibros.ResumeLayout(false);
            this.gbRegistroLibros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrosTotales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripLabel tsleliminar;
        private ToolStripLabel tslbuscar;
        private ToolStripLabel tslRegresar;
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
        private Button btnSalir2;
    }
}