
namespace system_ACXAJY
{
    partial class VentasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentasForm));
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ID_detallevp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_ven = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVenta
            // 
            this.dgvVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_detallevp,
            this.total_ven,
            this.fecha,
            this.editar,
            this.eliminar});
            this.dgvVenta.Location = new System.Drawing.Point(13, 48);
            this.dgvVenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.RowHeadersWidth = 62;
            this.dgvVenta.RowTemplate.Height = 28;
            this.dgvVenta.Size = new System.Drawing.Size(636, 246);
            this.dgvVenta.TabIndex = 0;
            this.dgvVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenta_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(117)))), ((int)(((byte)(157)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 435);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 80);
            this.panel1.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(358, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ventas";
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(531, 21);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(47, 44);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 2;
            this.btnAdd.TabStop = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(168, 368);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(104, 31);
            this.textBox2.TabIndex = 37;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 319);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 31);
            this.textBox1.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(19, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 21);
            this.label7.TabIndex = 35;
            this.label7.Text = "Total de Ventas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 34;
            this.label1.Text = "Total ingresos:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Window;
            this.textBox3.Location = new System.Drawing.Point(462, 319);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(174, 31);
            this.textBox3.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(378, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 38;
            this.label2.Text = "Buscar:";
            // 
            // ID_detallevp
            // 
            this.ID_detallevp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_detallevp.HeaderText = "Número";
            this.ID_detallevp.MinimumWidth = 8;
            this.ID_detallevp.Name = "ID_detallevp";
            this.ID_detallevp.Width = 113;
            // 
            // total_ven
            // 
            this.total_ven.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.total_ven.HeaderText = "Total";
            this.total_ven.MinimumWidth = 8;
            this.total_ven.Name = "total_ven";
            this.total_ven.Width = 85;
            // 
            // fecha
            // 
            this.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fecha.HeaderText = "Fecha";
            this.fecha.MinimumWidth = 8;
            this.fecha.Name = "fecha";
            // 
            // editar
            // 
            this.editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.editar.HeaderText = "";
            this.editar.Image = ((System.Drawing.Image)(resources.GetObject("editar.Image")));
            this.editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.editar.MinimumWidth = 8;
            this.editar.Name = "editar";
            this.editar.Width = 27;
            // 
            // eliminar
            // 
            this.eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.eliminar.HeaderText = "";
            this.eliminar.Image = ((System.Drawing.Image)(resources.GetObject("eliminar.Image")));
            this.eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.eliminar.MinimumWidth = 8;
            this.eliminar.Name = "eliminar";
            this.eliminar.Width = 27;
            // 
            // VentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(662, 515);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "VentasForm";
            this.Text = "VentasForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVenta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnAdd;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private DataGridViewTextBoxColumn ID_detallevp;
        private DataGridViewTextBoxColumn total_ven;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewImageColumn editar;
        private DataGridViewImageColumn eliminar;
    }
}