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
    public partial class Registro : Form
    {
        List<Usuarios> listaUsuarios = new List<Usuarios>();
        public Registro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        //Boton para registrar usuario
        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text,textBox6.Text);
            usuarios.Nombre = textBox1.Text;
            usuarios.Apellido = textBox2.Text;
            usuarios.NomUser = textBox3.Text;
            usuarios.Edad = textBox4.Text;
            usuarios.Pass = textBox5.Text;
            usuarios.Nivel = textBox6.Text;
            listaUsuarios.Add(usuarios);
            MessageBox.Show("Usuario registrado con exito");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
