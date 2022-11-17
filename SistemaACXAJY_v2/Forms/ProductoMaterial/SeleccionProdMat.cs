using System.Data.SqlClient;
using system_ACXAJY.Entities;

namespace system_ACXAJY
{
    public partial class SeleccionProdMat : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CMX-TST-3XA7HYU\SQLEXPRESS;Initial Catalog=System_ACXAJY;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public SeleccionProdMat()
        {
            InitializeComponent();
            LoadProdMat();
        }

        public void LoadProdMat()
        {
            dgvProdMat.Rows.Clear();
            cm = new SqlCommand("SELECT ID_detallemp, nombre_mat, cantidad_mat, precio_mat " +
                "FROM material_producto INNER JOIN material ON ID_material_mp=ID_material", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {

                dgvProdMat.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("¿Guardar registro?", "Registro Guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO producto(ID_material_mp, ID_producto_mp, cantmat_mp, preciomat_mp)" +
                        "VALUES(@ID_material_mp, @ID_producto_mp, @cantmat_mp, @preciomat_mp)", con);
                    Material nombrematerial = coBoxMaterial.SelectedItem as Material;
                    cm.Parameters.AddWithValue("@ID_material_mp", nombrematerial.Idmaterial);
                    Producto Idproducto = new Producto();
                    cm.Parameters.AddWithValue("@ID_producto_mp", Idproducto.IdProducto);
                    cm.Parameters.AddWithValue("@cantmat_mp", Convert.ToInt16(txtCant.Text));
                    cm.Parameters.AddWithValue("@preciomat_mp", Convert.ToInt16(txtCostoUnitario.Text));


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
        public void LoadMaterial()
        {
            coBoxMaterial.Items.Clear();
            coBoxMaterial.DisplayMember = "NombreMaterial";
            cm = new SqlCommand("SELECT ID_material, nombre_mat FROM material", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                Material material = new Material();
                material.Idmaterial = Convert.ToInt32(dr[0].ToString());
                material.NombreMaterial = dr[1].ToString();
                coBoxMaterial.Items.Add(material);

            }
            dr.Close();
            con.Close();

        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
