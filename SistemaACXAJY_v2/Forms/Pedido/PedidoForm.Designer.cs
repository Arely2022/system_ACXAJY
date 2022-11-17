
namespace system_ACXAJY
{
    partial class PedidoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidoForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.ID_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.total_ped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_ped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dir_ped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(117)))), ((int)(((byte)(157)))));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 441);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 87);
            this.panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.textBox1.Location = new System.Drawing.Point(488, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 29);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(412, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Buscar:";
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(744, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(42, 37);
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
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "PEDIDOS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(824, 441);
            this.dataGridView1.TabIndex = 2;
            // 
            // dgvPedido
            // 
            this.dgvPedido.AllowUserToAddRows = false;
            this.dgvPedido.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(117)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(117)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedido.ColumnHeadersHeight = 30;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_pedido,
            this.nombrecliente,
            this.completado,
            this.total_ped,
            this.fecha_ped,
            this.dir_ped,
            this.editar,
            this.eliminar});
            this.dgvPedido.EnableHeadersVisualStyles = false;
            this.dgvPedido.GridColor = System.Drawing.SystemColors.Control;
            this.dgvPedido.Location = new System.Drawing.Point(0, 0);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.RowHeadersWidth = 62;
            this.dgvPedido.RowTemplate.Height = 28;
            this.dgvPedido.Size = new System.Drawing.Size(824, 441);
            this.dgvPedido.TabIndex = 3;
            this.dgvPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedido_CellContentClick);
            // 
            // ID_pedido
            // 
            this.ID_pedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_pedido.HeaderText = "Número";
            this.ID_pedido.MinimumWidth = 8;
            this.ID_pedido.Name = "ID_pedido";
            this.ID_pedido.ReadOnly = true;
            this.ID_pedido.Width = 104;
            // 
            // nombrecliente
            // 
            this.nombrecliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombrecliente.HeaderText = "Nombre";
            this.nombrecliente.MinimumWidth = 8;
            this.nombrecliente.Name = "nombrecliente";
            this.nombrecliente.ReadOnly = true;
            this.nombrecliente.Width = 104;
            // 
            // completado
            // 
            this.completado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.completado.HeaderText = "Completado";
            this.completado.MinimumWidth = 8;
            this.completado.Name = "completado";
            this.completado.ReadOnly = true;
            this.completado.Width = 101;
            // 
            // total_ped
            // 
            this.total_ped.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.total_ped.HeaderText = "Total";
            this.total_ped.MinimumWidth = 8;
            this.total_ped.Name = "total_ped";
            this.total_ped.ReadOnly = true;
            this.total_ped.Width = 80;
            // 
            // fecha_ped
            // 
            this.fecha_ped.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fecha_ped.HeaderText = "Fecha";
            this.fecha_ped.MinimumWidth = 8;
            this.fecha_ped.Name = "fecha_ped";
            this.fecha_ped.ReadOnly = true;
            this.fecha_ped.Width = 86;
            // 
            // dir_ped
            // 
            this.dir_ped.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dir_ped.HeaderText = "Dirección";
            this.dir_ped.MinimumWidth = 8;
            this.dir_ped.Name = "dir_ped";
            this.dir_ped.ReadOnly = true;
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
            // PedidoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 528);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PedidoForm";
            this.Text = "PedidoForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private DataGridViewTextBoxColumn ID_pedido;
        private DataGridViewTextBoxColumn nombrecliente;
        private DataGridViewCheckBoxColumn completado;
        private DataGridViewTextBoxColumn total_ped;
        private DataGridViewTextBoxColumn fecha_ped;
        private DataGridViewTextBoxColumn dir_ped;
        private DataGridViewImageColumn editar;
        private DataGridViewImageColumn eliminar;
    }
}