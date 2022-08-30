using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejerciocio_lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> empleos = new List<string>
            {
                "Empleado civil",
                "Empleado sistemas",
                "Empleado financiera",
                "Empleado Diseño"
            };

            List<Empleado> listaEmpleados = new List<Empleado>(){ 
            
                new Empleado("01", "Pedro", "Cid", empleos[0],500000,new DateTime(1990,8,20)),
                new Empleado("02", "Camilo", "Alcalde", empleos[2],800000,new DateTime(2000,10,02)),
                new Empleado("03", "Irune", "Merino", empleos[1],900000,new DateTime(1998,08,02)),
                new Empleado("04", "Gerard", "Balaguer", empleos[1],1000000,new DateTime(1980,02,23)),
                new Empleado("05", "Luciano", "Valls", empleos[3],800000,new DateTime(1985,05,05)),
                new Empleado("06", "Angelina", "Redondo", empleos[2],895000,new DateTime(2001,10,27))
            };
            var salario = listaEmpleados.Where(salario => salario.Salario >= 900000).OrderBy(salario => salario.Salario).ToList();

            Console.WriteLine("\nConsulta usando expresiones lambda:");
            foreach (string nombre in salario)
            {
                Console.WriteLine("\tResultado: {0}.", nombre);
            }

        }
    }
}
