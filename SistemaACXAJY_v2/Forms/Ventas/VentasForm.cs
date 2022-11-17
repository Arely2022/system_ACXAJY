using System.Data.SqlClient;
using system_ACXAJY.Entities;
using system_ACXAJY.Queries;

namespace system_ACXAJY
{
    public partial class VentasForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CMX-TST-3XA7HYU\SQLEXPRESS;Initial Catalog=System_ACXAJY;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public VentasForm()
        {
            InitializeComponent();
            LoadVenta();
        }
        public void LoadVenta()
        {
            dgvVenta.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM venta", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {

                dgvVenta.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ModuloVentas ventasmodulo = new ModuloVentas();
            ventasmodulo.btnSave.Enabled = true;
            ventasmodulo.btnUpdate.Enabled = false;
            ventasmodulo.ShowDialog();
            LoadVenta();
        }

        private void dgvVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvVenta.Columns[e.ColumnIndex].Name;
            if (colName == "editar")
            {
                ModuloVentas moduloVentas = new ModuloVentas();
                Venta venta = new Venta();
                venta.IdVenta = Convert.ToInt32(dgvVenta.Rows[e.RowIndex].Cells[0].Value.ToString());
                venta.TotalVenta = float.Parse(dgvVenta.Rows[e.RowIndex].Cells[1].Value.ToString());
                venta.FechaVenta = DateTime.Parse(dgvVenta.Rows[e.RowIndex].Cells[2].Value.ToString());


                moduloVentas.venta = venta;
                moduloVentas.LoadVenta();
                moduloVentas.btnSave.Enabled = false;
                moduloVentas.btnUpdate.Enabled = true;
                moduloVentas.ShowDialog();
            }
            else if (colName == "eliminar")
            {
                if (MessageBox.Show("¿Eliminar registro?", "Registro eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // 1. Abrir conexión
                    con.Open();
                    // 2. Iniciar transacción
                    SqlTransaction transaction = con.BeginTransaction();
                    // 3. Consultar pedido_productos del pedido seleccionado
                    int idventa = Convert.ToInt32(dgvVenta.Rows[e.RowIndex].Cells[0].Value.ToString());
                    List<VentaProducto> ventaProductos = VentaProductosQueries.ConsultarPorVenta(con, idventa, transaction);
                    // 4. Eliminar registros de pedido_productos con PedidoProductoQueries.EliminarProductos()
                    bool EliminarPedido = VentaProductosQueries.EliminarProductos(ventaProductos, con, transaction);
                    if (EliminarPedido == false)
                    {
                        transaction.Rollback();
                        con.Close();
                        return;
                    }
                    // 5. Eliminar pedido
                    cm = new SqlCommand("DELETE FROM venta WHERE Id_venta = '" + idventa + "'", con, transaction);
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

                    // 6. Transaction.Commit
                    transaction.Commit();
                    // 7. Cerrar conexión
                    con.Close();

                    MessageBox.Show("Registro eliminado correctamente");
                }
            }
            LoadVenta();
        }
    }
}
