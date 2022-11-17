using SistemaACXAJY_v2.Entities;
using System.Data.SqlClient;
using system_ACXAJY.Queries;

namespace system_ACXAJY
{
    public partial class ComprasForm : Form
    {
        private readonly SqlConnection con = new(@"Data Source=CMX-TST-3XA7HYU\SQLEXPRESS;Initial Catalog=System_ACXAJY;Integrated Security=True");
        private readonly List<Compra> _compras = new();

        public ComprasForm()
        {
            InitializeComponent();
            LoadCompra();
        }

        public void LoadCompra()
        {
            dgvcompras.Rows.Clear();

            SqlCommand cm = new("SELECT * FROM compra", con);
            SqlDataReader? dr = null;

            try {
                con.Open();
                dr = cm.ExecuteReader();

                float total = 0;
                while (dr.Read())
                {
                    Compra compra = new()
                    {
                        Idcompra = Convert.ToInt32(dr[0]),
                        totalcompra = float.Parse(dr[1].ToString()!),
                        FechaCompra = Convert.ToDateTime(dr[2]),
                    };

                    total += compra.totalcompra;

                    _compras.Add(compra);

                    dgvcompras.Rows.Add(
                        compra.Idcompra,
                        compra.totalcompra,
                        compra.FechaCompra);
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
            ModuloCompras moduloCompras = new();
            moduloCompras.btnSave.Enabled = true;
            moduloCompras.btnUpdate.Enabled = false;
            moduloCompras.ShowDialog();
            LoadCompra();
        }

        private void dgvcompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvcompras.Columns[e.ColumnIndex].Name;
            Compra compra = _compras[e.RowIndex];

            if (colName == "editar")
            {
                ModuloCompras moduloCompras = new(compra);
                moduloCompras.btnSave.Enabled = false;
                moduloCompras.btnUpdate.Enabled = true;
                moduloCompras.ShowDialog();
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
                List<CompraMaterial> compraMateriales = CompraMaterialQueries.ConsultarPorCompra(con, compra.Idcompra, transaction);

                // Eliminar los materiales
                bool materialesEliminados = CompraMaterialQueries.EliminarMaterial(compraMateriales, con, transaction);
                if (!materialesEliminados)
                {
                    transaction.Rollback();
                    con.Close();
                    return;
                }

                // Eliminar compra
                SqlCommand cm = new($"DELETE FROM compra WHERE ID_compra = '{compra.Idcompra}'", con, transaction);
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

            LoadCompra();
        }
    }
}
