int numeroLiga;
int id;
string nombre;
int titulosGanados;
int liga1 = 0;
int liga2 = 0;
int liga3 = 0;


Console.WriteLine("Ingrese la cantidad de atletas");
int cantidadAtletas = Convert.ToInt32(Console.ReadLine());

string guardarNombre = "";
string guardarLiga = "";
int mayorCantidadTitulos = 0;
int sinTitulos = 0;

for (int i = 0; i < cantidadAtletas; i++)
{
    
    Console.WriteLine("Atleta #" + (i + 1));
    Console.WriteLine("Ingrese el id del atleta");
    id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el nombre del atleta");
    nombre = Console.ReadLine();
    Console.WriteLine("Ingrese la liga que pertenece (1, 2 o 3)");
    numeroLiga = Convert.ToInt16(Console.ReadLine());
    if (numeroLiga == 1)
    {
        liga1++;
        guardarLiga = "liga1";
    }
    else if (numeroLiga == 2)
    {
        liga2++;
        guardarLiga = "liga2";
    }
    else
    {
        liga3++;
        guardarLiga = "liga3";
    }
    Console.WriteLine("Ingrese la cantidad de titulos obtenidos");
    titulosGanados = Convert.ToInt16(Console.ReadLine());
    if (titulosGanados == 0)
    {
        sinTitulos++;
    }
    else if (titulosGanados > mayorCantidadTitulos)
    {
        mayorCantidadTitulos = titulosGanados;
        guardarNombre = nombre;
    } 

}
//Punto a)
if (liga1 >liga2 && liga1 > liga3)
{
    Console.WriteLine("La liga con la mayor cantidad de atletas es liga 1");
}else if(liga2 > liga3)
{
    Console.WriteLine("La liga con la mayor cantidad de atletas es liga 2");
}
else
{
    Console.WriteLine("La liga con la mayor cantidad de atletas es liga 3");
}

//Punto b)
Console.WriteLine("EL nombre del deportista con la mayor cantidad de titulos es "+ guardarNombre + " de la liga " + guardarLiga);

//punto c)
Console.WriteLine("La cantidad de atletas que no tienen titulos es " + sinTitulos);
