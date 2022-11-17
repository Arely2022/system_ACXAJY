using System.Data;
using System.Data.SqlClient;
using system_ACXAJY.Entities;
using system_ACXAJY.Queries;

namespace system_ACXAJY
{
    public partial class ModuloVentas : Form
    {
        private readonly SqlConnection con = new(@"Data Source=CMX-TST-3XA7HYU\SQLEXPRESS;Initial Catalog=System_ACXAJY;Integrated Security=True");

        private readonly List<Producto> _listaProducto = new();
        private readonly List<VentaProducto> _listaVentaProductoActual = new();
        private readonly List<VentaProducto> _listaVentaProductoOriginal = new();

        private readonly Venta _venta;

        public ModuloVentas(Venta? venta = null)
        {
            InitializeComponent();
            LoadCategoria();
            LoadProducto();

            if (venta == null)
            {
                _venta = new Venta();
            }
            else
            {
                _venta = venta;
                LoadVenta();
            }
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void Clear()
        {
            dTimeVenta.Value = DateTime.Now;
        }

        public void LoadCategoria()
        {
            coBoxCateg.Items.Clear();
            coBoxCateg.DisplayMember = "NombreCategoria";

            SqlDataReader? dr = null;
            SqlCommand cm = new("SELECT ID_categoria, nombre_categ FROM categoria", con);
            try
            {
                con.Open();
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    Categoria categoria = new()
                    {
                        Idcategoria = Convert.ToInt32(dr[0].ToString()),
                        NombreCategoria = dr[1].ToString()!
                    };
                    coBoxCateg.Items.Add(categoria);
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

        public void LoadProducto()
        {
            coBoxProd.Items.Clear();
            coBoxProd.DisplayMember = "NombreProducto";

            SqlDataReader? dr = null;
            SqlCommand cm = new("SELECT ID_producto, nombre_prod, ID_categoriaprod, precio_prod FROM producto ", con);
            try
            {
                con.Open();
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    Producto product = new()
                    {
                        IdProducto = Convert.ToInt32(dr[0].ToString()),
                        NombreProducto = dr[1].ToString()!,
                        IdCategoria = Convert.ToInt32(dr[2].ToString()),
                        PrecioProducto = float.Parse(dr[3].ToString()!)
                    };

                    _listaProducto.Add(product);
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

        public void LoadVentaProducto(int idventa)
        {
            con.Open();

            List<VentaProducto> ventaproductos = VentaProductosQueries.ConsultarPorVenta(con, idventa);
            foreach (VentaProducto ventaProducto in ventaproductos)
            {
                Producto producto = _listaProducto
                    .Find(p => p.IdProducto == ventaProducto.Idproductovp)!;

                float precioprod = producto.PrecioProducto;
                string nombreprod = producto.NombreProducto;

                _listaVentaProductoActual.Add(ventaProducto);
                _listaVentaProductoOriginal.Add(ventaProducto);

                dgvSeleccionProd.Rows.Add(0, nombreprod, ventaProducto.cantprodvp, precioprod);
            }

            con.Close();
        }

        private void LoadVenta()
        {
            if (_venta == null)
            {
                return;
            }

            // 1. Cargar información del pedido en el formulario
            lblVID.Text = _venta.IdVenta.ToString();
            txtTotalPagar.Text = _venta.TotalVenta.ToString();
            dTimeVenta.Text = _venta.FechaVenta.ToString();

            // 2. Consultar los productos del pedido
            LoadVentaProducto(_venta.IdVenta);

            // Calcular el total de venta
            double total = _listaVentaProductoActual.Sum(vp => {
                Producto producto = _listaProducto.Find(p => p.IdProducto == vp.Idproductovp)!;
                return vp.cantprodvp * producto.PrecioProducto;
            });
            txtTotalPagar.Text = total.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (coBoxProd.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }

            Producto productoSeleccionado = (Producto)coBoxProd.SelectedItem;

            VentaProducto ventaProducto = new()
            {
                Idproductovp = productoSeleccionado.IdProducto,
                cantprodvp = Convert.ToInt32(txtCantP.Text)
            };

            _listaVentaProductoActual.Add(ventaProducto);
            dgvSeleccionProd.Rows.Add(0, productoSeleccionado.NombreProducto, ventaProducto.cantprodvp, productoSeleccionado.PrecioProducto);

            coBoxCateg.SelectedIndex = -1;
            coBoxProd.Items.Clear();
            txtCantP.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Guardar registro?", "Registro Guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            con.Open();
            SqlTransaction transaction = con.BeginTransaction();

            // 1. Guardar la venta
            const string query = @"
                INSERT INTO venta(total_venta, fecha_venta)
                VALUES(@total_venta, @fecha_venta);
                SELECT SCOPE_IDENTITY();";

            SqlCommand cm = new(query, con, transaction);
            cm.Parameters.AddWithValue("@total_venta", Convert.ToInt16(txtTotalPagar.Text));
            cm.Parameters.AddWithValue("@fecha_venta", dTimeVenta.Value);

            // 2. Obtener el ID del pedido
            int idVenta = 0;
            try
            {
                object returnObj = cm.ExecuteScalar();
                idVenta = int.Parse(returnObj.ToString()!);
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                con.Close();
                MessageBox.Show(ex.Message);
                return;
            }

            // 3. Agregar los productos a la tabla pedido_producto
            bool agregados = VentaProductosQueries.AgregarProductos(
                idVenta,
                _listaVentaProductoActual,
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
            string query = @"
                UPDATE venta
                SET fecha_venta=@fecha_venta, total_venta=@total_venta
                WHERE Id_venta = {_venta.IdVenta}";
            SqlCommand cm = new(query, con, transaction);

            cm.Parameters.AddWithValue("@fecha_venta", dTimeVenta.Value);
            cm.Parameters.AddWithValue("@total_venta", txtTotalPagar.Text);

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
            bool eliminados = VentaProductosQueries.EliminarProductos(
                _listaVentaProductoOriginal,
                con,
                transaction);

            if (!eliminados)
            {
                transaction.Rollback();
                con.Close();
                return;
            }

            // 3. Agregar los nuevos productos
            bool agregados = VentaProductosQueries.AgregarProductos(
                _venta.IdVenta,
                _listaVentaProductoActual,
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

            MessageBox.Show("Venta Actualizada");
            Dispose();
        }

        private void coBoxCateg_SelectedIndexChanged(object sender, EventArgs e)
        {
            coBoxProd.Items.Clear();
            if (coBoxCateg.SelectedIndex < 0)
            {
                return;
            }

            Categoria categoria = (Categoria)coBoxCateg.SelectedItem;

            List<Producto> productosCategoria = _listaProducto
                .Where(p => p.IdCategoria == categoria.Idcategoria)
                .ToList();

            foreach (Producto producto in productosCategoria)
            {
                coBoxProd.Items.Add(producto);
            }
        }

        private void dgvSeleccionProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _listaVentaProductoActual.RemoveAt(e.RowIndex);
            dgvSeleccionProd.Rows.RemoveAt(e.RowIndex);
        }
    }
}
