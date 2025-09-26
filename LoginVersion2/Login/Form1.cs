using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
            if (Usuarios.ListaUsuarios.Count == 0)
            {
                //Predefinimos los datos para el inicio de sesion como admin atzl y usuario fritos
                Usuarios.ListaUsuarios.Add(new Usuarios("Axel", "Lares", "atzl", "24", "123", "admin"));
                Usuarios.ListaUsuarios.Add(new Usuarios("Jorge", "Lares", "fritos", "23", "123", "user"));
                Usuarios.ListaUsuarios.Add(new Usuarios("jose", "perez", "jperez", "20", "321", "admin"));
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Booleano para verificar si el usuario fue encontrado o no
            bool usuarioEncontrado = false;

            //El foreach hará que busque y recorra uno en uno hasta que las credenciales
            //Sean correctos
            foreach (var user in Usuarios.ListaUsuarios)
            {
                //Verificamos que el usuario y la contraseña sean las mismas para pasar filtro

                if (textBox1.Text == user.NomUser && textBox2.Text == user.Pass)
                {
                    //Pasamos al siguiente filtro donde se verificara el nivel de usuario
                    //Si es administrador o como usuario normal
                    usuarioEncontrado = true;
                    if (user.Nivel == "admin")
                    {
                        //Mostramos mensaje de bienvenida si es que se cumple
                        MessageBox.Show("Bienvenido como administrador: " + user.Nombre);
                        Registro registro = new Registro();
                        registro.Show();
                        this.Hide();
                    }
                    else
                    {
                        //En caso de que no sea administrador se redirigira a nueva ventana
                        //Para usuarios normales
                        if (user.Nivel == "user")
                        {
                            MessageBox.Show("Bienvenido como usuario: " + user.Nombre);
                            Detalles detalles = new Detalles(user);
                            detalles.Show();
                            this.Hide();
                        }
                        break;
                    }
                }
            }
            //Si el usuario no se encuentra se desplazara el siguiente mensaje de que
            //El usuario o contraseña son incorrectos+
            if (!usuarioEncontrado)
            {
                MessageBox.Show("Usuario o contraseña incorrecta");

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}
