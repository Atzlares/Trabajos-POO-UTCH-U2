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
        List<Usuarios> Usuario1 = new List<Usuarios>();
        public Form1()
        {
            InitializeComponent();
            Usuario1.Add(new Usuarios("Axel", "Lares", "atzl", "24", "123", "admin"));
            Usuario1.Add(new Usuarios("Jorge", "Lares", "fritos", "23", "123", "user"));
            Usuario1.Add(new Usuarios("jose","perez","jperez","20","321","admin"));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < 3; i=i+1)
            {
                if (textBox1.Text == Usuario1[i].NomUser && textBox2.Text == Usuario1[i].Pass)
                {
                    if (Usuario1[i].Nivel == "admin")
                    {
                        MessageBox.Show("Bienvenido como administrador: " + Usuario1[i].Nombre);
                        Registro registro = new Registro();
                        registro.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Bienvenido a tu perfil " + Usuario1[i].Nombre);
                        Detalles detalles = new Detalles();
                        detalles.Show();
                        this.Hide();
                    }
                    
                }else
                {
                    //MessageBox.Show("Usuario o contraseña incorrecta");
                    
                }

                //Console.WriteLine(Usuario1[i].NomUser);
            }
            //MessageBox.Show("Usuario o contraseña incorrecta");




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // Registro registro = new Registro();
            //registro.Show();
            //this.Hide();

        }
    }
}
