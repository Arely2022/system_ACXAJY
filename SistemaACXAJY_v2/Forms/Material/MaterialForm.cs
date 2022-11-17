using System.Data.SqlClient;

namespace system_ACXAJY
{
    public partial class MaterialForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CMX-TST-3XA7HYU\SQLEXPRESS;Initial Catalog=System_ACXAJY;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public MaterialForm()
        {
            InitializeComponent();
            LoadMaterial();
        }

        public void LoadMaterial()
        {
            dgvMaterial.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM material", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {

                dgvMaterial.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ModuloMaterial materialmodul = new ModuloMaterial();
            materialmodul.btnSave.Enabled = true;
            materialmodul.btnUpdate.Enabled = false;
            materialmodul.ShowDialog();
            LoadMaterial();
        }

        private void dgvMaterial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvMaterial.Columns[e.ColumnIndex].Name;
            if (colName == "editar")
            {
                ModuloMaterial materialmodul = new ModuloMaterial();
                materialmodul.lblMID.Text = dgvMaterial.Rows[e.RowIndex].Cells[0].Value.ToString();
                materialmodul.txtMName.Text = dgvMaterial.Rows[e.RowIndex].Cells[1].Value.ToString();
                materialmodul.txtMDesc.Text = dgvMaterial.Rows[e.RowIndex].Cells[2].Value.ToString();
                materialmodul.txtMCant.Text = dgvMaterial.Rows[e.RowIndex].Cells[3].Value.ToString();
                materialmodul.txtMPre.Text = dgvMaterial.Rows[e.RowIndex].Cells[4].Value.ToString();

                materialmodul.btnSave.Enabled = false;
                materialmodul.btnUpdate.Enabled = true;
                materialmodul.ShowDialog();
            }
            else if (colName == "eliminar")
            {
                if (MessageBox.Show("¿Eliminar registro?", "Registro eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    cm = new SqlCommand("DELETE FROM material WHERE ID_material LIKE '" + dgvMaterial.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", con);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Registro eliminado correctamente");
                }
            }
            LoadMaterial();
        }
    }
}
