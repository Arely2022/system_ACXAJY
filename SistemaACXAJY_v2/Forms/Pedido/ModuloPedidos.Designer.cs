
namespace system_ACXAJY
{
    partial class ModuloPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuloPedidos));
            this.label6 = new System.Windows.Forms.Label();
            this.lblOID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCliName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvSeleccionProd = new System.Windows.Forms.DataGridView();
            this.ID_detallepp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adi_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.dTimeEntrega = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtCantP = new System.Windows.Forms.TextBox();
            this.coBoxProd = new System.Windows.Forms.ComboBox();
            this.coBoxCateg = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPCarac = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cBEstado = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionProd)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(117)))), ((int)(((byte)(157)))));
            this.label6.Location = new System.Drawing.Point(35, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "Ingrese información de pedido:";
            // 
            // lblOID
            // 
            this.lblOID.AutoSize = true;
            this.lblOID.Location = new System.Drawing.Point(33, 519);
            this.lblOID.Name = "lblOID";
            this.lblOID.Size = new System.Drawing.Size(80, 21);
            this.lblOID.TabIndex = 25;
            this.lblOID.Text = "Pedido_ID";
            this.lblOID.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(117)))), ((int)(((byte)(157)))));
            this.panel2.Controls.Add(this.pictureBoxExit);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1159, 59);
            this.panel2.TabIndex = 24;
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.Image")));
            this.pictureBoxExit.Location = new System.Drawing.Point(1094, 9);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(44, 39);
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
            this.label5.Location = new System.Drawing.Point(33, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "PEDIDO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(204, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(46, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nombre asociado con pedido:";
            // 
            // txtCliName
            // 
            this.txtCliName.Location = new System.Drawing.Point(281, 325);
            this.txtCliName.Name = "txtCliName";
            this.txtCliName.Size = new System.Drawing.Size(265, 29);
            this.txtCliName.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(117)))), ((int)(((byte)(157)))));
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 561);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1159, 74);
            this.panel1.TabIndex = 19;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(1025, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 36);
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
            this.btnUpdate.Location = new System.Drawing.Point(904, 21);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 36);
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
            this.btnClear.Location = new System.Drawing.Point(804, 21);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 36);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Vaciar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(160, 519);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "Total a pagar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(33, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 21);
            this.label4.TabIndex = 30;
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
            this.adi_p,
            this.precio_p,
            this.eliminar});
            this.dgvSeleccionProd.Location = new System.Drawing.Point(37, 109);
            this.dgvSeleccionProd.Name = "dgvSeleccionProd";
            this.dgvSeleccionProd.RowHeadersWidth = 10;
            this.dgvSeleccionProd.RowTemplate.Height = 28;
            this.dgvSeleccionProd.Size = new System.Drawing.Size(1099, 171);
            this.dgvSeleccionProd.TabIndex = 29;
            this.dgvSeleccionProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSeleccionProd_CellContentClick);
            // 
            // ID_detallepp
            // 
            this.ID_detallepp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_detallepp.HeaderText = "Número";
            this.ID_detallepp.MinimumWidth = 8;
            this.ID_detallepp.Name = "ID_detallepp";
            this.ID_detallepp.Width = 104;
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
            this.cantidad_p.Width = 108;
            // 
            // adi_p
            // 
            this.adi_p.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adi_p.HeaderText = "Caracteristicas";
            this.adi_p.MinimumWidth = 8;
            this.adi_p.Name = "adi_p";
            // 
            // precio_p
            // 
            this.precio_p.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.precio_p.HeaderText = "Precio";
            this.precio_p.MinimumWidth = 8;
            this.precio_p.Name = "precio_p";
            this.precio_p.Width = 89;
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
            // txtTotalPagar
            // 
            this.txtTotalPagar.Enabled = false;
            this.txtTotalPagar.Location = new System.Drawing.Point(300, 516);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(94, 29);
            this.txtTotalPagar.TabIndex = 33;
            this.txtTotalPagar.Text = "0";
            // 
            // dTimeEntrega
            // 
            this.dTimeEntrega.Location = new System.Drawing.Point(281, 412);
            this.dTimeEntrega.Name = "dTimeEntrega";
            this.dTimeEntrega.Size = new System.Drawing.Size(265, 29);
            this.dTimeEntrega.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(132, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 21);
            this.label8.TabIndex = 35;
            this.label8.Text = "Fecha de entrega:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(107, 453);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 21);
            this.label9.TabIndex = 36;
            this.label9.Text = "Dirección de entrega:";
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(281, 453);
            this.txtDir.Multiline = true;
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(265, 52);
            this.txtDir.TabIndex = 37;
            // 
            // txtCantP
            // 
            this.txtCantP.Location = new System.Drawing.Point(793, 480);
            this.txtCantP.Name = "txtCantP";
            this.txtCantP.Size = new System.Drawing.Size(166, 29);
            this.txtCantP.TabIndex = 61;
            // 
            // coBoxProd
            // 
            this.coBoxProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coBoxProd.FormattingEnabled = true;
            this.coBoxProd.Location = new System.Drawing.Point(793, 383);
            this.coBoxProd.Name = "coBoxProd";
            this.coBoxProd.Size = new System.Drawing.Size(231, 29);
            this.coBoxProd.TabIndex = 60;
            // 
            // coBoxCateg
            // 
            this.coBoxCateg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coBoxCateg.FormattingEnabled = true;
            this.coBoxCateg.Location = new System.Drawing.Point(793, 348);
            this.coBoxCateg.Name = "coBoxCateg";
            this.coBoxCateg.Size = new System.Drawing.Size(231, 29);
            this.coBoxCateg.TabIndex = 59;
            this.coBoxCateg.SelectedIndexChanged += new System.EventHandler(this.coBoxCateg_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(698, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 21);
            this.label11.TabIndex = 58;
            this.label11.Text = "Categoría:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(698, 488);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 21);
            this.label12.TabIndex = 57;
            this.label12.Text = "Cantidad:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(583, 428);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(194, 21);
            this.label13.TabIndex = 56;
            this.label13.Text = "Caracteristicas adicionales:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(706, 383);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 21);
            this.label14.TabIndex = 55;
            this.label14.Text = "Nombre:";
            // 
            // txtPCarac
            // 
            this.txtPCarac.Location = new System.Drawing.Point(794, 425);
            this.txtPCarac.Multiline = true;
            this.txtPCarac.Name = "txtPCarac";
            this.txtPCarac.Size = new System.Drawing.Size(329, 49);
            this.txtPCarac.TabIndex = 54;
            this.txtPCarac.UseSystemPasswordChar = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(117)))), ((int)(((byte)(157)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.btnAdd.Location = new System.Drawing.Point(993, 480);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 71);
            this.btnAdd.TabIndex = 62;
            this.btnAdd.Text = "Agregar Producto";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(583, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 21);
            this.label7.TabIndex = 63;
            this.label7.Text = "Ingrese información de productos:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(277, 519);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 21);
            this.label10.TabIndex = 64;
            this.label10.Text = "$";
            // 
            // cBEstado
            // 
            this.cBEstado.AutoSize = true;
            this.cBEstado.Location = new System.Drawing.Point(281, 370);
            this.cBEstado.Name = "cBEstado";
            this.cBEstado.Size = new System.Drawing.Size(121, 25);
            this.cBEstado.TabIndex = 65;
            this.cBEstado.Text = "Completado";
            this.cBEstado.UseVisualStyleBackColor = true;
            // 
            // ModuloPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1159, 635);
            this.Controls.Add(this.cBEstado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCantP);
            this.Controls.Add(this.coBoxProd);
            this.Controls.Add(this.coBoxCateg);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtPCarac);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dTimeEntrega);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvSeleccionProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblOID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCliName);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModuloPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModuloPedidos";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lblOID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtCliName;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvSeleccionProd;
        public System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtDir;
        public System.Windows.Forms.DateTimePicker dTimeEntrega;
        public System.Windows.Forms.TextBox txtCantP;
        public System.Windows.Forms.ComboBox coBoxProd;
        public System.Windows.Forms.ComboBox coBoxCateg;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtPCarac;
        public System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_detallepp;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn adi_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_p;
        private System.Windows.Forms.DataGridViewImageColumn eliminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.CheckBox cBEstado;
    }
}