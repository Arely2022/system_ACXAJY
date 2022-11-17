using SistemaACXAJY_v2.Entities;
using System.Data.SqlClient;
using system_ACXAJY.Entities;
using system_ACXAJY.Queries;

namespace system_ACXAJY
{
    public partial class ComprasForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CMX-TST-3XA7HYU\SQLEXPRESS;Initial Catalog=System_ACXAJY;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public ComprasForm()
        {
            InitializeComponent();
            LoadCompra();
        }

        public void LoadCompra()
        {
            dgvcompras.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM compra", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {

                dgvcompras.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ModuloCompras moduloCompras = new ModuloCompras();
            moduloCompras.btnSave.Enabled = true;
            moduloCompras.btnUpdate.Enabled = false;
            moduloCompras.ShowDialog();
            LoadCompra();
        }

        private void dgvcompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvcompras.Columns[e.ColumnIndex].Name;
            if (colName == "editar")
            {
                ModuloCompras moduloCompras = new ModuloCompras();
                Compra compra = new Compra();
                compra.Idcompra = Convert.ToInt32(dgvcompras.Rows[e.RowIndex].Cells[0].Value.ToString());
                compra.totalcompra = float.Parse(dgvcompras.Rows[e.RowIndex].Cells[1].Value.ToString());
                compra.FechaCompra = DateTime.Parse(dgvcompras.Rows[e.RowIndex].Cells[2].Value.ToString());


                moduloCompras.compra = compra;
                moduloCompras.LoadCompra();
                moduloCompras.btnSave.Enabled = false;
                moduloCompras.btnUpdate.Enabled = true;
                moduloCompras.ShowDialog();
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
                    int idcompra = Convert.ToInt32(dgvcompras.Rows[e.RowIndex].Cells[0].Value.ToString());
                    List<CompraMaterial> compraMaterials = CompraMaterialQueries.ConsultarPorCompra(con, idcompra, transaction);
                    // 4. Eliminar registros de pedido_productos con PedidoProductoQueries.EliminarProductos()
                    bool EliminarCompra = CompraMaterialQueries.EliminarMaterial(compraMaterials, con, transaction);
                    if (EliminarCompra == false)
                    {
                        transaction.Rollback();
                        con.Close();
                        return;
                    }
                    // 5. Eliminar pedido
                    cm = new SqlCommand("DELETE FROM compra WHERE ID_compra = '" + idcompra + "'", con, transaction);
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
            LoadCompra();
        }
    }
}
