using SistemaACXAJY_v2.Entities;
using System.Data.SqlClient;
using system_ACXAJY.Entities;

namespace system_ACXAJY
{
    public partial class MainForm : Form
    {
        private readonly SqlConnection con = new(@"Data Source=CMX-TST-3XA7HYU\SQLEXPRESS;Initial Catalog=System_ACXAJY;Integrated Security=True");
        private readonly List<Compra> _listaCompra = new();
        private readonly List<Venta> _listaVenta = new();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        public MainForm()
        {
            InitializeComponent();
            Loadganancia();
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
            panelBase.Tag = childForm;
            childForm.Show();
        }

        public void Loadganancia()
        {
            con.Open();

            double ganancias = 0;
            double totalcompras = 0;
            double totalventas = 0;

            cm = new("SELECT total_compra FROM compra", con);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                totalcompras += Convert.ToDouble(dr[0]);
            }
            dr.Close();

            cm = new("SELECT total_venta FROM venta", con);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                totalventas += Convert.ToDouble(dr[0]);
            }
            dr.Close();
            ganancias = totalventas - totalcompras;
            txtGanancias.Text = Convert.ToString(ganancias);
            con.Close();

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

        private void btnCompras_Click(object sender, EventArgs e)
        {
            openChildForm(new ComprasForm());
        }

        private void btnGanacias_Click(object sender, EventArgs e)
        {
            Loadganancia();
        }
    }
}
