
namespace system_ACXAJY
{
    partial class ModuloProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuloProduct));
            this.label6 = new System.Windows.Forms.Label();
            this.lblPID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPDesc = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPCant = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPPre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.coBoxCateg = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.coBoxMat = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvSeleccionMat = new System.Windows.Forms.DataGridView();
            this.ID_detallepp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcantMaterial = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionMat)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Ingrese información de producto:";
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Location = new System.Drawing.Point(291, 126);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(110, 25);
            this.lblPID.TabIndex = 25;
            this.lblPID.Text = "Producto_ID";
            this.lblPID.Visible = false;
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
            this.panel2.Size = new System.Drawing.Size(1032, 70);
            this.panel2.TabIndex = 24;
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.Image")));
            this.pictureBoxExit.Location = new System.Drawing.Point(945, 13);
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
            this.label5.Location = new System.Drawing.Point(22, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(48, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nombre:";
            // 
            // txtPDesc
            // 
            this.txtPDesc.Location = new System.Drawing.Point(137, 286);
            this.txtPDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPDesc.Multiline = true;
            this.txtPDesc.Name = "txtPDesc";
            this.txtPDesc.Size = new System.Drawing.Size(264, 114);
            this.txtPDesc.TabIndex = 21;
            this.txtPDesc.UseSystemPasswordChar = true;
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(137, 174);
            this.txtPName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(264, 31);
            this.txtPName.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(117)))), ((int)(((byte)(157)))));
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 537);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 98);
            this.panel1.TabIndex = 19;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(885, 32);
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
            this.btnUpdate.Location = new System.Drawing.Point(750, 32);
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
            this.btnClear.Location = new System.Drawing.Point(639, 32);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 42);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Vaciar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(38, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 21);
            this.label4.TabIndex = 30;
            this.label4.Text = "Cantidad en almacén:";
            // 
            // txtPCant
            // 
            this.txtPCant.Location = new System.Drawing.Point(230, 422);
            this.txtPCant.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPCant.Name = "txtPCant";
            this.txtPCant.Size = new System.Drawing.Size(171, 31);
            this.txtPCant.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(66, 470);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 21);
            this.label7.TabIndex = 32;
            this.label7.Text = "Precio:";
            // 
            // txtPPre
            // 
            this.txtPPre.Location = new System.Drawing.Point(138, 470);
            this.txtPPre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPPre.Name = "txtPPre";
            this.txtPPre.Size = new System.Drawing.Size(263, 31);
            this.txtPPre.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 37;
            this.label1.Text = "Categoría:";
            // 
            // coBoxCateg
            // 
            this.coBoxCateg.DisplayMember = "nombre_categ";
            this.coBoxCateg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coBoxCateg.FormattingEnabled = true;
            this.coBoxCateg.Location = new System.Drawing.Point(138, 230);
            this.coBoxCateg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.coBoxCateg.Name = "coBoxCateg";
            this.coBoxCateg.Size = new System.Drawing.Size(263, 33);
            this.coBoxCateg.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(460, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(353, 21);
            this.label8.TabIndex = 69;
            this.label8.Text = "Ingrese información de elaboración de productos:";
            // 
            // coBoxMat
            // 
            this.coBoxMat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coBoxMat.FormattingEnabled = true;
            this.coBoxMat.Location = new System.Drawing.Point(582, 396);
            this.coBoxMat.Name = "coBoxMat";
            this.coBoxMat.Size = new System.Drawing.Size(231, 33);
            this.coBoxMat.TabIndex = 68;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(495, 396);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 21);
            this.label14.TabIndex = 65;
            this.label14.Text = "Material";
            // 
            // dgvSeleccionMat
            // 
            this.dgvSeleccionMat.AllowUserToAddRows = false;
            this.dgvSeleccionMat.AllowUserToDeleteRows = false;
            this.dgvSeleccionMat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.dgvSeleccionMat.ColumnHeadersHeight = 30;
            this.dgvSeleccionMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSeleccionMat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_detallepp,
            this.nom_prod,
            this.cantidad_p,
            this.costoMat,
            this.eliminar});
            this.dgvSeleccionMat.Location = new System.Drawing.Point(449, 163);
            this.dgvSeleccionMat.Name = "dgvSeleccionMat";
            this.dgvSeleccionMat.RowHeadersWidth = 10;
            this.dgvSeleccionMat.RowTemplate.Height = 28;
            this.dgvSeleccionMat.Size = new System.Drawing.Size(545, 171);
            this.dgvSeleccionMat.TabIndex = 64;
            this.dgvSeleccionMat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSeleccionMat_CellContentClick);
            // 
            // ID_detallepp
            // 
            this.ID_detallepp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_detallepp.HeaderText = "Número";
            this.ID_detallepp.MinimumWidth = 8;
            this.ID_detallepp.Name = "ID_detallepp";
            this.ID_detallepp.Width = 113;
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
            // costoMat
            // 
            this.costoMat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.costoMat.HeaderText = "Costo";
            this.costoMat.MinimumWidth = 8;
            this.costoMat.Name = "costoMat";
            this.costoMat.Width = 95;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(495, 444);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 21);
            this.label9.TabIndex = 70;
            this.label9.Text = "Cantidad";
            // 
            // txtcantMaterial
            // 
            this.txtcantMaterial.Location = new System.Drawing.Point(582, 438);
            this.txtcantMaterial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcantMaterial.Name = "txtcantMaterial";
            this.txtcantMaterial.Size = new System.Drawing.Size(171, 31);
            this.txtcantMaterial.TabIndex = 71;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(117)))), ((int)(((byte)(157)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.btnAdd.Location = new System.Drawing.Point(864, 402);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 71);
            this.btnAdd.TabIndex = 72;
            this.btnAdd.Text = "Agregar Material";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(420, 486);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 21);
            this.label10.TabIndex = 73;
            this.label10.Text = "Costo de elaboración:";
            // 
            // txtCosto
            // 
            this.txtCosto.Enabled = false;
            this.txtCosto.Location = new System.Drawing.Point(582, 480);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(171, 31);
            this.txtCosto.TabIndex = 74;
            this.txtCosto.Text = "0";
            // 
            // ModuloProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1032, 635);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtcantMaterial);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.coBoxMat);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dgvSeleccionMat);
            this.Controls.Add(this.coBoxCateg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPPre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPCant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPDesc);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ModuloProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRAR PRODUCTOS";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionMat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtPDesc;
        public System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtPCant;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtPPre;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox coBoxCateg;
        private Label label8;
        public ComboBox coBoxMat;
        private Label label14;
        private DataGridView dgvSeleccionMat;
        private Label label9;
        public TextBox txtcantMaterial;
        public Button btnAdd;
        private Label label10;
        public TextBox txtCosto;
        private DataGridViewTextBoxColumn ID_detallepp;
        private DataGridViewTextBoxColumn nom_prod;
        private DataGridViewTextBoxColumn cantidad_p;
        private DataGridViewTextBoxColumn costoMat;
        private DataGridViewImageColumn eliminar;
    }
}