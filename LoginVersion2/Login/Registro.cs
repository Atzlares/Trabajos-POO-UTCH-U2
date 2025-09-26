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
        //En la practica anterior se hace uso de lista de usaurios pero en este caso lo quité

        //List<Usuarios> listaUsuarios = new List<Usuarios>();
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

            //Instanciamos la clase de los usuarios con sus respectivos datos y sus respectivos
            //Textboxes
            Usuarios usuarios = new Usuarios(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
            Usuarios.ListaUsuarios.Add(usuarios);

            //Asignamos el dato usuarios a cada caja de texto
            usuarios.Nombre = textBox1.Text;
            usuarios.Apellido = textBox2.Text;
            usuarios.NomUser = textBox3.Text;
            usuarios.Edad = textBox4.Text;
            usuarios.Pass = textBox5.Text;
            usuarios.Nivel = textBox6.Text;

            //Mostramos mensaje de registro exitoso
            MessageBox.Show("Usuario registrado con exito");



        }


        //Boton para volver al menu principal (login)
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        //Caja de texto para mostrar los usuarios tanto registrados por predefinidos
        //Y los usuarios que se vayan registrando dentro del mismo form
        private void listbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listbox1.DataSource = null;
            listbox1.DataSource = Usuarios.ListaUsuarios;
            listbox1.DisplayMember = "Nombre";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Se agregó el boton para actualizar la lista de usuarios en el listbox
            listbox1.DataSource = null;
            listbox1.DataSource = Usuarios.ListaUsuarios;
            listbox1.DisplayMember = "Nombre";
        }
    }
}
