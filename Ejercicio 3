using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Estudiante
    {
        private string nombre, identificacion;
        private string estrato;
        private double valorMatricula;
        private double valorEstrato1 = 500000, valorEstrato2 = 800000;
        private double valorEstrato3 = 1800000, valorEstrato4 = 3000000;
        private double valorEstrato5 = 3700000, valorEstrato6 = 4300000;

        public Estudiante(string nombre, string identificacion, string estrato)
        {
            this.nombre = nombre;
            this.identificacion = identificacion;
            this.estrato = estrato;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Identificacion { get => identificacion; set => identificacion = value; }
        public string Estrato { get => estrato; set => estrato = value; }
        public double ValorMatricula { get => valorMatricula; }

        void valorPagarMatricula()
        {
            if (estrato == "1")
            {
                valorMatricula = valorEstrato1;
                
            }
            else if (estrato == "2")
            {
                valorMatricula = valorEstrato2;
                
            }
            else if (estrato == "3")
            {
                valorMatricula = valorEstrato3;
                
            }
            else if (estrato == "4")
            {
                valorMatricula = valorEstrato4;
                
            }
            else if (estrato == "5")
            {
                valorMatricula = valorEstrato5;

            }
            else if (estrato == "6")
            {
                valorMatricula = valorEstrato6;
    
            }
        }
        static void Main()
        {
            Estudiante Juan = new Estudiante("Juan", "500", "2");
            Juan.valorPagarMatricula();
            Console.WriteLine(Juan.valorMatricula);
        }
    }
}
