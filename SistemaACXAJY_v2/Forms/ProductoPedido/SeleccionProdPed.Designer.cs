
namespace system_ACXAJY
{
    partial class SeleccionProdPed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionProdPed));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvSeleccionProd = new System.Windows.Forms.DataGridView();
            this.ID_detallepp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adi_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coBoxCateg = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPPID = new System.Windows.Forms.Label();
            this.txtPCarac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIDPed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.coBoxProd = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
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
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 56);
            this.panel2.TabIndex = 26;
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.Image")));
            this.pictureBoxExit.Location = new System.Drawing.Point(928, 12);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(44, 37);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExit.TabIndex = 10;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.label5.Location = new System.Drawing.Point(34, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(330, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "SELECCIÓN DE PRODUCTOS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(117)))), ((int)(((byte)(157)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 455);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 78);
            this.panel1.TabIndex = 25;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(117)))), ((int)(((byte)(157)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.btnAdd.Location = new System.Drawing.Point(268, 395);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 34);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(117)))), ((int)(((byte)(157)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.btnUpdate.Location = new System.Drawing.Point(147, 395);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 34);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(117)))), ((int)(((byte)(157)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.btnClear.Location = new System.Drawing.Point(47, 395);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 34);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Vaciar";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // dgvSeleccionProd
            // 
            this.dgvSeleccionProd.AllowUserToAddRows = false;
            this.dgvSeleccionProd.AllowUserToDeleteRows = false;
            this.dgvSeleccionProd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.dgvSeleccionProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeleccionProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_detallepp,
            this.nom_prod,
            this.cantidad_p,
            this.adi_p,
            this.precio_p});
            this.dgvSeleccionProd.Location = new System.Drawing.Point(410, 111);
            this.dgvSeleccionProd.Name = "dgvSeleccionProd";
            this.dgvSeleccionProd.RowHeadersWidth = 10;
            this.dgvSeleccionProd.RowTemplate.Height = 28;
            this.dgvSeleccionProd.Size = new System.Drawing.Size(562, 250);
            this.dgvSeleccionProd.TabIndex = 30;
            // 
            // ID_detallepp
            // 
            this.ID_detallepp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_detallepp.HeaderText = "Número";
            this.ID_detallepp.MinimumWidth = 8;
            this.ID_detallepp.Name = "ID_detallepp";
            this.ID_detallepp.Width = 101;
            // 
            // nom_prod
            // 
            this.nom_prod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nom_prod.HeaderText = "Nombre";
            this.nom_prod.MinimumWidth = 8;
            this.nom_prod.Name = "nom_prod";
            this.nom_prod.Width = 101;
            // 
            // cantidad_p
            // 
            this.cantidad_p.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cantidad_p.HeaderText = "Cantidad";
            this.cantidad_p.MinimumWidth = 8;
            this.cantidad_p.Name = "cantidad_p";
            this.cantidad_p.Width = 109;
            // 
            // adi_p
            // 
            this.adi_p.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.adi_p.HeaderText = "Caracteristicas";
            this.adi_p.MinimumWidth = 8;
            this.adi_p.Name = "adi_p";
            this.adi_p.Width = 150;
            // 
            // precio_p
            // 
            this.precio_p.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.precio_p.HeaderText = "Precio";
            this.precio_p.MinimumWidth = 8;
            this.precio_p.Name = "precio_p";
            this.precio_p.Width = 89;
            // 
            // coBoxCateg
            // 
            this.coBoxCateg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coBoxCateg.FormattingEnabled = true;
            this.coBoxCateg.Location = new System.Drawing.Point(139, 147);
            this.coBoxCateg.Name = "coBoxCateg";
            this.coBoxCateg.Size = new System.Drawing.Size(231, 28);
            this.coBoxCateg.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 48;
            this.label1.Text = "Categoría:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 44;
            this.label4.Text = "Cantidad:";
            // 
            // lblPPID
            // 
            this.lblPPID.AutoSize = true;
            this.lblPPID.Location = new System.Drawing.Point(415, 375);
            this.lblPPID.Name = "lblPPID";
            this.lblPPID.Size = new System.Drawing.Size(148, 20);
            this.lblPPID.TabIndex = 43;
            this.lblPPID.Text = "PedidoProducto_ID";
            this.lblPPID.Visible = false;
            // 
            // txtPCarac
            // 
            this.txtPCarac.Location = new System.Drawing.Point(40, 257);
            this.txtPCarac.Multiline = true;
            this.txtPCarac.Name = "txtPCarac";
            this.txtPCarac.Size = new System.Drawing.Size(329, 61);
            this.txtPCarac.TabIndex = 40;
            this.txtPCarac.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 21);
            this.label2.TabIndex = 42;
            this.label2.Text = "Caracteristicas adicionales:";
            // 
            // txtCantP
            // 
            this.txtCantP.Location = new System.Drawing.Point(204, 333);
            this.txtCantP.Name = "txtCantP";
            this.txtCantP.Size = new System.Drawing.Size(166, 26);
            this.txtCantP.TabIndex = 51;
            this.txtCantP.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 20);
            this.label7.TabIndex = 52;
            this.label7.Text = "Número de Pedido:";
            // 
            // txtIDPed
            // 
            this.txtIDPed.Enabled = false;
            this.txtIDPed.Location = new System.Drawing.Point(204, 111);
            this.txtIDPed.Name = "txtIDPed";
            this.txtIDPed.Size = new System.Drawing.Size(166, 26);
            this.txtIDPed.TabIndex = 53;
            this.txtIDPed.UseSystemPasswordChar = true;
            this.txtIDPed.TextChanged += new System.EventHandler(this.txtIDPed_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 41;
            this.label3.Text = "Nombre:";
            // 
            // coBoxProd
            // 
            this.coBoxProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coBoxProd.FormattingEnabled = true;
            this.coBoxProd.Location = new System.Drawing.Point(138, 181);
            this.coBoxProd.Name = "coBoxProd";
            this.coBoxProd.Size = new System.Drawing.Size(231, 28);
            this.coBoxProd.TabIndex = 50;
            // 
            // SeleccionProdPed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1000, 533);
            this.Controls.Add(this.txtIDPed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCantP);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.coBoxProd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.coBoxCateg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPPID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPCarac);
            this.Controls.Add(this.dgvSeleccionProd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeleccionProdPed";
            this.Text = "SeleccionProdPed";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvSeleccionProd;
        public System.Windows.Forms.ComboBox coBoxCateg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblPPID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_detallepp;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn adi_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_p;
        public System.Windows.Forms.TextBox txtPCarac;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtCantP;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtIDPed;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox coBoxProd;
    }
}