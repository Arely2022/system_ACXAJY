using System.Data;
using System.Data.SqlClient;
using system_ACXAJY.Entities;
using system_ACXAJY.Queries;

namespace system_ACXAJY
{
    public partial class ModuloProduct : Form
    {
        private readonly SqlConnection con = new(@"Data Source=CMX-TST-3XA7HYU\SQLEXPRESS;Initial Catalog=System_ACXAJY;Integrated Security=True");
        private SqlCommand? cm;

        private readonly List<Material> _listaMaterial = new();
        private readonly List<Categoria> _listaCategoria = new();
        private readonly List<MaterialProducto> _listaMaterialProductoActual = new();
        private readonly List<MaterialProducto> _listaMaterialProductoOriginal = new();
        private readonly Producto _producto;

        public ModuloProduct(Producto? producto = null)
        {
            InitializeComponent();
            LoadCategoria();
            LoadMaterial();

            if (producto == null)
            {
                _producto = new Producto();
            }
            else
            {
                _producto = producto;
                LoadProducto();
            }

        }

        public void LoadProducto()
        {
            if (_producto == null)
            {
                return;
            }

            // 1. Cargar información del pedido en el formulario
            int indexCategoria = _listaCategoria
              .Select((c, i) => new { c, i })
            .FirstOrDefault(x => x.c.Idcategoria == _producto.IdCategoria)!.i;

            lblPID.Text = _producto.IdProducto.ToString();
            txtPName.Text = _producto.NombreProducto;
            txtPDesc.Text = _producto.DescripcionProducto;
            coBoxCateg.SelectedIndex = indexCategoria;
            txtPCant.Text = _producto.CantidadProducto.ToString();
            txtPPre.Text = _producto.PrecioProducto.ToString();

            // 2. Consultar los productos del pedido
            LoadMaterialSeleccionado(_producto.IdProducto);
        }

        public void LoadCategoria()
        {
            coBoxCateg.Items.Clear();
            coBoxCateg.DisplayMember = "NombreCategoria";

            cm = new SqlCommand("SELECT ID_categoria, nombre_categ FROM categoria", con);
            con.Open();

            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                Categoria categoria = new()
                {
                    Idcategoria = Convert.ToInt32(dr[0].ToString()),
                    NombreCategoria = dr[1].ToString()!
                };

                coBoxCateg.Items.Add(categoria);
                _listaCategoria.Add(categoria);
            }
            dr.Close();
            con.Close();
        }

