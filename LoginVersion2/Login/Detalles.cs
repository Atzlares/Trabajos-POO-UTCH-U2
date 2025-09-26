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
    public partial class Detalles : Form
    {
        private Usuarios usuarioActual;
        public Detalles(Usuarios usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Detalles_Load(object sender, EventArgs e)
        {
            // Mostrar los detalles del usuario actual en los labels
            
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource= usuarioActual.Nombre;
            listBox1.DisplayMember = "Nombre";

            //listbox1.DataSource = Usuarios.ListaUsuarios;
            //listbox1.DisplayMember = "Nombre";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.DataSource= null;
            listBox1.DataSource = usuarioActual.Nombre;
            listBox1.DisplayMember = "Nombre";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Title = "Selecciona una imagen";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
