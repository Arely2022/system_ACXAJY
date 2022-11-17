using System;
using System.Windows.Forms;

namespace system_ACXAJY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked == false)
                txtPass.UseSystemPasswordChar = true;
            else
                txtPass.UseSystemPasswordChar = false;
        }


        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cerrar Aplicación", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPass.Clear();
        }
    }
}
