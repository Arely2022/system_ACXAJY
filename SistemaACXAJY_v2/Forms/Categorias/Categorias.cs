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
    public partial class Categorias : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CMX-TST-3XA7HYU\SQLEXPRESS;Initial Catalog=System_ACXAJY;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public Categorias()
        {
            InitializeComponent();
            LoadCategoria();
        }

        public void LoadCategoria()
        {
            dgvCategorias.Rows.Clear();
            cm = new SqlCommand("SELECT ID_categoria, nombre_categ, desc_categ FROM categoria", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                
                dgvCategorias.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           ModuloCatgoria moduloCatgoria=new ModuloCatgoria();
            moduloCatgoria.btnSave.Enabled = true;
            moduloCatgoria.btnUpdate.Enabled = false;
            moduloCatgoria.ShowDialog();
            LoadCategoria();
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCategorias.Columns[e.ColumnIndex].Name;
            if (colName == "editar")
            {
                ModuloCatgoria moduloCateg = new ModuloCatgoria();
                moduloCateg.lblCID.Text = dgvCategorias.Rows[e.RowIndex].Cells[0].Value.ToString();
                moduloCateg.txtCName.Text = dgvCategorias.Rows[e.RowIndex].Cells[1].Value.ToString();
                moduloCateg.txtCDesc.Text = dgvCategorias.Rows[e.RowIndex].Cells[2].Value.ToString();

                moduloCateg.btnSave.Enabled = false;
                moduloCateg.btnUpdate.Enabled = true;
                moduloCateg.ShowDialog();
            }
            else if (colName == "eliminar")
            {
                if(MessageBox.Show("¿Eliminar registro?", "Registro eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                    cm = new SqlCommand("DELETE FROM categoria WHERE ID_categoria LIKE '" + dgvCategorias.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", con);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Registro eliminado correctamente");
                }
            }
            LoadCategoria();
        }
    }
}
