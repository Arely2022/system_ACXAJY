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
    public partial class ModuloCatgoria : Form
    {
        SqlConnection con = new SqlConnection (@"Data Source=CMX-TST-3XA7HYU\SQLEXPRESS;Initial Catalog=System_ACXAJY;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        public ModuloCatgoria()
        {
            InitializeComponent();
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (MessageBox.Show("¿Guardar registro?", "Registro Guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO categoria(nombre_categ, desc_categ) VALUES(@nombre_categ, @desc_categ)", con);
                    cm.Parameters.AddWithValue("@nombre_categ", txtCName.Text);
                    cm.Parameters.AddWithValue("@desc_categ", txtCDesc.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Registro Guardado Correctamente");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void clear()
        {
            txtCName.Clear();
            txtCDesc.Clear();
           

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Actualizar registro?", "Actualizar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE categoria SET nombre_categ = @nombre_categ, desc_categ=@desc_categ WHERE ID_categoria LIKE '" +lblCID.Text+"'" , con);
                    cm.Parameters.AddWithValue("@ID_categoria", lblCID.Text);
                    cm.Parameters.AddWithValue("@nombre_categ", txtCName.Text);
                    cm.Parameters.AddWithValue("@desc_categ", txtCDesc.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Registro Actualizado Correctamente");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
    