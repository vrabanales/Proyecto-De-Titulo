using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Process_SA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnUsuario.Enabled = false;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void controlBotones()
        {

            if (usuario.Text.Trim() != string.Empty && usuario.Text.All(Char.IsLetter))
            {
                usuario.Enabled = true;
                errorProvider1.SetError(usuario, "");

            }
            else
            {
                if (!(usuario.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(usuario, "El nombre solo debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(usuario, "Debe introducir su nombre");
                }
                btnUsuario.Enabled = false;
                usuario.Focus();


            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
