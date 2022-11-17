using System.Data.SqlClient;
using system_ACXAJY.Entities;

namespace system_ACXAJY
{
    public partial class ProductForm : Form
    {
        private readonly SqlConnection con = new(@"Data Source=CMX-TST-3XA7HYU\SQLEXPRESS;Initial Catalog=System_ACXAJY;Integrated Security=True");
		private readonly List<Producto> _listaProducto = new();

        public ProductForm()
        {
            InitializeComponent();
            LoadProducto();
        }

        public void LoadProducto()
        {
            dgvProducts.Rows.Clear();

            con.Open();

            const string query = @"
				SELECT ID_producto, nombre_prod, desc_prod, cantidad_prod, precio_prod, ID_categoriaprod, nombre_categ
				FROM producto AS p
				INNER JOIN categoria ON ID_categoriaprod = ID_categoria";

            SqlCommand cm = new(query, con);

            try
            {
                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                {
					Producto producto = new()
					{
						IdProducto = Convert.ToInt32(dr[0].ToString()),
						NombreProducto = dr[1].ToString()!,
						DescripcionProducto = dr[2].ToString()!,
						CantidadProducto = Convert.ToInt32(dr[3].ToString()),
						PrecioProducto = float.Parse(dr[4].ToString()!),
						IdCategoria = Convert.ToInt32(dr[5].ToString())
					};

					string nombreCategoria = dr[6].ToString()!;

					// ID | Nombre | Categoría | Descripción | Cantidad | Precio
                    dgvProducts.Rows.Add(
						producto.IdProducto,
						producto.NombreProducto,
						producto.DescripcionProducto,
						nombreCategoria,
						producto.CantidadProducto,
						producto.PrecioProducto);

					_listaProducto.Add(producto);
                }

                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ModuloProduct productmodule = new();
            productmodule.btnSave.Enabled = true;
            productmodule.btnUpdate.Enabled = false;
            productmodule.ShowDialog();
            LoadProducto();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvProducts.Columns[e.ColumnIndex].Name;
            if (colName == "editar")
            {
				Producto producto = _listaProducto[e.RowIndex];

                ModuloProduct productmodule = new(producto);
                productmodule.btnSave.Enabled = false;
                productmodule.btnUpdate.Enabled = true;
                productmodule.ShowDialog();
            }
            else if (colName == "eliminar")
            {
                if (MessageBox.Show("¿Eliminar registro?", "Registro eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }

                con.Open();

                string query = $"DELETE FROM producto WHERE ID_producto LIKE '{dgvProducts.Rows[e.RowIndex].Cells[0].Value}'";
                SqlCommand cm = new SqlCommand(query, con);

                try
                {
                    cm.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                    return;
                }

                MessageBox.Show("Registro eliminado correctamente");
            }
            LoadProducto();
        }
    }
}
