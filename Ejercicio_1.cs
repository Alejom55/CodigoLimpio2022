/*En un curso se practican 4
evaluaciones con los siguientes
porcentajes: 25 %, 20 %, 25 % y 30 %,
respectivamente.Por cada estudiante
se informa código y las cuatro notas.
Hacer un algoritmo que calcule la
nota definitiva de cada estudiante, el
promedio de notas definitivas del
curso y el porcentaje de perdedores.*/
 

int estudiantes;
Console.WriteLine("Ingrese la cantidad de estudiantes");
estudiantes = Convert.ToInt16(Console.ReadLine());

//Nota 1 25%, Nota 2 20%, Nota 3 25%, Nota 4 30%
int nota1, nota2, nota3, nota4;
double definitiva, promedioNotas, notas = 0, perdedores = 0, porPerdedores;
for (int i = 1; i <= estudiantes; i++)
{
    Console.WriteLine("Ingrese la nota 1 del 25% del estudiante " + i);
    nota1 = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Ingrese la nota 2 del 20% del estudiante " + i);
    nota2 = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Ingrese la nota 3 del 25% del estudiante " + i);
    nota3 = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Ingrese la nota 4 del 30% del estudiante " + i);
    nota4 = Convert.ToInt16(Console.ReadLine());

    definitiva = nota1 * 0.25 + nota2 * 0.20 + nota3 * 0.25 + nota4 * 0.30;
    Console.WriteLine("La definitiva del estudiante " + i + " es " + definitiva);
    notas = notas + definitiva;
    
    if (definitiva < 3)
    {
        perdedores = perdedores + 1;

    }
}
porPerdedores = (perdedores * 100) / estudiantes;
Console.WriteLine("El porcentaje de perdedores es del %" + porPerdedores);
promedioNotas = notas / estudiantes;
Console.WriteLine("El promedio de las notas es de " + promedioNotas);

