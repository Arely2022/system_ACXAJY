using SistemaACXAJY_v2.Entities;
using System.Data;
using System.Data.SqlClient;
using system_ACXAJY.Entities;
using system_ACXAJY.Queries;

namespace system_ACXAJY
{
    public partial class ModuloCompras : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CMX-TST-3XA7HYU\SQLEXPRESS;Initial Catalog=System_ACXAJY;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        List<Material> ListaMaterial = new List<Material>();
        List<CompraMaterial> ListaCompraMaterialActual = new List<CompraMaterial>();
        List<CompraMaterial> ListaCompraMaterialOriginal = new List<CompraMaterial>();
        public Compra compra = null;
        public ModuloCompras()
        {
            InitializeComponent();
            LoadMaterial();
        }
        public void clear()
        {
            dTimeCompra.Value = DateTime.Now;
        }
        public void LoadMaterial()
        {
            coBoxMat.Items.Clear();
            coBoxMat.DisplayMember = "NombreMaterial";

            cm = new SqlCommand("SELECT ID_material, nombre_mat FROM material", con);
            try
            {
                con.Open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    Material material = new Material();
                    material.Idmaterial = Convert.ToInt32(dr[0].ToString());
                    material.NombreMaterial = dr[1].ToString();
                    coBoxMat.Items.Add(material);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                dr.Close();
            }
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void LoadCompraMaterial(int idcompra)
        {
            con.Open();

            List<CompraMaterial> compraMaterials = CompraMaterialQueries.ConsultarPorCompra(con, idcompra);
            foreach (CompraMaterial compraMaterial in compraMaterials)
            {
                Material material = ListaMaterial
                    .Where(p => p.Idmaterial == compraMaterial.idmaterialcm)
                    .FirstOrDefault()!;

                float preciomaterial = (float)material.PrecioMaterial;
                string nombrematerial = material.NombreMaterial;

                ListaCompraMaterialActual.Add(compraMaterial);
                ListaCompraMaterialOriginal.Add(compraMaterial);

                dgvSeleccionMat.Rows.Add(0, nombrematerial, compraMaterial.cantmaterialcm, preciomaterial);
            }

            con.Close();

        }
        public void LoadCompra()
        {
            if (compra == null)
            {
                return;
            }

            // 1. Cargar información del pedido en el formulario
            lblCID.Text = compra.Idcompra.ToString();
            txtTotalPagar.Text = compra.totalcompra.ToString();
            dTimeCompra.Text = compra.FechaCompra.ToString();



            // 2. Consultar los productos del pedido
            LoadCompraMaterial(compra.Idcompra);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CompraMaterial compraMaterial = new CompraMaterial();
            Material SelectedMat = coBoxMat.SelectedItem as Material;
            compraMaterial.idmaterialcm = SelectedMat.Idmaterial;
            compraMaterial.cantmaterialcm = Convert.ToInt32(txtCantMat.Text);

            ListaCompraMaterialActual.Add(compraMaterial);
            dgvSeleccionMat.Rows.Add(0, SelectedMat.NombreMaterial, compraMaterial.cantmaterialcm, SelectedMat.PrecioMaterial);

            double total = (Convert.ToDouble(SelectedMat.PrecioMaterial) * Convert.ToDouble(txtCantMat.Text));
            txtTotalPagar.Text = total.ToString();

            coBoxMat.SelectedIndex = -1;
            coBoxMat.Items.Clear();
            txtCantMat.Clear();
        }
        public void MaterialSeleccionado()
        {
            dgvSeleccionMat.Rows.Clear();
            cm = new SqlCommand(@"
                SELECT ID_detallecm, nombre_mat, cantmaterial_cm, precio_mat
                FROM compra_material
                INNER JOIN material ON ID_material_cm = ID_material", con);

            try
            {
                con.Open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {

                    dgvSeleccionMat.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Close();
                con.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Guardar registro?", "Registro Guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                // 1. Guardar la compra
                cm = new SqlCommand(@"
                    INSERT INTO compra(total_compra, fecha_compra)
                    VALUES(@total_compra, @fecha_compra);
                    SELECT SCOPE_IDENTITY();", con, transaction);
                cm.Parameters.AddWithValue("@total_compra", Convert.ToInt32(txtTotalPagar.Text));
                cm.Parameters.AddWithValue("@fecha_compra", dTimeCompra.Value);

                // 2. Obtener el ID del pedido
                int idcompra = 0;
                try
                {
                    object returnObj = cm.ExecuteScalar();
                    if (returnObj != null)
                    {
                        int.TryParse(returnObj.ToString(), out idcompra);
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    con.Close();
                    MessageBox.Show(ex.Message);
                    return;
                }

                // 3. Agregar los productos a la tabla pedido_producto
                bool agregados = CompraMaterialQueries.AgregarMaterial(
                    idcompra,
                    ListaCompraMaterialActual,
                    con,
                    transaction);

                if (agregados == false)
                {
                    transaction.Rollback();
                    con.Close();
                    return;
                }

                transaction.Commit();
                con.Close();

                MessageBox.Show("Registro Guardado Correctamente");
                this.Dispose();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlTransaction transaction = con.BeginTransaction();

            // 1. Actualizar el pedido
            cm = new SqlCommand(@"
                UPDATE compra
                SET fecha_compra=@fecha_compra, total_compra=@total_compra
                WHERE Id_compra =" + compra.Idcompra, con, transaction);

            cm.Parameters.AddWithValue("@fecha_venta", dTimeCompra.Value);
            cm.Parameters.AddWithValue("@total_compra", txtTotalPagar.Text);

            try
            {
                cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                transaction.Rollback();
                con.Close();
                return;
            }

            // 2. Eliminar los productos que ya estaban
            bool eliminados = CompraMaterialQueries.EliminarMaterial(
                ListaCompraMaterialOriginal,
                con,
                transaction);

            if (eliminados == false)
            {
                transaction.Rollback();
                con.Close();
                return;
            }

            // 3. Agregar los nuevos productos
            bool agregados = CompraMaterialQueries.AgregarMaterial(
                compra.Idcompra,
                ListaCompraMaterialActual,
                con,
                transaction);

            if (agregados == false)
            {
                transaction.Rollback();
                con.Close();
                return;
            }

            transaction.Commit();
            con.Close();

            MessageBox.Show("Compra Actualizado");
            this.Dispose();
        }

        private void dgvSeleccionMat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ListaCompraMaterialActual.RemoveAt(e.RowIndex);
            dgvSeleccionMat.Rows.RemoveAt(e.RowIndex);
        }
    }
}
