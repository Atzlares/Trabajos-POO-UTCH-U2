using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {

        List<Usuario> Usuario1 = new List<Usuario>();

        public Form1()
        {
            InitializeComponent();
            Usuario1.Add(new Usuario("Axel", "Lares", "atzl", "123", "19","admin"));
            Usuario1.Add(new Usuario("Jorge", "Lares", "fritos", "123", "19","user"));
            Usuario1.Add(new Usuario("Melany", "Lares", "atzl", "123", "19","user"));



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 3; i = i + 1)
            {
                if (textBox1.Text == Usuario1[i].NomUs && textBox2.Text == Usuario1[i].Contra)
                {
                    if (Usuario1[i].Nivel == "admin")
                    {
                        MessageBox.Show("Bienvenido admin " + Usuario1[i].Nombre);
                    }
                    else
                    {
                        MessageBox.Show("No eres bienvenido " + Usuario1[i].Nombre);
                    }
                        MessageBox.Show("Usuario correcto. Bienvenido: " + Usuario1[1].Nombre);
                    


                }
                else
                {
                    MessageBox.Show("Credenciales incorrecta");
                }

            }
                
            }
        

        private void button2_Click(object sender, EventArgs e)
        {

            Registro registro = new Registro();
            registro.Show();
            this.Hide();

        }
    }
}
