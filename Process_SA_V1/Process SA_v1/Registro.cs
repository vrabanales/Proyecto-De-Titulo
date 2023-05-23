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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnRegistrar.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void controlBotones()
        {

            if (nombre.Text.Trim() != string.Empty && nombre.Text.All(Char.IsLetter))
            {
                btnRegistrar.Enabled = true;
                errorProvider1.SetError(nombre, "");

            }
            else 
            {
                if (!(nombre.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(nombre, "El nombre solo debe contener letras");
                }
                else
                { 
                    errorProvider1.SetError(nombre, "Debe introducir su nombre");
                }
                btnRegistrar.Enabled = false;
                nombre.Focus();

            
            }
        }
        
        private void nombre_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void apellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
