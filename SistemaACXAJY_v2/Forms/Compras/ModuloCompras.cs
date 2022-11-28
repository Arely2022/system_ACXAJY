using SistemaACXAJY_v2.Entities;
using System.Data;
using System.Data.SqlClient;
using system_ACXAJY.Entities;
using system_ACXAJY.Queries;

namespace system_ACXAJY
{
    public partial class ModuloCompras : Form
    {
        private readonly SqlConnection con = new(@"Data Source=CMX-TST-3XA7HYU\SQLEXPRESS;Initial Catalog=System_ACXAJY;Integrated Security=True");

        private readonly List<Material> _listaMaterial = new();
        private readonly List<CompraMaterial> _listaCompraMaterialActual = new();
        private readonly List<CompraMaterial> _listaCompraMaterialOriginal = new();
        private readonly Compra _compra;

        public ModuloCompras(Compra? compra = null)
        {
            InitializeComponent();
            LoadMaterial();

            if (compra == null)
            {
                _compra = new Compra();
            }
            else
            {
                _compra = compra;
                LoadCompra();
            }
        }

        public void clear()
        {
            dTimeCompra.Value = DateTime.Now;
        }

        public void LoadMaterial()
        {
            coBoxMat.Items.Clear();
            coBoxMat.DisplayMember = "NombreMaterial";

            SqlDataReader? dr = null;
            SqlCommand cm = new("SELECT ID_material, nombre_mat, precio_mat FROM material", con);
            try
            {
                con.Open();
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    Material material = new()
                    {
                        Idmaterial = Convert.ToInt32(dr[0].ToString()),
                        NombreMaterial = dr[1].ToString()!,
                        PrecioMaterial = Convert.ToDouble(dr[2].ToString())
                    };

                    coBoxMat.Items.Add(material);
                    _listaMaterial.Add(material);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                dr?.Close();
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
                Material material = _listaMaterial
                    .Find(p => p.Idmaterial == compraMaterial.idmaterialcm)!;

                float preciomaterial = (float) material.PrecioMaterial;
                string nombrematerial = material.NombreMaterial;

                _listaCompraMaterialActual.Add(compraMaterial);
                _listaCompraMaterialOriginal.Add(compraMaterial);

                dgvSeleccionMat.Rows.Add(0, nombrematerial, compraMaterial.cantmaterialcm, preciomaterial);
            }

            con.Close();

        }
        public void LoadCompra()
        {
            if (_compra == null)
            {
                return;
            }

            // 1. Cargar información del pedido en el formulario
            lblCID.Text = _compra.Idcompra.ToString();
            txtTotalPagar.Text = _compra.totalcompra.ToString();
            dTimeCompra.Text = _compra.FechaCompra.ToString();

            // 2. Consultar los productos del pedido
            LoadCompraMaterial(_compra.Idcompra);

            // Calcular el total de compra
            double total = _listaCompraMaterialActual.Sum(cm => {
                Material material = _listaMaterial.Find(m => m.Idmaterial == cm.idmaterialcm)!;
                return cm.cantmaterialcm * material.PrecioMaterial;
            });
            txtTotalPagar.Text = total.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (coBoxMat.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un material");
                return;
            }

            Material materialSeleccionado = (Material)coBoxMat.SelectedItem!;

            int indiceMaterial = _listaCompraMaterialActual.FindIndex(cm => cm.idmaterialcm == materialSeleccionado.Idmaterial);

            int cantidadMaterial = Convert.ToInt32(txtCantMat.Text);
			double precio = cantidadMaterial * materialSeleccionado.PrecioMaterial;

			if (indiceMaterial == -1)
			{
                CompraMaterial compraMaterial = new()
                {
                    idmaterialcm = materialSeleccionado.Idmaterial,
                    cantmaterialcm = cantidadMaterial
                };

                _listaCompraMaterialActual.Add(compraMaterial);
                dgvSeleccionMat.Rows.Add(0, materialSeleccionado.NombreMaterial, compraMaterial.cantmaterialcm, materialSeleccionado.PrecioMaterial);
			}
			else {
				CompraMaterial compraMaterial = _listaCompraMaterialActual[indiceMaterial];
				compraMaterial.cantmaterialcm += cantidadMaterial;

				DataGridViewRow row = dgvSeleccionMat.Rows[indiceMaterial];

				row.Cells[2].Value = compraMaterial.cantmaterialcm;
			}

            // Sumar el precio de los productos a la venta
			double total = Convert.ToDouble(txtTotalPagar.Text);
			total += precio;
			txtTotalPagar.Text = total.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Guardar registro?", "Registro Guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            con.Open();
            SqlTransaction transaction = con.BeginTransaction();

            // 1. Guardar la compra
            string query = @"
                    INSERT INTO compra(total_compra, fecha_compra)
                    VALUES(@total_compra, @fecha_compra);
                    SELECT SCOPE_IDENTITY();";

            SqlCommand cm = new(query, con, transaction);
            cm.Parameters.AddWithValue("@total_compra", Convert.ToInt32(txtTotalPagar.Text));
            cm.Parameters.AddWithValue("@fecha_compra", dTimeCompra.Value);

            // 2. Obtener el ID del pedido
            int idCompra = 0;
            try
            {
                object returnObj = cm.ExecuteScalar();
                idCompra = int.Parse(returnObj.ToString()!);
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
                idCompra,
                _listaCompraMaterialActual,
                con,
                transaction);

            if (!agregados)
            {
                transaction.Rollback();
                con.Close();
                return;
            }

            transaction.Commit();
            con.Close();

            MessageBox.Show("Registro Guardado Correctamente");
            Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlTransaction transaction = con.BeginTransaction();

            // 1. Actualizar el pedido
            string query = @$"
                UPDATE compra
                SET fecha_compra=@fecha_compra, total_compra=@total_compra
                WHERE Id_compra = {_compra.Idcompra}";

            SqlCommand cm = new(query, con, transaction);

            cm.Parameters.AddWithValue("@fecha_compra", dTimeCompra.Value);
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
                _listaCompraMaterialOriginal,
                con,
                transaction);

            if (!eliminados)
            {
                transaction.Rollback();
                con.Close();
                return;
            }

            // 3. Agregar los nuevos productos
            bool agregados = CompraMaterialQueries.AgregarMaterial(
                _compra.Idcompra,
                _listaCompraMaterialActual,
                con,
                transaction);

            if (!agregados)
            {
                transaction.Rollback();
                con.Close();
                return;
            }

            transaction.Commit();
            con.Close();

            MessageBox.Show("Compra Actualizado");
            Dispose();
        }

        private void dgvSeleccionMat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CompraMaterial compraMaterial = _listaCompraMaterialActual[e.RowIndex];
            Material material = _listaMaterial.Find(m => m.Idmaterial == compraMaterial.idmaterialcm)!;

            _listaCompraMaterialActual.RemoveAt(e.RowIndex);
            dgvSeleccionMat.Rows.RemoveAt(e.RowIndex);

            // Restar el precio de los materiales a la compra
			double total = Convert.ToDouble(txtTotalPagar.Text);
			total -= compraMaterial.cantmaterialcm * material.PrecioMaterial;
			txtTotalPagar.Text = total.ToString();
        }
    }
}
