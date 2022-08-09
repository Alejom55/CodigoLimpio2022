using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Persona
    {
        private string nombre, identificacion;
        private int edad;

        public Persona(string nombre, string identificacion, int edad)
        {
            this.nombre = nombre;
            this.identificacion = identificacion;
            this.edad = edad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Identificacion { get => identificacion; set => identificacion = value; }
        public int Edad { get => edad; set => edad = value; }

        void mostrar()
        {
            Console.WriteLine("nombre: " + nombre + " Id: " + identificacion + " edad: " + edad);
        }
        bool esMayorDeEdad()
        {
            return edad >= 18;

   
        }
        static void Main()
        {
            Persona Felipe = new Persona("Felipe", "100", 19);
            Felipe.mostrar();
            Console.WriteLine(Felipe.esMayorDeEdad());
        }
    }
}
