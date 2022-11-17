using System.Data.SqlClient;

namespace system_ACXAJY
{
    public partial class ComprasForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CMX-TST-3XA7HYU\SQLEXPRESS;Initial Catalog=System_ACXAJY;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public ComprasForm()
        {
            InitializeComponent();
            LoadCompra();
        }

        public void LoadCompra()
        {
            cm = new SqlCommand("SELECT * FROM compra", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {

                dgvcompras.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ModuloCompras moduloCompras = new ModuloCompras();
            moduloCompras.btnSave.Enabled = true;
            moduloCompras.btnUpdate.Enabled = false;
            moduloCompras.ShowDialog();
            LoadCompra();
        }
    }
}
