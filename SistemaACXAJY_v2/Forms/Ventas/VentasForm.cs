using System.Data.SqlClient;
using system_ACXAJY.Entities;
using system_ACXAJY.Queries;

namespace system_ACXAJY
{
    public partial class VentasForm : Form
    {
        private readonly SqlConnection con = new SqlConnection(@"Data Source=CMX-TST-3XA7HYU\SQLEXPRESS;Initial Catalog=System_ACXAJY;Integrated Security=True");

        private readonly List<Venta> _ventas = new();

        public VentasForm()
        {
            InitializeComponent();
            LoadVenta();
        }
        public void LoadVenta()
        {
            dgvVenta.Rows.Clear();
            _ventas.Clear();

            SqlCommand cm = new("SELECT * FROM venta", con);
            SqlDataReader? dr = null;

            try {
                con.Open();
                dr = cm.ExecuteReader();

                double total = 0;
                while (dr.Read())
                {
                    Venta venta = new()
                    {
                        IdVenta = Convert.ToInt32(dr[0]),
                        TotalVenta = Convert.ToDouble(dr[1]),
                        FechaVenta = Convert.ToDateTime(dr[2]),
                    };

                    total += venta.TotalVenta;

                    _ventas.Add(venta);

                    dgvVenta.Rows.Add(
                        venta.IdVenta,
                        venta.TotalVenta,
                        venta.FechaVenta);
                }

                textBox1.Text = total.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                dr?.Close();
            }
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
            Venta venta = _ventas[e.RowIndex];

            if (colName == "editar")
            {
                ModuloVentas moduloVentas = new(venta);
                moduloVentas.btnSave.Enabled = false;
                moduloVentas.btnUpdate.Enabled = true;
                moduloVentas.ShowDialog();
            }
            else if (colName == "eliminar")
            {
                if (MessageBox.Show("¿Eliminar registro?", "Registro eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }

                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                // Consultar productos de la venta
                List<VentaProducto> ventaProductos = VentaProductosQueries.ConsultarPorVenta(con, venta.IdVenta, transaction);

                // Eliminar los productos
                bool productosEliminados = VentaProductosQueries.EliminarProductos(ventaProductos, con, transaction);
                if (!productosEliminados)
                {
                    transaction.Rollback();
                    con.Close();
                    return;
                }

                // Eliminar pedido
                SqlCommand cm = new($"DELETE FROM venta WHERE Id_venta = '{venta.IdVenta}'", con, transaction);
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

                transaction.Commit();
                con.Close();
                MessageBox.Show("Registro eliminado correctamente");
            }
            LoadVenta();
        }
    }
}
