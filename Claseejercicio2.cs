using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Claseejercicio2
    {
       private string[] paises;
       private int[,] temperaturas;
        private int[] promedio;

        public void Insertar()
        {
            paises = new string[4];
            temperaturas = new int[4, 3];
            for(int f =0;f<paises.Length;f++ )
            {
                Console.Write("Ingrese el nombre del país: ");
                paises[f] = Console.ReadLine();
                for (int c = 0; c < temperaturas.GetLength(1); c++)
                {
                    Console.Write("Ingrese las temperaturas: ");
                    string linea;
                    linea = Console.ReadLine();
                    temperaturas[f, c] = int.Parse(linea);
                }
            }

        }

        public void calcularPromedio()
        {
            promedio = new int[4];
            for (int f = 0; f < temperaturas.GetLength(0); f++)
            {
                int suma = 0;
                for (int c = 0; c < temperaturas.GetLength(1); c++)
                {
                    suma = (suma + temperaturas[f, c]) /3;
                  
                }
                promedio[f] = suma;
            }
        }



        public void Imprimir()
        {
            Console.WriteLine("El promedio de temperartura en los tres paises es de : ");
            for (int f = 0 ; f < promedio.Length; f++)
            {
                Console.WriteLine(paises[f]+" - "+ promedio[f]);
            }
        }

        public void Mayor()
        {
            int mayor = promedio[0];
            string nom = paises[0];
            for(int f = 0; f<promedio.Length; f++)
            {
                if (promedio[f] > mayor)
                {
                    mayor = promedio[f];
                    nom = paises[f];
                }
            }
            Console.WriteLine("El país con mayor temperatura promedio es " + nom + " que posee una temperatura de " + mayor);
        }

    }
}
