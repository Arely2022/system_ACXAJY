using System.Data.SqlClient;

namespace system_ACXAJY
{
    public partial class ModuloMaterial : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CMX-TST-3XA7HYU\SQLEXPRESS;Initial Catalog=System_ACXAJY;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        public ModuloMaterial()
        {
            InitializeComponent();
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {

                if (MessageBox.Show("¿Guardar registro?", "Registro Guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO material(nombre_mat, desc_mat, cantidad_mat, precio_mat) VALUES(@nombre_mat, @desc_mat, @cantidad_mat, @precio_mat)", con);
                    cm.Parameters.AddWithValue("@nombre_mat", txtMName.Text);
                    cm.Parameters.AddWithValue("@desc_mat", txtMDesc.Text);
                    cm.Parameters.AddWithValue("@cantidad_mat", txtMCant.Text);
                    cm.Parameters.AddWithValue("@precio_mat", txtMPre.Text);

                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Registro Guardado Correctamente");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void clear()
        {
            txtMName.Clear();
            txtMDesc.Clear();
            txtMCant.Clear();
            txtMPre.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Actualizar registro?", "Actualizar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE material SET nombre_mat=@nombre_mat, desc_mat=@desc_mat, cantidad_mat=@cantidad_mat, precio_mat=@precio_mat WHERE ID_material LIKE '" + lblMID.Text + "'", con);
                    cm.Parameters.AddWithValue("@ID_material", lblMID.Text);
                    cm.Parameters.AddWithValue("@nombre_mat", txtMName.Text);
                    cm.Parameters.AddWithValue("@desc_mat", txtMDesc.Text);
                    cm.Parameters.AddWithValue("@cantidad_mat", txtMCant.Text);
                    cm.Parameters.AddWithValue("@precio_mat", txtMPre.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Registro Actualizado Correctamente");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
