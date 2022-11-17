using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace system_ACXAJY
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Right;
            panelBase.Controls.Add(childForm);
            panelBase.Tag= childForm;
            childForm.Show();
        }

  

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            openChildForm(new UserForm());
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            openChildForm(new Categorias());
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            openChildForm(new MaterialForm());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            openChildForm(new ProductForm());
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            openChildForm(new PedidoForm());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            openChildForm(new VentasForm());
        }
    }
}
