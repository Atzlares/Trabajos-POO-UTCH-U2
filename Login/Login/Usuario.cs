using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    internal class Usuario
    {
        private string nombre,apellido,nomUs,contra,edad,nivel;
        public Usuario(string nombre, string apellido, string nomUs, string contra, string edad, string nivel)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.NomUs = nomUs;
            this.Contra = contra;
            this.Edad = edad;
            this.Nivel = nivel;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string NomUs { get => nomUs; set => nomUs = value; }
        public string Contra { get => contra; set => contra = value; }
        public string Edad { get => edad; set => edad = value; }
        public string Nivel { get => nivel; set => nivel = value; }
    }
}
