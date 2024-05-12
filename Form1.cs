using Clase___04_05_2024.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase___04_05_2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
           // MessageBox.Show($"Bienvenido a mi App");

        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            /*comboBoxFaculdad.Items.Add("Ingeniería");
            comboBoxFaculdad.Items.Add("Medicina");
            comboBoxFaculdad.Items.Add("Derecho");

            labelTitulo.Text = "Facultades Cargadas";*/
        }

        private void comboBoxFaculdad_SelectedValueChanged(object sender, EventArgs e)
        {
           // MessageBox.Show(comboBoxFaculdad.SelectedItem+"");
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            FrmRegistro frmRegi = new FrmRegistro();
            frmRegi.Show();
        }
       
        int ii = 0;
        private void button1_Click_1(object sender, EventArgs e)
        {
            String usr = textBoxUsuario.Text.ToLower();
            String pwd = textBoxContrasena.Text.ToLower();
            ii++;
            if (ii <3)
            {
                if (usr == null || pwd == null)
                {
                    textBoxContrasena.Text = "";
                    textBoxUsuario.Text = "";

                    MessageBox.Show("No puede dejar un campo en blanco");

                }
                else
                {
                    if (usr.Equals("hola") && pwd.Equals("mundo"))
                    {
                        FrmRegistro registro = new FrmRegistro();
                        textBoxContrasena.Text = "";
                        textBoxUsuario.Text = "";

                        registro.Show();
                    }
                    else
                    {
                        textBoxContrasena.Text = "";
                        textBoxUsuario.Text = "";

                        MessageBox.Show("Usuario y Contraseña Erroneos");
                    }
                }

            }
            else
            {
                button1.Enabled = false;
                MessageBox.Show("Usuario y Contraseña Erroneos.\nYa no tienes más intentos");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
