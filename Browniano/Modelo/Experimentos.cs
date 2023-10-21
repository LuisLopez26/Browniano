using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browniano.Modelo
{
    public class Experimentos
    {
        public int Id { get; set; }
        public int Posicion { get; set; }

        public List<double> CoordenadasFinales { get; set; }
        public double DistanciaFinal { get; set; }
        public List<double> CoordenadasMaximas { get; set; }
        public double DistanciaMaxima { get; set; }

        public Experimentos() { }

        public Experimentos(int id, int posicion, List<double> coordenadasFinales, double distanciaFinal, List<double> coordenadasMaximas, double distanciaMaxima)
        {
            Id = id;
            Posicion = posicion;
            CoordenadasFinales = coordenadasFinales;
            DistanciaFinal = distanciaFinal;
            CoordenadasMaximas = coordenadasMaximas;
            DistanciaMaxima = distanciaMaxima;
        }
    }
}
