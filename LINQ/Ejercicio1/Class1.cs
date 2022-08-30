using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerciocio_lambda
{
    internal class Empleado
    {
        private string identificacion, nombre, epellidos, areaTrabajo ;
        private int salario;
        private DateTime fechaNacimiento;
       

        public Empleado(string identificacion, string nombre, string epellidos, string areaTrabajo, int salario, DateTime fechaNacimiento)
        {
            this.identificacion = identificacion;
            this.nombre = nombre;
            this.epellidos = epellidos;
            this.areaTrabajo = areaTrabajo;
            this.salario = salario;
            this.fechaNacimiento = fechaNacimiento;
        }

        public string Identificacion { get => identificacion; set => identificacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Epellidos { get => epellidos; set => epellidos = value; }
        public string AreaTrabajo { get => areaTrabajo; set => areaTrabajo = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Salario { get => salario; set => salario = value; }

    }
}
