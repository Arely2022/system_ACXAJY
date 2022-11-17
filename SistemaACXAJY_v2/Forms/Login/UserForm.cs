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
    public partial class UserForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CMX-TST-3XA7HYU\SQLEXPRESS;Initial Catalog=System_ACXAJY;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public UserForm()
        {
            InitializeComponent();
            LoadUsuario();
        }
        public void LoadUsuario()
        {
            dgvUsuario.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM usuario", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {

                dgvUsuario.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
            con.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ModuloUser moduloUsuario = new ModuloUser();
            moduloUsuario.btnSave.Enabled = true;
            moduloUsuario.btnUpdate.Enabled = false;
            moduloUsuario.ShowDialog();
            LoadUsuario();
        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvUsuario.Columns[e.ColumnIndex].Name;
            if (colName == "editar")
            {
                ModuloUser moduloUsuario = new ModuloUser();
                moduloUsuario.lblUID.Text = dgvUsuario.Rows[e.RowIndex].Cells[0].Value.ToString();
                moduloUsuario.txtUName.Text = dgvUsuario.Rows[e.RowIndex].Cells[1].Value.ToString();
                moduloUsuario.txtUPass.Text = dgvUsuario.Rows[e.RowIndex].Cells[2].Value.ToString();

                moduloUsuario.btnSave.Enabled = false;
                moduloUsuario.btnUpdate.Enabled = true;
                moduloUsuario.ShowDialog();
            }
            else if (colName == "eliminar")
            {
                if (MessageBox.Show("¿Eliminar registro?", "Registro eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    cm = new SqlCommand("DELETE FROM usuario WHERE ID_usuario LIKE '" + dgvUsuario.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", con);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Registro eliminado correctamente");
                }
            }
            LoadUsuario();
        }
    }
}
