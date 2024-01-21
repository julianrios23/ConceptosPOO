using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    internal class Punto
    {
        private int x;
        private int y;
        private static int contadorDeObjeto = 0;

        public Punto()
        {
            // Constructor por defecto, inicializa las coordenadas en (0, 0)
            x = 0;
            y = 0;
            contadorDeObjeto++;
        }

        public Punto(int x, int y)
        {
            // Constructor que permite inicializar las coordenadas con valores específicos
            this.x = x;
            this.y = y;
            contadorDeObjeto++;
        }

        public double DistanciaHasta(Punto otroPunto)
        {
            int xDif = this.x - otroPunto.x;
            int yDif = this.y - otroPunto.y;

            double distanciaPuntos = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));

            return distanciaPuntos;
        }
       
        public static void realizarTarea()
        {
            Punto origen = new Punto();
            Punto destino = new Punto(128, 80);
            Punto xx = new Punto();

            double distancia = origen.DistanciaHasta(destino);

             Console.WriteLine($"La distacian entre los puntos es: {distancia}");

            Console.WriteLine(Punto.contadorDeObjeto);

        }

        private static int ContadodorDeObjetos()
        {
            return contadorDeObjeto;
        }
    }
}
