using Browniano.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browniano.Algoritmos
{
    public class AlgoritmoGenerador
    {
        public List<Experimentos> lista = new List<Experimentos>();

        public List<Experimentos> AlgoritmoBrowniano(int dimension, int pasos, int experimentos)
        {
            List<Experimentos> listaSalida = new List<Experimentos>();

            Random random = new Random();

            double probabilidad = 0.5;

            for (int i = 0; i < experimentos; i++)
            {
                listaSalida.Add(new Experimentos());
                listaSalida[i].Id = i;
                listaSalida[i].Posicion = i;

                if (dimension == 1)
                {
                    listaSalida[i].CoordenadasFinales = new List<double> { 0.0 };
                    listaSalida[i].DistanciaMaxima = 0;


                    for (int j = 0; j < pasos; j++)
                    {
                        double direccion = (random.NextDouble() < probabilidad) ? 1.0 : -1.0;
                        listaSalida[i].CoordenadasFinales[0] += direccion;

                        double distanciaActual = Math.Abs(listaSalida[i].CoordenadasFinales[0]);

                        if (listaSalida[i].DistanciaMaxima < distanciaActual)
                        {
                           
                            listaSalida[i].CoordenadasMaximas = new List<double>(listaSalida[i].CoordenadasFinales);
                            listaSalida[i].DistanciaMaxima = distanciaActual;
                        }
                    }

                    
                    listaSalida[i].DistanciaFinal = Math.Abs(listaSalida[i].CoordenadasFinales[0]);
                    
                }

                if (dimension == 2)
                {
                    listaSalida[i].CoordenadasFinales = new List<double> { 0.0, 0.0 };
                    listaSalida[i].DistanciaMaxima = 0;

                    for (int j = 0; j < pasos; j++)
                    {
                        double direccionX = (random.NextDouble() < probabilidad) ? 1.0 : -1.0;
                        double direccionY = (random.NextDouble() < probabilidad) ? 1.0 : -1.0;
                        listaSalida[i].CoordenadasFinales[0] += direccionX;
                        listaSalida[i].CoordenadasFinales[1] += direccionY;

                        double distanciaActual = Math.Sqrt(Math.Pow(listaSalida[i].CoordenadasFinales[0], 2)
                            + Math.Pow(listaSalida[i].CoordenadasFinales[1], 2));


                        if (listaSalida[i].DistanciaMaxima < distanciaActual)
                        {

                            listaSalida[i].CoordenadasMaximas = new List<double>(listaSalida[i].CoordenadasFinales);
                            listaSalida[i].DistanciaMaxima = distanciaActual;
                        }

                    }

                    listaSalida[i].DistanciaFinal = Math.Sqrt(Math.Pow(listaSalida[i].CoordenadasFinales[0], 2)
                            + Math.Pow(listaSalida[i].CoordenadasFinales[1], 2));

                }
            }

            return listaSalida;
        }

        public double CalcularPromedioDistanciaMaxima(List<Experimentos> lista)
        {
            if (lista.Count == 0)
            {
                return 0; // O manejar el caso de una lista vacía según tus necesidades
            }

            double sumaDistanciaMaxima = 0;

            foreach (var experimento in lista)
            {
                sumaDistanciaMaxima += experimento.DistanciaMaxima;
            }

            // Calcular el promedio dividiendo la suma total entre el número de elementos
            double promedio = sumaDistanciaMaxima / lista.Count;

            return promedio;
        }
    }
}
