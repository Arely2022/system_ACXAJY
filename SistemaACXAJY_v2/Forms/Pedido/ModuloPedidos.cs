using System.Data;
using System.Data.SqlClient;
using system_ACXAJY.Entities;
using system_ACXAJY.Queries;

namespace system_ACXAJY
{
    public partial class ModuloPedidos : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CMX-TST-3XA7HYU\SQLEXPRESS;Initial Catalog=System_ACXAJY;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        List<Producto> ListaProducto = new List<Producto>();
        List<PedidoProducto> ListaPedidoProductoActual = new List<PedidoProducto>();
        List<PedidoProducto> ListaPedidoProductoOriginal = new List<PedidoProducto>();
        public Pedido pedido = null;

        public ModuloPedidos()
        {
            InitializeComponent();
            LoadCategoria();
            LoadProducto();
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void Clear()
        {
            txtCliName.Clear();
            cBEstado.Checked = false;
            dTimeEntrega.Value = DateTime.Now;
            txtDir.Clear();
        }

        public void LoadPedido()
        {
            if (pedido == null)
            {
                return;
            }

            // 1. Cargar información del pedido en el formulario
            lblOID.Text = pedido.IdPedido.ToString();
            txtCliName.Text = pedido.NomCliente;
            cBEstado.Checked = pedido.EstadoProd;
            txtTotalPagar.Text = pedido.TotalPedido.ToString();
            dTimeEntrega.Text = pedido.FechaEntrega.ToString();
            txtDir.Text = pedido.DirEntrega;

            // 2. Consultar los productos del pedido
            LoadPedidoProducto(pedido.IdPedido);
        }

        private void LoadPedidoProducto(int idpedido)
        {

            con.Open();

            List<PedidoProducto> pedidoProductos = PedidoProductoQueries.ConsultarPorPedido(con, idpedido);
            foreach (PedidoProducto pedidoProducto in pedidoProductos)
            {
                Producto producto = ListaProducto
                    .Where(p => p.IdProducto == pedidoProducto.Idproductopp)
                    .FirstOrDefault()!;

                float precioprod = producto.PrecioProducto;
                string nombreprod = producto.NombreProducto;

                ListaPedidoProductoActual.Add(pedidoProducto);
                ListaPedidoProductoOriginal.Add(pedidoProducto);

                dgvSeleccionProd.Rows.Add(0, nombreprod, pedidoProducto.cantprod, pedidoProducto.caractprod, precioprod);
            }

            con.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PedidoProducto pedidoProducto = new PedidoProducto();
            Producto SelectedProd = coBoxProd.SelectedItem as Producto;
            pedidoProducto.Idproductopp = SelectedProd.IdProducto;
            pedidoProducto.cantprod = Convert.ToInt32(txtCantP.Text);
            pedidoProducto.caractprod = txtPCarac.Text;
            ListaPedidoProductoActual.Add(pedidoProducto);
            dgvSeleccionProd.Rows.Add(0, SelectedProd.NombreProducto, pedidoProducto.cantprod, pedidoProducto.caractprod, SelectedProd.PrecioProducto);

            double total = (Convert.ToDouble(SelectedProd.PrecioProducto) * Convert.ToDouble(txtCantP.Text));
            txtTotalPagar.Text = total.ToString();

            coBoxCateg.SelectedIndex = -1;
            coBoxProd.Items.Clear();
            txtPCarac.Clear();
            txtCantP.Clear();
        }
        public void LoadProductoSeleccionado()
        {
            dgvSeleccionProd.Rows.Clear();
            cm = new SqlCommand(@"
                SELECT ID_detallepp, nombre_prod, cantprod_pp, caract_adi_pp, precio_prod
                FROM pedido_producto
                INNER JOIN producto ON ID_producto_pp = ID_producto", con);

            try
            {
                con.Open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {

                    dgvSeleccionProd.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
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

                // 1. Guardar el pedido
                cm = new SqlCommand(@"
                    INSERT INTO pedido(nomcli_ped, completado_ped, total_ped, fechaentrega_ped, direntrega_ped)
                    VALUES(@nomcli_ped, @completado_ped, @total_ped, @fechaentrega_ped, @direntrega_ped);
                    SELECT SCOPE_IDENTITY();", con, transaction);
                cm.Parameters.AddWithValue("@nomcli_ped", txtCliName.Text);
                cm.Parameters.AddWithValue("@completado_ped", cBEstado.Checked);
                cm.Parameters.AddWithValue("@total_ped", Convert.ToInt16(txtTotalPagar.Text));
                cm.Parameters.AddWithValue("@fechaentrega_ped", dTimeEntrega.Value);
                cm.Parameters.AddWithValue("@direntrega_ped", txtDir.Text);

                // 2. Obtener el ID del pedido
                int IdPedido = 0;
                try
                {
                    object returnObj = cm.ExecuteScalar();
                    if (returnObj != null)
                    {
                        int.TryParse(returnObj.ToString(), out IdPedido);
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
                bool agregados = PedidoProductoQueries.AgregarProductos(
                    IdPedido,
                    ListaPedidoProductoActual,
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

        public void LoadCategoria()
        {
            coBoxCateg.Items.Clear();
            coBoxCateg.DisplayMember = "NombreCategoria";

            cm = new SqlCommand("SELECT ID_categoria, nombre_categ FROM categoria", con);
            try
            {
                con.Open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.Idcategoria = Convert.ToInt32(dr[0].ToString());
                    categoria.NombreCategoria = dr[1].ToString();
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
                dr.Close();
            }
        }

        public void LoadProducto()
        {
            coBoxProd.Items.Clear();
            coBoxProd.DisplayMember = "NombreProducto";
            cm = new SqlCommand("SELECT ID_producto, nombre_prod, ID_categoriaprod, precio_prod FROM producto ", con);
            try
            {
                con.Open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    Producto product = new Producto();
                    product.IdProducto = Convert.ToInt32(dr[0].ToString());
                    product.NombreProducto = dr[1].ToString();
                    product.IdCategoria = Convert.ToInt32(dr[2].ToString());
                    product.PrecioProducto = float.Parse(dr[3].ToString());
                    ListaProducto.Add(product);

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlTransaction transaction = con.BeginTransaction();

            // 1. Actualizar el pedido
            cm = new SqlCommand(@"
                UPDATE pedido
                SET nomcli_ped=@nomcli_ped, completado_ped=@completado_ped, total_ped=@total_ped,
                    fechaentrega_ped=@fechaentrega_ped, direntrega_ped=@direntrega_ped
                WHERE ID_pedido =" + pedido.IdPedido, con, transaction);

            cm.Parameters.AddWithValue("@nomcli_ped", txtCliName.Text);
            cm.Parameters.AddWithValue("@completado_ped", cBEstado.Checked);
            cm.Parameters.AddWithValue("@total_ped", Convert.ToInt16(txtTotalPagar.Text));
            cm.Parameters.AddWithValue("@fechaentrega_ped", dTimeEntrega.Value);
            cm.Parameters.AddWithValue("@direntrega_ped", txtDir.Text);

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
            bool eliminados = PedidoProductoQueries.EliminarProductos(
                ListaPedidoProductoOriginal,
                con,
                transaction);

            if (eliminados == false)
            {
                transaction.Rollback();
                con.Close();
                return;
            }

            // 3. Agregar los nuevos productos
            bool agregados = PedidoProductoQueries.AgregarProductos(
                pedido.IdPedido,
                ListaPedidoProductoActual,
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

            MessageBox.Show("Pedido Actualizado");
            this.Dispose();
        }

        private void coBoxCateg_SelectedIndexChanged(object sender, EventArgs e)
        {
            coBoxProd.Items.Clear();
            if (coBoxCateg.SelectedIndex < 0)
            {
                return;
            }

            Categoria categoria = (Categoria)coBoxCateg.SelectedItem;

            List<Producto> productosCategoria = ListaProducto.Where(p => p.IdCategoria == categoria.Idcategoria).ToList();
            foreach (Producto producto in productosCategoria)
            {
                coBoxProd.Items.Add(producto);
            }
        }

        //Habilita elimiado detalle de pedido
        private void dgvSeleccionProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // TODO: 2022-11-15 -> Verificar que la columna seleccionada sea la de eliminar
            ListaPedidoProductoActual.RemoveAt(e.RowIndex);
            dgvSeleccionProd.Rows.RemoveAt(e.RowIndex);
        }
    }
}
