using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EjerciciosFundamentos
{
    internal class Utilidades
    {
        //Ejercicio 1
        public static bool ejercicio1(int mark)
        {
            if (!(mark >= 50)) return false;
            return true;
        }

        //Ejercicio 2
        public static bool ejercicio2(int number)
        {
            if (number % 2 == 0) return true;
            return false;
        }

        //Ejercicio 3
        public static (int, double) ejercicio3A(int start, int limit)
        {

            int sum = 0;
            for (int i = start; i <= limit; i++)
            {
                sum += i;
            }
            double prom = (double)sum / limit;

            return (sum, prom);
        }

        //Ejercicio 3.2
        public static (int, double) ejercicio3B(int start, int limit)
        {
            int sum = 0;

            while (start <= limit)
            {
                sum += start;
                start++;
            }

            double prom = (double)sum / limit;

            return (sum, prom);
        }

        //Ejercicio 3.3
        public static (int, double) ejercicio3C(int start, int limit)
        {
            int sum = 0;

            do
            {
                sum += start;
                start++;
            } while (start <= limit);

            double prom = (double)sum / limit;

            return (sum, prom);
        }

        //Ejercicio 3.4
        public static (int, double) ejercicio3D(int start, int limit)
        {
            int sum = 0, count = 0;

            for (int i = start; i <= limit; i++)
            {
                if (!(i % 2 == 0))
                {
                    sum += i;
                    count++;
                }
            }

            double prom = (double)sum / count;

            return (sum, prom);
        }

        //Ejercicio 3.5
        public static (int, double) ejercicio3E(int start, int limit)
        {
            int sum = 0, count = 0;

            for (int i = start; i <= limit; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                    count++;
                }
            }

            double prom = (double)sum / count;

            return (sum, prom);
        }

        //Ejercicio 3.6
        public static (double, double) ejercicio3F(int start, int limit)
        {
            double sum = 0;
            for (int i = start; i <= limit; i++)
            {
                sum += Math.Pow(i, 2);
            }
            double prom = (double)sum / limit;

            return (sum, prom);
        }

        //Ejercicio 4
        public static double ejercicio4(int limit)
        {
            double h1 = 0;

            for (int i = 1; i <= limit; i++)
            {
                h1 += (double)1 / i;
            }


            return h1;
        }
        public static double ejercicio4R(int limit)
        {
            double h2 = 0;

            for (int i = limit; i >= 1; i--)
            {
                h2 += (double)1 / i;
            }

            return h2;
        }

        //Ejercicio 5
        public static double ejercicio5(int rep)
        {

            double pi = 0, aux = 0;
            int n = 1;

            for (int i = 0; i < rep; i++)
            {
                if (i % 2 == 0)
                {
                    aux += (double)1 / n;
                }
                else
                {
                    aux -= (double)1 / n;
                }
                n = n + 2;
            }

            pi = 4 * aux;

            return pi;
        }

        //ejercicio 6
        public static int[] ejercicio6(int n)
        {
            int[] numbers = new int[n + 1];

            numbers[0] = 0;
            numbers[1] = 1;
            numbers[2] = 1;

            Enumerable.Range(3, n - 2).ToList().ForEach(i => numbers[i] = numbers[i - 1] + numbers[i - 2] + numbers[i - 3]);

            return numbers;
        }

        //Ejercicio 7
        public static void ejercicio7A()
        {
            string linea = "";
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    linea = linea + (i * j) + " ";
                }
                Console.WriteLine(linea + "\n");
                linea = "";
            }
        }

        //Ejercicio 8
        public static double[] ejercicio8(double radio)
        {
            double[] solution = new double[2];

            solution[0] = volumenEsfera(radio);
            solution[1] = areaEsfera(radio);

            return solution;

        }

        public static string leerArray(int[] numbers)
        {
            string linea = "";

            foreach (int n in numbers)
            {
                linea = linea + n + "\n\t";
            }
            return linea;
        }

        public static double volumenEsfera(double radio)
        {
            double v = (4 * Math.PI * Math.Pow(radio,3) / 3);
            return v;
        }

        public static double areaEsfera(double radio)
        {
            return 4 * Math.PI * Math.Pow(radio, 2);
        }

        public static double escribirDoubleConsola()
        {
           return double.Parse(Console.ReadLine());
        }
    }
}
