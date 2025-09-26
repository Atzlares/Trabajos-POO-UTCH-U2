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
        List<Usuarios> listaUsuarios = new List<Usuarios>();
        public Detalles()
        {
            InitializeComponent();
        }

        private void cajaDeLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Usuarios usuarios = (Usuarios)cajaDeLista.SelectedItem;
            cajaDeLista.DataSource = listaUsuarios;
            cajaDeLista.DisplayMember = "Nombre";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            cajaDeLista.DataSource = listaUsuarios;
            //cajaDeLista.DisplayMember = "Nombre";
            
        }
    }
}
