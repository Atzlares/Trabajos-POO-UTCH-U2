using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro
{
    public partial class Form1 : Form
    {

        List<usuario> listaUsuarios = new List<usuario>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        //Nombre
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        //Apellido
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //Nombre de usuario
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        //Fecha
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        //Contraseña
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        //Botón de registro
        private void button1_Click(object sender, EventArgs e)
        {
            usuario user = new usuario(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            
            user.Nombre = textBox1.Text;
            user.Apellido = textBox2.Text;
            user.NomUser = textBox3.Text;
            user.FechaNa = textBox4.Text;
            user.Pss = textBox5.Text;
            listaUsuarios.Add(user);
            MessageBox.Show("Usuario registrado:\n\n" +
                "Nombre: " + user.getNombre() + "\n" +
                "Apellido: " + user.getApellido() + "\n" +
                "Nombre de usuario: " + user.getNomUser() + "\n" +
                "Fecha de nacimiento: " + user.getFechaNa() + "\n" +
                "Contraseña: " + user.getPss());
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();



        }

        private void listado_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //usuario user = new usuario(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);

            listado.DataSource = listaUsuarios;
            listado.DisplayMember = "NomUser";
            //listaUsuarios.Add(user);
            //listado.Items.Add("Nombre: " + user.getNombre());
            //listado.Items.Add("Apellido: " + user.getApellido());
            //listado.Items.Add("Nombre de usuario: " + user.getNomUser());
            //listado.Items.Add("Fecha de nacimiento: " + user.getFechaNa());
            //listado.Items.Add("Contraseña: " + user.getPss());
            //listado.Items.Add("------------------------------");
        }


        //Editar
        private void button4_Click(object sender, EventArgs e)
        {
            
        }


        //Eliminar
        private void button3_Click(object sender, EventArgs e)
        {
            listaUsuarios.RemoveAt(listaUsuarios.Count-1);
            listado.SelectedItems.Clear();
            listado.DataSource = null;
            listado.DataSource = listaUsuarios;
            listado.DisplayMember = "NomUser";
            MessageBox.Show("Usuario eliminado");
            


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Otra otra = new Otra();
            otra.Show();
            this.Hide();

        }

        //Cerrar programa
        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
