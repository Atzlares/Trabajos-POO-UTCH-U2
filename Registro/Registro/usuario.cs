using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro
{
    internal class usuario
    {
        private string nombre,apellido,nomUser,fechaNa,pss;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string NomUser { get => nomUser; set => nomUser = value; }
        public string FechaNa { get => fechaNa; set => fechaNa = value; }
        public string Pss { get => pss; set => pss = value; }

        public usuario(string nombre, string apellido, string nomUser, string fechaNa, string pss)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nomUser = nomUser;
            this.fechaNa = fechaNa;
            this.pss = pss;
        }

        //Getters and Setters
        //Getters
        public string getNombre() 
        { 
            return nombre; 
        }
        public string getApellido() 
        { 
            return apellido; 
        }
        public string getNomUser() 
        { 
            return nomUser; 
        }
        public string getFechaNa() 
        { 
            return fechaNa; 
        }
        public string getPss() 
        { 
            return pss; 
        }


        //Setters
        public void setNomUser(string nomUser)
        {
            this.nomUser = nomUser;
        }
        public void setNombre(string nombre) 
        { 
            this.nombre = nombre; 
        }
        public void setApellido(string apellido) 
        { 
            this.apellido = apellido; 
        }
        public void setFechaNa(string fechaNa)
        {
            this.fechaNa = fechaNa;
        }
        public void setPss(string pss)
        {
            this.pss = pss;
        }

    }
}
