using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class Usuarios
    {
        //Se crea una lista de forma estatica para que se pueda
        //Acceder desde cualquier lado del proyecto mismo
        public static List<Usuarios> ListaUsuarios { get; } = new List<Usuarios>();
        //Asignamos sus atributos de la clase
        private string nombre, apellido, nomUser, edad, pass,nivel;

        //Se crea las propiedades dentro del setter and getters
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string NomUser { get => nomUser; set => nomUser = value; }
        public string Edad { get => edad; set => edad = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Nivel { get => nivel; set => nivel = value; }


        //Constructor de la clase usuarios

        public Usuarios(string nombre, string apellido, string nomUser, string edad, string pass, string nivel)
        {
            //Se le asigna a cada atributo su valor que se le corresponda
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.NomUser = nomUser;
            this.Edad = edad;
            this.Pass = pass;
            this.Nivel = nivel;
        }


    }
}
