
namespace system_ACXAJY
{
    partial class Categorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categorias));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.ID_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_categ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_categ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(117)))), ((int)(((byte)(157)))));
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 445);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 83);
            this.panel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(748, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(42, 35);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 1;
            this.btnAdd.TabStop = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(560, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "CATEGORIAS";
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.dgvCategorias.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvCategorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(117)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(117)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategorias.ColumnHeadersHeight = 30;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_categoria,
            this.nom_categ,
            this.desc_categ,
            this.editar,
            this.eliminar});
            this.dgvCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategorias.EnableHeadersVisualStyles = false;
            this.dgvCategorias.GridColor = System.Drawing.SystemColors.Control;
            this.dgvCategorias.Location = new System.Drawing.Point(0, 0);
            this.dgvCategorias.Name = "dgvCategorias";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(117)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategorias.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategorias.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.dgvCategorias.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCategorias.RowTemplate.Height = 28;
            this.dgvCategorias.Size = new System.Drawing.Size(824, 528);
            this.dgvCategorias.TabIndex = 1;
            this.dgvCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellContentClick);
            // 
            // ID_categoria
            // 
            this.ID_categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_categoria.HeaderText = "Número";
            this.ID_categoria.MinimumWidth = 8;
            this.ID_categoria.Name = "ID_categoria";
            this.ID_categoria.Width = 103;
            // 
            // nom_categ
            // 
            this.nom_categ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nom_categ.HeaderText = "Nombre";
            this.nom_categ.MinimumWidth = 8;
            this.nom_categ.Name = "nom_categ";
            // 
            // desc_categ
            // 
            this.desc_categ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.desc_categ.HeaderText = "Descripción";
            this.desc_categ.MinimumWidth = 8;
            this.desc_categ.Name = "desc_categ";
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
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 150;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 8;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 150;
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(824, 528);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCategorias);
            this.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Categorias";
            this.Text = "Categorias";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.PictureBox btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_categ;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_categ;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.DataGridViewImageColumn eliminar;
    }
}