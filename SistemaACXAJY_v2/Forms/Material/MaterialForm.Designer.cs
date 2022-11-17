
namespace system_ACXAJY
{
    partial class MaterialForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMaterial = new System.Windows.Forms.DataGridView();
            this.ID_material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant_mat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(117)))), ((int)(((byte)(157)))));
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 424);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 104);
            this.panel1.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(737, 28);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(47, 44);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 1;
            this.btnAdd.TabStop = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(585, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "MATERIAL";
            // 
            // dgvMaterial
            // 
            this.dgvMaterial.AllowUserToAddRows = false;
            this.dgvMaterial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.dgvMaterial.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvMaterial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(117)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(117)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaterial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMaterial.ColumnHeadersHeight = 30;
            this.dgvMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_material,
            this.nom_material,
            this.desc_material,
            this.cant_mat,
            this.Precio_material,
            this.editar,
            this.eliminar});
            this.dgvMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaterial.EnableHeadersVisualStyles = false;
            this.dgvMaterial.GridColor = System.Drawing.SystemColors.Control;
            this.dgvMaterial.Location = new System.Drawing.Point(0, 0);
            this.dgvMaterial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMaterial.Name = "dgvMaterial";
            this.dgvMaterial.RowHeadersWidth = 62;
            this.dgvMaterial.RowTemplate.Height = 28;
            this.dgvMaterial.Size = new System.Drawing.Size(824, 424);
            this.dgvMaterial.TabIndex = 2;
            this.dgvMaterial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterial_CellContentClick);
            // 
            // ID_material
            // 
            this.ID_material.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_material.HeaderText = "Número";
            this.ID_material.MinimumWidth = 8;
            this.ID_material.Name = "ID_material";
            this.ID_material.Width = 108;
            // 
            // nom_material
            // 
            this.nom_material.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nom_material.HeaderText = "Nombre";
            this.nom_material.MinimumWidth = 8;
            this.nom_material.Name = "nom_material";
            // 
            // desc_material
            // 
            this.desc_material.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.desc_material.HeaderText = "Descripción";
            this.desc_material.MinimumWidth = 8;
            this.desc_material.Name = "desc_material";
            // 
            // cant_mat
            // 
            this.cant_mat.HeaderText = "Cantidad";
            this.cant_mat.MinimumWidth = 8;
            this.cant_mat.Name = "cant_mat";
            this.cant_mat.Width = 150;
            // 
            // Precio_material
            // 
            this.Precio_material.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Precio_material.HeaderText = "Precio";
            this.Precio_material.MinimumWidth = 8;
            this.Precio_material.Name = "Precio_material";
            this.Precio_material.Width = 93;
            // 
            // editar
            // 
            this.editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.editar.HeaderText = "";
            this.editar.Image = ((System.Drawing.Image)(resources.GetObject("editar.Image")));
            this.editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.editar.MinimumWidth = 8;
            this.editar.Name = "editar";
            this.editar.Width = 8;
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
            // MaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 528);
            this.Controls.Add(this.dgvMaterial);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MaterialForm";
            this.Text = "MaterialForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_material;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_material;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_material;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant_mat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_material;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.DataGridViewImageColumn eliminar;
    }
}