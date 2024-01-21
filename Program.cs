using ConceptosPOO;
using static System.Math;
using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        //Punto.realizarTarea();

        //double raiz = Sqrt(9);
        //double potencia = Pow(3, 4);

        //WriteLine(raiz);
        //WriteLine(potencia);

        var miVariable = new { Nombre = "Julian", edad = 48 };
        WriteLine(miVariable.Nombre+","+miVariable.edad);

        var xx = new { nombre = "ana", edad = "25" };
        WriteLine(xx.edad + xx.nombre);
    }

   
}


