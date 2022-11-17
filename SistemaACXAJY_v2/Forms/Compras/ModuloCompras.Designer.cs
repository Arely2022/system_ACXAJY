
namespace system_ACXAJY
{
    partial class ModuloCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuloCompras));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblPID = new System.Windows.Forms.Label();
            this.txtCantMat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtprecioMat = new System.Windows.Forms.TextBox();
            this.coBoxMat = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dTimeCompra = new System.Windows.Forms.DateTimePicker();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSeleccionMat = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCID = new System.Windows.Forms.Label();
            this.ID_detallecm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_mat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_m = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_m = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionMat)).BeginInit();
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
            this.panel2.TabIndex = 58;
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.Image")));
            this.pictureBoxExit.Location = new System.Drawing.Point(667, 13);
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
            this.label5.Location = new System.Drawing.Point(20, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Compra";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(117)))), ((int)(((byte)(157)))));
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 553);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 82);
            this.panel1.TabIndex = 57;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(608, 17);
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
            this.btnUpdate.Location = new System.Drawing.Point(473, 17);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 42);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(362, 17);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 42);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Vaciar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Location = new System.Drawing.Point(267, 119);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(101, 25);
            this.lblPID.TabIndex = 67;
            this.lblPID.Text = "Compra_ID";
            this.lblPID.Visible = false;
            // 
            // txtCantMat
            // 
            this.txtCantMat.Location = new System.Drawing.Point(174, 414);
            this.txtCantMat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCantMat.Name = "txtCantMat";
            this.txtCantMat.Size = new System.Drawing.Size(194, 31);
            this.txtCantMat.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(79, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 63;
            this.label2.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(86, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 60;
            this.label3.Text = "Material:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(174, 499);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 21);
            this.label10.TabIndex = 105;
            this.label10.Text = "$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(69, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 21);
            this.label7.TabIndex = 104;
            this.label7.Text = "Ingrese información de Material:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(117)))), ((int)(((byte)(157)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.btnAdd.Location = new System.Drawing.Point(560, 463);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 71);
            this.btnAdd.TabIndex = 103;
            this.btnAdd.Text = "Agregar Producto";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtprecioMat
            // 
            this.txtprecioMat.Location = new System.Drawing.Point(174, 375);
            this.txtprecioMat.Name = "txtprecioMat";
            this.txtprecioMat.Size = new System.Drawing.Size(166, 31);
            this.txtprecioMat.TabIndex = 102;
            // 
            // coBoxMat
            // 
            this.coBoxMat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coBoxMat.FormattingEnabled = true;
            this.coBoxMat.Location = new System.Drawing.Point(174, 336);
            this.coBoxMat.Name = "coBoxMat";
            this.coBoxMat.Size = new System.Drawing.Size(231, 33);
            this.coBoxMat.TabIndex = 101;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(100, 381);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 21);
            this.label12.TabIndex = 98;
            this.label12.Text = "Precio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(42, 463);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 21);
            this.label8.TabIndex = 96;
            this.label8.Text = "Fecha de venta:";
            // 
            // dTimeCompra
            // 
            this.dTimeCompra.Location = new System.Drawing.Point(174, 453);
            this.dTimeCompra.Name = "dTimeCompra";
            this.dTimeCompra.Size = new System.Drawing.Size(292, 31);
            this.dTimeCompra.TabIndex = 95;
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Enabled = false;
            this.txtTotalPagar.Location = new System.Drawing.Point(209, 493);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(94, 31);
            this.txtTotalPagar.TabIndex = 94;
            this.txtTotalPagar.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(42, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 21);
            this.label1.TabIndex = 93;
            this.label1.Text = "Material seleccionados:";
            // 
            // dgvSeleccionMat
            // 
            this.dgvSeleccionMat.AllowUserToAddRows = false;
            this.dgvSeleccionMat.AllowUserToDeleteRows = false;
            this.dgvSeleccionMat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.dgvSeleccionMat.ColumnHeadersHeight = 30;
            this.dgvSeleccionMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSeleccionMat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_detallecm,
            this.nom_mat,
            this.cantidad_m,
            this.precio_m,
            this.eliminar});
            this.dgvSeleccionMat.Location = new System.Drawing.Point(42, 117);
            this.dgvSeleccionMat.Name = "dgvSeleccionMat";
            this.dgvSeleccionMat.RowHeadersWidth = 10;
            this.dgvSeleccionMat.RowTemplate.Height = 28;
            this.dgvSeleccionMat.Size = new System.Drawing.Size(675, 171);
            this.dgvSeleccionMat.TabIndex = 92;
            this.dgvSeleccionMat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSeleccionMat_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(53, 499);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 21);
            this.label6.TabIndex = 91;
            this.label6.Text = "Total Compra:";
            // 
            // lblCID
            // 
            this.lblCID.AutoSize = true;
            this.lblCID.Location = new System.Drawing.Point(318, 291);
            this.lblCID.Name = "lblCID";
            this.lblCID.Size = new System.Drawing.Size(101, 25);
            this.lblCID.TabIndex = 90;
            this.lblCID.Text = "Compra_ID";
            this.lblCID.Visible = false;
            // 
            // ID_detallecm
            // 
            this.ID_detallecm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_detallecm.HeaderText = "Número";
            this.ID_detallecm.MinimumWidth = 8;
            this.ID_detallecm.Name = "ID_detallecm";
            this.ID_detallecm.Visible = false;
            this.ID_detallecm.Width = 113;
            // 
            // nom_mat
            // 
            this.nom_mat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nom_mat.HeaderText = "Nombre";
            this.nom_mat.MinimumWidth = 8;
            this.nom_mat.Name = "nom_mat";
            // 
            // cantidad_m
            // 
            this.cantidad_m.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cantidad_m.HeaderText = "Cantidad";
            this.cantidad_m.MinimumWidth = 8;
            this.cantidad_m.Name = "cantidad_m";
            this.cantidad_m.Width = 119;
            // 
            // precio_m
            // 
            this.precio_m.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.precio_m.HeaderText = "Precio";
            this.precio_m.MinimumWidth = 8;
            this.precio_m.Name = "precio_m";
            this.precio_m.Width = 96;
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
            // ModuloCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(741, 635);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtprecioMat);
            this.Controls.Add(this.coBoxMat);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dTimeCompra);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSeleccionMat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCID);
            this.Controls.Add(this.lblPID);
            this.Controls.Add(this.txtCantMat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ModuloCompras";
            this.Text = "ModuloCompras";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionMat)).EndInit();
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
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Label lblPID;
        public System.Windows.Forms.TextBox txtCantMat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Label label10;
        private Label label7;
        public Button btnAdd;
        public TextBox txtprecioMat;
        public ComboBox coBoxMat;
        private Label label12;
        private Label label8;
        public DateTimePicker dTimeCompra;
        public TextBox txtTotalPagar;
        private Label label1;
        private DataGridView dgvSeleccionMat;
        private Label label6;
        public Label lblCID;
        private DataGridViewTextBoxColumn ID_detallecm;
        private DataGridViewTextBoxColumn nom_mat;
        private DataGridViewTextBoxColumn cantidad_m;
        private DataGridViewTextBoxColumn precio_m;
        private DataGridViewImageColumn eliminar;
    }
}