
namespace system_ACXAJY
{
    partial class ModuloVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuloVentas));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCantP = new System.Windows.Forms.TextBox();
            this.coBoxProd = new System.Windows.Forms.ComboBox();
            this.coBoxCateg = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvSeleccionProd = new System.Windows.Forms.DataGridView();
            this.ID_detallepp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dTimeVenta = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionProd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(117)))), ((int)(((byte)(157)))));
            this.panel2.Controls.Add(this.pictureBoxExit);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(741, 70);
            this.panel2.TabIndex = 56;
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.Image")));
            this.pictureBoxExit.Location = new System.Drawing.Point(658, 11);
            this.pictureBoxExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(49, 46);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExit.TabIndex = 10;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.label5.Location = new System.Drawing.Point(28, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Venta";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(117)))), ((int)(((byte)(157)))));
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 562);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 73);
            this.panel1.TabIndex = 55;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(319, 18);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 42);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Vaciar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(598, 18);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 42);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdate.Location = new System.Drawing.Point(463, 18);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 42);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(169, 521);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 21);
            this.label10.TabIndex = 89;
            this.label10.Text = "$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(31, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 21);
            this.label7.TabIndex = 88;
            this.label7.Text = "Ingrese información de productos:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(117)))), ((int)(((byte)(157)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.btnAdd.Location = new System.Drawing.Point(577, 371);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 71);
            this.btnAdd.TabIndex = 87;
            this.btnAdd.Text = "Agregar Producto";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCantP
            // 
            this.txtCantP.Location = new System.Drawing.Point(177, 421);
            this.txtCantP.Name = "txtCantP";
            this.txtCantP.Size = new System.Drawing.Size(166, 31);
            this.txtCantP.TabIndex = 86;
            // 
            // coBoxProd
            // 
            this.coBoxProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coBoxProd.FormattingEnabled = true;
            this.coBoxProd.Location = new System.Drawing.Point(177, 378);
            this.coBoxProd.Name = "coBoxProd";
            this.coBoxProd.Size = new System.Drawing.Size(231, 33);
            this.coBoxProd.TabIndex = 85;
            // 
            // coBoxCateg
            // 
            this.coBoxCateg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coBoxCateg.FormattingEnabled = true;
            this.coBoxCateg.Location = new System.Drawing.Point(177, 337);
            this.coBoxCateg.Name = "coBoxCateg";
            this.coBoxCateg.Size = new System.Drawing.Size(231, 33);
            this.coBoxCateg.TabIndex = 84;
            this.coBoxCateg.SelectedIndexChanged += new System.EventHandler(this.coBoxCateg_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(82, 339);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 21);
            this.label11.TabIndex = 83;
            this.label11.Text = "Categoría:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(82, 421);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 21);
            this.label12.TabIndex = 82;
            this.label12.Text = "Cantidad:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(91, 384);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 21);
            this.label14.TabIndex = 80;
            this.label14.Text = "Nombre:";
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Enabled = false;
            this.txtTotalPagar.Location = new System.Drawing.Point(184, 515);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(94, 31);
            this.txtTotalPagar.TabIndex = 74;
            this.txtTotalPagar.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(28, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 21);
            this.label4.TabIndex = 73;
            this.label4.Text = "Productos seleccionados:";
            // 
            // dgvSeleccionProd
            // 
            this.dgvSeleccionProd.AllowUserToAddRows = false;
            this.dgvSeleccionProd.AllowUserToDeleteRows = false;
            this.dgvSeleccionProd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.dgvSeleccionProd.ColumnHeadersHeight = 30;
            this.dgvSeleccionProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSeleccionProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_detallepp,
            this.nom_prod,
            this.cantidad_p,
            this.precio_p,
            this.eliminar});
            this.dgvSeleccionProd.Location = new System.Drawing.Point(32, 113);
            this.dgvSeleccionProd.Name = "dgvSeleccionProd";
            this.dgvSeleccionProd.RowHeadersWidth = 10;
            this.dgvSeleccionProd.RowTemplate.Height = 28;
            this.dgvSeleccionProd.Size = new System.Drawing.Size(675, 171);
            this.dgvSeleccionProd.TabIndex = 72;
            this.dgvSeleccionProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSeleccionProd_CellContentClick);
            // 
            // ID_detallepp
            // 
            this.ID_detallepp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_detallepp.HeaderText = "Número";
            this.ID_detallepp.MinimumWidth = 8;
            this.ID_detallepp.Name = "ID_detallepp";
            this.ID_detallepp.Visible = false;
            this.ID_detallepp.Width = 150;
            // 
            // nom_prod
            // 
            this.nom_prod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nom_prod.HeaderText = "Nombre";
            this.nom_prod.MinimumWidth = 8;
            this.nom_prod.Name = "nom_prod";
            // 
            // cantidad_p
            // 
            this.cantidad_p.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cantidad_p.HeaderText = "Cantidad";
            this.cantidad_p.MinimumWidth = 8;
            this.cantidad_p.Name = "cantidad_p";
            this.cantidad_p.Width = 119;
            // 
            // precio_p
            // 
            this.precio_p.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.precio_p.HeaderText = "Precio";
            this.precio_p.MinimumWidth = 8;
            this.precio_p.Name = "precio_p";
            this.precio_p.Width = 96;
            // 
            // eliminar
            // 
            this.eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.eliminar.HeaderText = "";
            this.eliminar.Image = ((System.Drawing.Image)(resources.GetObject("eliminar.Image")));
            this.eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.eliminar.MinimumWidth = 8;
            this.eliminar.Name = "eliminar";
            this.eliminar.Width = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 71;
            this.label1.Text = "Total a pagar:";
            // 
            // lblVID
            // 
            this.lblVID.AutoSize = true;
            this.lblVID.Location = new System.Drawing.Point(590, 298);
            this.lblVID.Name = "lblVID";
            this.lblVID.Size = new System.Drawing.Size(81, 25);
            this.lblVID.TabIndex = 69;
            this.lblVID.Text = "Venta_ID";
            this.lblVID.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(41, 482);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 21);
            this.label8.TabIndex = 76;
            this.label8.Text = "Fecha de venta:";
            // 
            // dTimeVenta
            // 
            this.dTimeVenta.Location = new System.Drawing.Point(169, 474);
            this.dTimeVenta.Name = "dTimeVenta";
            this.dTimeVenta.Size = new System.Drawing.Size(305, 31);
            this.dTimeVenta.TabIndex = 75;
            // 
            // ModuloVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(741, 635);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCantP);
            this.Controls.Add(this.coBoxProd);
            this.Controls.Add(this.coBoxCateg);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dTimeVenta);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvSeleccionProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ModuloVentas";
            this.Text = "ModuloVentas";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnUpdate;
        private Label label10;
        private Label label7;
        public Button btnAdd;
        public TextBox txtCantP;
        public ComboBox coBoxProd;
        public ComboBox coBoxCateg;
        private Label label11;
        private Label label12;
        private Label label14;
        public TextBox txtTotalPagar;
        private Label label4;
        private DataGridView dgvSeleccionProd;
        private Label label1;
        public Label lblVID;
        private Label label8;
        public DateTimePicker dTimeVenta;
        public Button btnClear;
        private DataGridViewTextBoxColumn ID_detallepp;
        private DataGridViewTextBoxColumn nom_prod;
        private DataGridViewTextBoxColumn cantidad_p;
        private DataGridViewTextBoxColumn precio_p;
        private DataGridViewImageColumn eliminar;
    }
}