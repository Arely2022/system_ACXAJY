using System.Data.SqlClient;
using system_ACXAJY.Entities;
using system_ACXAJY.Queries;

namespace system_ACXAJY
{
    public partial class PedidoForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CMX-TST-3XA7HYU\SQLEXPRESS;Initial Catalog=System_ACXAJY;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public PedidoForm()
        {
            InitializeComponent();
            LoadPedido();
        }

        //Carga información de tabla pedido a DataReader
        public void LoadPedido()
        {
            dgvPedido.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM pedido", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {

                dgvPedido.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }

        //Habilita boton ADD para agregar nuevo pedido
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ModuloPedidos PedidoModulo = new ModuloPedidos();
            PedidoModulo.btnSave.Enabled = true;
            PedidoModulo.btnUpdate.Enabled = false;
            PedidoModulo.ShowDialog();
            LoadPedido();
        }

        //Edita información de pedido
        private void dgvPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvPedido.Columns[e.ColumnIndex].Name;
            if (colName == "editar")
            {
                ModuloPedidos moduloPedidos = new ModuloPedidos();
                Pedido pedido = new Pedido();
                pedido.IdPedido = Convert.ToInt32(dgvPedido.Rows[e.RowIndex].Cells[0].Value.ToString());
                pedido.NomCliente = dgvPedido.Rows[e.RowIndex].Cells[1].Value.ToString();
                pedido.EstadoProd = Convert.ToBoolean(dgvPedido.Rows[e.RowIndex].Cells[2].Value.ToString());
                pedido.TotalPedido = float.Parse(dgvPedido.Rows[e.RowIndex].Cells[3].Value.ToString());
                pedido.FechaEntrega = DateTime.Parse(dgvPedido.Rows[e.RowIndex].Cells[4].Value.ToString());
                pedido.DirEntrega = dgvPedido.Rows[e.RowIndex].Cells[5].Value.ToString();

                moduloPedidos.pedido = pedido;
                moduloPedidos.LoadPedido();
                moduloPedidos.btnSave.Enabled = false;
                moduloPedidos.btnUpdate.Enabled = true;
                moduloPedidos.ShowDialog();
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
                    int idPedido = Convert.ToInt32(dgvPedido.Rows[e.RowIndex].Cells[0].Value.ToString());
                    List<PedidoProducto> pedidosproductos = PedidoProductoQueries.ConsultarPorPedido(con, idPedido, transaction);
                    // 4. Eliminar registros de pedido_productos con PedidoProductoQueries.EliminarProductos()
                    bool EliminarPedido = PedidoProductoQueries.EliminarProductos(pedidosproductos, con, transaction);
                    if (EliminarPedido == false)
                    {
                        transaction.Rollback();
                        con.Close();
                        return;
                    }
                    // 5. Eliminar pedido
                    cm = new SqlCommand("DELETE FROM pedido WHERE ID_pedido = '" + idPedido + "'", con, transaction);
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
            LoadPedido();
        }
    }
}
