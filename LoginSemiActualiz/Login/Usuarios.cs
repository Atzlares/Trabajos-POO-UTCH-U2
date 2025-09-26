using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    internal class Usuarios
    {
        private string nombre, apellido, nomUser, edad, pass,nivel;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string NomUser { get => nomUser; set => nomUser = value; }
        public string Edad { get => edad; set => edad = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Nivel { get => nivel; set => nivel = value; }

        public Usuarios(string nombre, string apellido, string nomUser, string edad, string pass, string nivel)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.NomUser = nomUser;
            this.Edad = edad;
            this.Pass = pass;
            this.Nivel = nivel;
        }


    }
}
