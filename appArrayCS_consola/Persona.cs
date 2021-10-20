using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace appArrayCS_consola
{
    class Persona
    {
        private string nombre;
        private string apellidos;
        private DateTime? fechaNacimiento;
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }


        public DateTime FechaNacimiento
        {
            get { return FechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Persona()
        {
            nombre = "";
            apellidos = "";
            fechaNacimiento = null;
        }
        public Persona(string nombre, string apellidos, DateTime? fechaNacimiento)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNacimiento = fechaNacimiento;
        }
        public override string ToString()
        {
            return nombre + " " + apellidos + " - " + fechaNacimiento;
        }

    }
 }
   

