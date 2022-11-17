
namespace system_ACXAJY
{
    partial class SeleccionProdMat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionProdMat));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.coBoxMaterial = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvProdMat = new System.Windows.Forms.DataGridView();
            this.ID_detallepm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_mat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_mat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_mat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCostoProduccion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCostoUnitario = new System.Windows.Forms.Label();
            this.txtCostoTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecioProd = new System.Windows.Forms.TextBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.lblPMID = new System.Windows.Forms.Label();
            this.lblPID = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdMat)).BeginInit();
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
            this.panel2.Size = new System.Drawing.Size(913, 56);
            this.panel2.TabIndex = 28;
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.Image")));
            this.pictureBoxExit.Location = new System.Drawing.Point(833, 12);
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
            this.panel1.Location = new System.Drawing.Point(0, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 78);
            this.panel1.TabIndex = 27;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(117)))), ((int)(((byte)(157)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.btnAdd.Location = new System.Drawing.Point(272, 328);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 34);
            this.btnAdd.TabIndex = 54;
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
            this.btnUpdate.Location = new System.Drawing.Point(151, 328);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 34);
            this.btnUpdate.TabIndex = 53;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(117)))), ((int)(((byte)(157)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.btnClear.Location = new System.Drawing.Point(51, 328);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 34);
            this.btnClear.TabIndex = 52;
            this.btnClear.Text = "Vaciar";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // coBoxMaterial
            // 
            this.coBoxMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coBoxMaterial.FormattingEnabled = true;
            this.coBoxMaterial.Location = new System.Drawing.Point(139, 135);
            this.coBoxMaterial.Name = "coBoxMaterial";
            this.coBoxMaterial.Size = new System.Drawing.Size(231, 28);
            this.coBoxMaterial.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 60;
            this.label1.Text = "Material:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 56;
            this.label3.Text = "Cantidad:";
            // 
            // dgvProdMat
            // 
            this.dgvProdMat.AllowUserToAddRows = false;
            this.dgvProdMat.AllowUserToDeleteRows = false;
            this.dgvProdMat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.dgvProdMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdMat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_detallepm,
            this.nom_mat,
            this.cantidad_mat,
            this.precio_mat});
            this.dgvProdMat.Location = new System.Drawing.Point(410, 112);
            this.dgvProdMat.Name = "dgvProdMat";
            this.dgvProdMat.RowHeadersWidth = 10;
            this.dgvProdMat.RowTemplate.Height = 28;
            this.dgvProdMat.Size = new System.Drawing.Size(467, 250);
            this.dgvProdMat.TabIndex = 64;
            // 
            // ID_detallepm
            // 
            this.ID_detallepm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_detallepm.HeaderText = "Número";
            this.ID_detallepm.MinimumWidth = 8;
            this.ID_detallepm.Name = "ID_detallepm";
            this.ID_detallepm.Width = 101;
            // 
            // nom_mat
            // 
            this.nom_mat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nom_mat.HeaderText = "Nombre";
            this.nom_mat.MinimumWidth = 8;
            this.nom_mat.Name = "nom_mat";
            // 
            // cantidad_mat
            // 
            this.cantidad_mat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cantidad_mat.HeaderText = "Cantidad";
            this.cantidad_mat.MinimumWidth = 8;
            this.cantidad_mat.Name = "cantidad_mat";
            this.cantidad_mat.Width = 109;
            // 
            // precio_mat
            // 
            this.precio_mat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.precio_mat.HeaderText = "Precio";
            this.precio_mat.MinimumWidth = 8;
            this.precio_mat.Name = "precio_mat";
            this.precio_mat.Width = 89;
            // 
            // txtCostoProduccion
            // 
            this.txtCostoProduccion.Location = new System.Drawing.Point(270, 249);
            this.txtCostoProduccion.Name = "txtCostoProduccion";
            this.txtCostoProduccion.Size = new System.Drawing.Size(94, 26);
            this.txtCostoProduccion.TabIndex = 68;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(272, 215);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(94, 26);
            this.txtPrecio.TabIndex = 67;
            // 
            // txtCostoUnitario
            // 
            this.txtCostoUnitario.AutoSize = true;
            this.txtCostoUnitario.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoUnitario.Location = new System.Drawing.Point(115, 217);
            this.txtCostoUnitario.Name = "txtCostoUnitario";
            this.txtCostoUnitario.Size = new System.Drawing.Size(135, 21);
            this.txtCostoUnitario.TabIndex = 66;
            this.txtCostoUnitario.Text = "Costo de Material:";
            // 
            // txtCostoTotal
            // 
            this.txtCostoTotal.AutoSize = true;
            this.txtCostoTotal.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoTotal.Location = new System.Drawing.Point(156, 251);
            this.txtCostoTotal.Name = "txtCostoTotal";
            this.txtCostoTotal.Size = new System.Drawing.Size(88, 21);
            this.txtCostoTotal.TabIndex = 65;
            this.txtCostoTotal.Text = "Costo total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 21);
            this.label2.TabIndex = 69;
            this.label2.Text = "Precio producto:";
            // 
            // txtPrecioProd
            // 
            this.txtPrecioProd.Location = new System.Drawing.Point(270, 284);
            this.txtPrecioProd.Name = "txtPrecioProd";
            this.txtPrecioProd.Size = new System.Drawing.Size(94, 26);
            this.txtPrecioProd.TabIndex = 70;
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(272, 178);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(94, 26);
            this.txtCant.TabIndex = 72;
            // 
            // lblPMID
            // 
            this.lblPMID.AutoSize = true;
            this.lblPMID.Location = new System.Drawing.Point(787, 79);
            this.lblPMID.Name = "lblPMID";
            this.lblPMID.Size = new System.Drawing.Size(94, 20);
            this.lblPMID.TabIndex = 73;
            this.lblPMID.Text = "ID_prodmat";
            this.lblPMID.Visible = false;
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Location = new System.Drawing.Point(276, 100);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(68, 20);
            this.lblPID.TabIndex = 74;
            this.lblPID.Text = "ID_Prod";
            this.lblPID.Visible = false;
            // 
            // SeleccionProdMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(913, 478);
            this.Controls.Add(this.lblPID);
            this.Controls.Add(this.lblPMID);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.txtPrecioProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCostoProduccion);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCostoUnitario);
            this.Controls.Add(this.txtCostoTotal);
            this.Controls.Add(this.dgvProdMat);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.coBoxMaterial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeleccionProdMat";
            this.Text = "SeleccionProdMat";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdMat)).EndInit();
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
        public System.Windows.Forms.ComboBox coBoxMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvProdMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_detallepm;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_mat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_mat;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_mat;
        public System.Windows.Forms.TextBox txtCostoProduccion;
        public System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label txtCostoUnitario;
        private System.Windows.Forms.Label txtCostoTotal;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtPrecioProd;
        public System.Windows.Forms.TextBox txtCant;
        public System.Windows.Forms.Label lblPMID;
        public System.Windows.Forms.Label lblPID;
    }
}