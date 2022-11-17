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
    public partial class ModuloUser : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=CMX-TST-3XA7HYU\SQLEXPRESS;Initial Catalog=System_ACXAJY;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        public ModuloUser()
        {
            InitializeComponent();
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void clear()
        {
            txtUName.Clear();
            txtUPass.Clear();

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
                    cm = new SqlCommand("UPDATE usuario SET usuario_u = @usuario_u, pass_u=@pass_u WHERE ID_usuario LIKE '" + lblUID.Text + "'", con);
                    cm.Parameters.AddWithValue("@ID_usuario", lblUID.Text);
                    cm.Parameters.AddWithValue("@usuario_u", txtUName.Text);
                    cm.Parameters.AddWithValue("@pass_u", txtUPass.Text);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("¿Guardar registro?", "Registro Guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO usuario(usuario_u, pass_u) VALUES(@usuario_u, @pass_u)", con);
                    cm.Parameters.AddWithValue("@usuario_u", txtUName.Text);
                    cm.Parameters.AddWithValue("@pass_u", txtUPass.Text);
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

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked == false)
                txtUPass.UseSystemPasswordChar = true;
            else
                txtUPass.UseSystemPasswordChar = false;
        }
    }
}
