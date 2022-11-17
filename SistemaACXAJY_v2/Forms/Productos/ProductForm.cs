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

namespace system_ACXAJY
{
    public partial class ProductForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CMX-TST-3XA7HYU\SQLEXPRESS;Initial Catalog=System_ACXAJY;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public ProductForm()
        {
            InitializeComponent();
            LoadProducto();
        } 
        
        public void LoadProducto()
        {
            dgvProducts.Rows.Clear();
            cm = new SqlCommand("SELECT ID_producto, nombre_prod, desc_prod,nombre_categ, cantidad_prod,precio_prod FROM producto INNER JOIN categoria ON ID_categoriaprod=ID_categoria", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {

                dgvProducts.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ModuloProduct productmodule = new ModuloProduct();
            productmodule.btnSave.Enabled = true;
            productmodule.btnUpdate.Enabled = false;
            productmodule.ShowDialog();
            LoadProducto ();
        }
        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvProducts.Columns[e.ColumnIndex].Name;
            if (colName == "editar")
            {
                ModuloProduct productmodule = new ModuloProduct();
                productmodule.lblPID.Text = dgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
                productmodule.txtPName.Text = dgvProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
                productmodule.txtPDesc.Text = dgvProducts.Rows[e.RowIndex].Cells[2].Value.ToString();
                productmodule.coBoxCateg.Text = dgvProducts.Rows[e.RowIndex].Cells[3].Value.ToString();
                productmodule.txtPCant.Text = dgvProducts.Rows[e.RowIndex].Cells[4].Value.ToString();
                productmodule.txtPPre.Text = dgvProducts.Rows[e.RowIndex].Cells[5].Value.ToString();
                

                productmodule.btnSave.Enabled = false;
                productmodule.btnUpdate.Enabled = true;
                productmodule.ShowDialog();
            }
            else if (colName == "eliminar")
            {
                if (MessageBox.Show("¿Eliminar registro?", "Registro eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    cm = new SqlCommand("DELETE FROM producto WHERE ID_producto LIKE '" + dgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", con);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Registro eliminado correctamente");
                }
            }
            LoadProducto();
        }
    }
}
