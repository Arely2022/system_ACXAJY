using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using system_ACXAJY.Entities;
using system_ACXAJY.Queries;

namespace system_ACXAJY
{
    public partial class ModuloVentas : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CMX-TST-3XA7HYU\SQLEXPRESS;Initial Catalog=System_ACXAJY;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        List<Producto> ListaProducto = new List<Producto>();
        List<VentaProducto> ListaVentaProductoActual = new List<VentaProducto>();
        List<VentaProducto> ListaVentaProductoOriginal = new List<VentaProducto>();
        public Venta venta = null;
        public ModuloVentas()
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
            dTimeVenta.Value = DateTime.Now;
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
                    product.Idproducto = Convert.ToInt32(dr[0].ToString());
                    product.NombreProducto = dr[1].ToString();
                    product.Idcategoria = Convert.ToInt32(dr[2].ToString());
                    product.precioProd = float.Parse(dr[3].ToString());
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
        public void LoadVentaProducto(int idventa)
        {
            con.Open();

            List<VentaProducto> ventaproducto = VentaProductosQueries.ConsultarPorVenta(con, idventa);
            foreach (VentaProducto ventaProducto in ventaproducto)
            {
                Producto producto = ListaProducto
                    .Where(p => p.Idproducto == ventaProducto.Idproductovp)
                    .FirstOrDefault()!;

                float precioprod = producto.precioProd;
                string nombreprod = producto.NombreProducto;

                ListaVentaProductoActual.Add(ventaProducto);
                ListaVentaProductoOriginal.Add(ventaProducto);

                dgvSeleccionProd.Rows.Add(0, nombreprod, ventaProducto.cantprodvp, precioprod);
            }

            con.Close();
        }
        public void LoadVenta()
        {
            if (venta == null)
            {
                return;
            }

            // 1. Cargar información del pedido en el formulario
            lblVID.Text = venta.IdVenta.ToString();
            txtTotalPagar.Text = venta.TotalVenta.ToString();
            dTimeVenta.Text = venta.FechaVenta.ToString();
            
            

            // 2. Consultar los productos del pedido
            LoadVentaProducto(venta.IdVenta);
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            VentaProducto ventaProducto = new VentaProducto();
            Producto SelectedProd = coBoxProd.SelectedItem as Producto;
            ventaProducto.Idproductovp = SelectedProd.Idproducto;
            ventaProducto.cantprodvp = Convert.ToInt32(txtCantP.Text);
            
            ListaVentaProductoActual.Add(ventaProducto);
            dgvSeleccionProd.Rows.Add(0, SelectedProd.NombreProducto, ventaProducto.cantprodvp, SelectedProd.precioProd);

            double total = (Convert.ToDouble(SelectedProd.precioProd) * Convert.ToDouble(txtCantP.Text));
            txtTotalPagar.Text = total.ToString();

            coBoxCateg.SelectedIndex = -1;
            coBoxProd.Items.Clear();
            txtCantP.Clear();
        }
        public void LoadProductoSeleccionado()
        {
            dgvSeleccionProd.Rows.Clear();
            cm = new SqlCommand(@"
                SELECT ID_detallevp, nombre_prod, cantprod_vp, precio_prod
                FROM venta_producto
                INNER JOIN producto ON ID_producto_vp = ID_producto", con);

            try
            {
                con.Open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {

                    dgvSeleccionProd.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
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

                // 1. Guardar la venta
                cm = new SqlCommand(@"
                    INSERT INTO venta(total_venta, fecha_venta)
                    VALUES(@total_venta, @fecha_venta);
                    SELECT SCOPE_IDENTITY();", con, transaction);
                cm.Parameters.AddWithValue("@total_venta", Convert.ToInt16(txtTotalPagar.Text));
                cm.Parameters.AddWithValue("@fecha_venta", dTimeVenta.Value);

                // 2. Obtener el ID del pedido
                int idventa = 0;
                try
                {
                    object returnObj = cm.ExecuteScalar();
                    if (returnObj != null)
                    {
                        int.TryParse(returnObj.ToString(), out idventa);
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
                bool agregados = VentaProductosQueries.AgregarProductos(
                    idventa,
                    ListaVentaProductoActual,
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
                UPDATE venta
                SET fecha_venta=@fecha_venta
                WHERE Id_venta =" + venta.IdVenta, con, transaction);

            cm.Parameters.AddWithValue("@fecha_venta", dTimeVenta.Value);

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
                ListaVentaProductoOriginal,
                con,
                transaction);

            if (eliminados == false)
            {
                transaction.Rollback();
                con.Close();
                return;
            }

            // 3. Agregar los nuevos productos
            bool agregados = VentaProductosQueries.AgregarProductos(
                venta.IdVenta,
                ListaVentaProductoActual,
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

            MessageBox.Show("Venta Actualizado");
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

            List<Producto> productosCategoria = ListaProducto.Where(p => p.Idcategoria == categoria.Idcategoria).ToList();
            foreach (Producto producto in productosCategoria)
            {
                coBoxProd.Items.Add(producto);
            }
        }

        private void dgvSeleccionProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ListaVentaProductoActual.RemoveAt(e.RowIndex);
            dgvSeleccionProd.Rows.RemoveAt(e.RowIndex);
        }
    }
}
