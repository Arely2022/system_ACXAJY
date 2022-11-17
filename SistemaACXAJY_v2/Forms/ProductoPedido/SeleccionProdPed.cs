using System.Data.SqlClient;

namespace system_ACXAJY
{

    public partial class SeleccionProdPed : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CMX-TST-3XA7HYU\SQLEXPRESS;Initial Catalog=System_ACXAJY;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        public SeleccionProdPed()
        {
            InitializeComponent();
            LoadCategoria();
            LoadProducto();


        }
        public void LoadSeleccionProd()
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
        public void LoadCategoria()
        {
            coBoxCateg.Items.Clear();
            cm = new SqlCommand("SELECT nombre_categ FROM categoria", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                coBoxCateg.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }
        public void LoadProducto()
        {
            coBoxCateg.Items.Clear();
            cm = new SqlCommand("SELECT nombre_prod FROM producto WHERE ", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                coBoxCateg.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtIDPed_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
