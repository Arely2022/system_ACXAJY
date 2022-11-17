
namespace system_ACXAJY
{
    partial class ComprasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComprasForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_detallecp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant_mat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_comp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(117)))), ((int)(((byte)(157)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 356);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 64);
            this.panel1.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(441, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Compras";
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(553, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(42, 35);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 2;
            this.btnAdd.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_detallecp,
            this.ID_material,
            this.cant_mat,
            this.total_comp,
            this.fecha});
            this.dataGridView1.Location = new System.Drawing.Point(39, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(556, 197);
            this.dataGridView1.TabIndex = 8;
            // 
            // ID_detallecp
            // 
            this.ID_detallecp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_detallecp.HeaderText = "Número";
            this.ID_detallecp.MinimumWidth = 8;
            this.ID_detallecp.Name = "ID_detallecp";
            this.ID_detallecp.Width = 101;
            // 
            // ID_material
            // 
            this.ID_material.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID_material.HeaderText = "Material";
            this.ID_material.MinimumWidth = 8;
            this.ID_material.Name = "ID_material";
            // 
            // cant_mat
            // 
            this.cant_mat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cant_mat.HeaderText = "Cantidad";
            this.cant_mat.MinimumWidth = 8;
            this.cant_mat.Name = "cant_mat";
            this.cant_mat.Width = 109;
            // 
            // total_comp
            // 
            this.total_comp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.total_comp.HeaderText = "Total";
            this.total_comp.MinimumWidth = 8;
            this.total_comp.Name = "total_comp";
            this.total_comp.Width = 80;
            // 
            // fecha
            // 
            this.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fecha.HeaderText = "Fecha";
            this.fecha.MinimumWidth = 8;
            this.fecha.Name = "fecha";
            this.fecha.Width = 90;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Window;
            this.textBox3.Location = new System.Drawing.Point(407, 261);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(188, 26);
            this.textBox3.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 44;
            this.label2.Text = "Buscar:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(198, 297);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(94, 26);
            this.textBox2.TabIndex = 43;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 258);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 26);
            this.textBox1.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 21);
            this.label7.TabIndex = 41;
            this.label7.Text = "Total de Compras:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "Total egresos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(331, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 47;
            this.label3.Text = "Mostrar:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "General",
            "Mensuales",
            "Anuales"});
            this.comboBox1.Location = new System.Drawing.Point(407, 299);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 28);
            this.comboBox1.TabIndex = 46;
            // 
            // ComprasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(638, 420);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComprasForm";
            this.Text = "ComprasForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_detallecp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_material;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant_mat;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_comp;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}