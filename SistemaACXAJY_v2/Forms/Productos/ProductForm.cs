using System.Data.SqlClient;
using system_ACXAJY.Entities;

namespace system_ACXAJY
{
  public partial class ProductForm : Form
  {
    private readonly SqlConnection con = new(@"Data Source=CMX-TST-3XA7HYU\SQLEXPRESS;Initial Catalog=System_ACXAJY;Integrated Security=True");

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
				SELECT ID_producto, nombre_prod, desc_prod,nombre_categ, cantidad_prod,precio_prod
				FROM producto
				INNER JOIN categoria ON ID_categoriaprod = ID_categoria";

      SqlCommand cm = new(query, con);

      try
      {
        SqlDataReader dr = cm.ExecuteReader();

        while (dr.Read())
        {
          dgvProducts.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
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
      ModuloProduct productmodule = new(new Producto());
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
        DataGridViewRow dgvRow = dgvProducts.Rows[e.RowIndex];

        Producto producto = new()
        {
          IdProducto = Convert.ToInt32(dgvRow.Cells[0].Value.ToString()),
          NombreProducto = dgvRow.Cells[1].Value.ToString()!,
          DescripcionProducto = dgvRow.Cells[2].Value.ToString()!,
          IdCategoria = Convert.ToInt32(dgvRow.Cells[3].Value.ToString()),
          CantidadProducto = Convert.ToInt32(dgvRow.Cells[4].Value.ToString()),
          PrecioProducto = float.Parse(dgvRow.Cells[5].Value.ToString()!)
        };

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