        public void LoadMaterial()
        {
            coBoxMat.Items.Clear();
            coBoxMat.DisplayMember = "NombreMaterial";

            con.Open();
            cm = new SqlCommand("SELECT ID_material, nombre_mat FROM material", con);

            try
            {
                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    Material material = new()
                    {
                        Idmaterial = Convert.ToInt32(dr[0].ToString()),
                        NombreMaterial = dr[1].ToString()!
                    };

                    coBoxMat.Items.Add(material);
                    _listaMaterial.Add(material);
                }

                con.Close();
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Guardar registro?", "Registro Guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            con.Open();
            SqlTransaction transaction = con.BeginTransaction();

            // Categoría seleccionada del selector
            Categoria nombrecateg = (Categoria)coBoxCateg.SelectedItem;

            // Agregar el producto a la base de datos
            cm = new(@"
					INSERT INTO producto (nombre_prod, desc_prod, precio_prod, cantidad_prod, ID_categoriaprod)
					VALUES(@nombre_prod, @desc_prod, @precio_prod, @cantidad_prod, @ID_categoriaprod)
					SELECT SCOPE_IDENTITY();", con, transaction);

            cm.Parameters.AddWithValue("@nombre_prod", txtPName.Text);
            cm.Parameters.AddWithValue("@desc_prod", txtPDesc.Text);
            cm.Parameters.AddWithValue("@precio_prod", Convert.ToInt16(txtPPre.Text));
            cm.Parameters.AddWithValue("@cantidad_prod", Convert.ToInt16(txtPCant.Text));
            cm.Parameters.AddWithValue("@ID_categoriaprod", nombrecateg.Idcategoria);

            try
            {
                cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                transaction.Rollback();
                return;
            }

            // Obtener el ID del producto recién agregado
            int idProducto;
            try
            {
                object returnObj = cm.ExecuteScalar();
                idProducto = int.Parse(returnObj!.ToString()!);
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                con.Close();
                MessageBox.Show(ex.Message);
                return;
            }

            // Agregar el material a la tabla material_producto
            bool agregados = MaterialProductoQueries.AgregarMaterial(
              idProducto,
              _listaMaterialProductoActual,
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
            this.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlTransaction transaction = con.BeginTransaction();

            // Categoría seleccionada
            if (coBoxCateg.SelectedItem is not Categoria categoria)
            {
                MessageBox.Show("Seleccione una categoría");
                return;
            }

            // Actualizar el producto
            string updateQuery = @$"
				UPDATE producto
				SET nombre_prod=@nombre_prod, desc_prod=@desc_prod, ID_categoriaprod=@ID_categoriaprod,
				precio_prod=@precio_prod, cantidad_prod=@cantidad_prod
				WHERE ID_producto = '{1}'";

            cm = new SqlCommand(updateQuery, con, transaction);
            cm.Parameters.AddWithValue("@nombre_prod", txtPName.Text);
            cm.Parameters.AddWithValue("@desc_prod", txtPDesc.Text);
            cm.Parameters.AddWithValue("@ID_categoriaprod", categoria.Idcategoria);
            cm.Parameters.AddWithValue("@precio_prod", Convert.ToInt16(txtPPre.Text));
            cm.Parameters.AddWithValue("@cantidad_prod", Convert.ToInt16(txtPCant.Text));

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

            // Eliminar los materiales existentes de material_producto
            bool eliminados = MaterialProductoQueries.EliminarMaterial(
				_listaMaterialProductoOriginal,
				con,
				transaction);

            if (!eliminados)
            {
                transaction.Rollback();
                con.Close();
                return;
            }

            // Agregar los nuevos productos
            bool agregados = MaterialProductoQueries.AgregarMaterial(
				_producto.IdProducto,
				_listaMaterialProductoActual,
				con,
				transaction);

            if (!agregados)
            {
                transaction.Rollback();
                con.Close();
                return;
            }

            // Finalizar transacción
            transaction.Commit();
            con.Close();

            MessageBox.Show("Pedido Actualizado");
            Dispose();
        }
        public void Clear()
        {
            txtPName.Clear();
            txtPDesc.Clear();
            txtPCant.Clear();
            txtPPre.Clear();
            coBoxCateg.Text = "";

        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            Clear();
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

            Material materialSeleccionado = (Material)coBoxMat.SelectedItem;

			int cantidadMaterial = Convert.ToInt32(txtcantMaterial.Text);
			double precio = cantidadMaterial * materialSeleccionado.PrecioMaterial;

			int indiceMaterial = _listaMaterialProductoActual.FindIndex(m => m.Idmaterialmp == materialSeleccionado.Idmaterial);

			if (indiceMaterial == -1)
			{
				MaterialProducto materialProducto = new()
				{
					Idmaterialmp = materialSeleccionado.Idmaterial,
					CantMaterialmp = cantidadMaterial,
					PrecioMaterialmp = precio
				};

				_listaMaterialProductoActual.Add(materialProducto);
				dgvSeleccionMat.Rows.Add(0, materialSeleccionado.NombreMaterial, materialProducto.CantMaterialmp, materialProducto.PrecioMaterialmp);
			}
			else {
				MaterialProducto materialProducto = _listaMaterialProductoActual[indiceMaterial];
				materialProducto.CantMaterialmp += cantidadMaterial;
				materialProducto.PrecioMaterialmp += precio;

				DataGridViewRow row = dgvSeleccionMat.Rows[indiceMaterial];

				row.Cells[2].Value = materialProducto.CantMaterialmp;
				row.Cells[3].Value = materialProducto.PrecioMaterialmp;
			}

			// Sumar el precio del material al precio total del producto
			double total = Convert.ToDouble(txtCosto.Text);
			total += precio;
			txtCosto.Text = total.ToString();


            // Limpiar campos de material
            coBoxMat.SelectedIndex = -1;
            txtcantMaterial.Clear();
        }

        public void LoadMaterialSeleccionado(int idProducto)
        {
            dgvSeleccionMat.Rows.Clear();

            con.Open();

			List<MaterialProducto> listaMaterialProducto = MaterialProductoQueries.ConsultarPorProducto(
				con,
				idProducto);

			foreach (MaterialProducto materialProducto in listaMaterialProducto)
			{
				Material material = _listaMaterial
					.Find(m => m.Idmaterial == materialProducto.Idmaterialmp)!;

				_listaMaterialProductoActual.Add(materialProducto);
				_listaMaterialProductoOriginal.Add(materialProducto);

				// ID | Nombre | Cantidad | Costo
				dgvSeleccionMat.Rows.Add(
					material.Idmaterial,
					material.NombreMaterial,
					materialProducto.CantMaterialmp,
					materialProducto.PrecioMaterialmp);
			}

			con.Close();
        }

        private void dgvSeleccionMat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _listaMaterialProductoActual.RemoveAt(e.RowIndex);
            dgvSeleccionMat.Rows.RemoveAt(e.RowIndex);
        }
    }
}
