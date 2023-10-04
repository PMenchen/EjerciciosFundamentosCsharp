using Pathfinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
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

        //Ejercicio 9
        public static string ejercicio9(string cadena)
        {
            char[] c = cadena.ToCharArray();
            Array.Reverse(c);

            return new string(c);
        }


        //Ejercicio 10
        public static bool ejercicio10(string str)
        {
            str = str.Replace(" ","").ToLower();
            char[] c1  = str.ToCharArray();
            char[] c2 = str.ToCharArray();

            Array.Reverse(c2);

            if (!(c1.SequenceEqual(c2))) return false;
            return true;
        }


        //Ejercicio 11
        public static int ejercicio11(string bin)
        {

            bool b = false;
            do
            {
                if (Utilidades.isNumber(bin))
                {
                    b = true;
                }
                else
                {
                    Console.WriteLine("\tLa cadena introducida no es válida\n\tIndique un numero binario a transformar al sistema decimal:");
                }
            } while (!b);

            try
            {
                return Convert.ToInt32(bin, 2);
            }
            catch (FormatException)
            {
                Console.WriteLine("Los parámetros introducidos no son válidos");
                throw;
            }

        }

        //Ejercicio 12
        public static int ejercicio12(string hex)
        {
            try
            {
                return Convert.ToInt32(hex, 16);
            }
            catch (FormatException)
            {
                Console.WriteLine("Los parámetros introducidos no son válidos");
                throw;
            }
        }


        public static double ejercicio13()
        {
            Console.WriteLine("Ejercicio 13\n\tIntroduce el número de estudiantes");
            int n = int.Parse(Console.ReadLine());
            int[] notas = new int[n];
            bool b = false;

            for (int i = 0; i < n; i++)
            {
                do
                {
                    Console.WriteLine("\tIntroduce la nota del estudiante {0}", i + 1);
                    if (int.TryParse(Console.ReadLine(), out int nota) && nota >= 0 && nota <= 100)
                    {
                        b = true;
                        notas[i] = nota;
                    }
                    else
                    {
                        Console.WriteLine("\tLa nota introducida no es válida, debe encontrarse entre 0 y 100");
                    }
                } while (!b);
                b= false;
            }
            int total = notas.Sum();

            double d = total / n;

            return d;

        }

        //Ejercicio 14
        public static string ejercicio14()
        {
            Console.WriteLine("Ejercicio 13\n\tIndique la cadena a transformar:");
            string s = Console.ReadLine();
            string aux = "";

            foreach (char c in s.ToUpper().ToCharArray())
            {
                aux += Convert.ToString((int) c, 2);
            }

            return aux;
        }

        //Ejercicio 15
        public static double ejercicio15()
        {
            Console.WriteLine("Ejercicio 15\n\tIndique el número de estudiantes");
            int n = int.Parse(Console.ReadLine());
            double[] notas = new double[n];
            bool b = false;

            for (int i = 0; i < n; i++)
            {
                do
                {
                    Console.WriteLine("\tIntroduce la nota del estudiante {0}", i + 1);
                    if (double.TryParse(Console.ReadLine(), out double nota) && nota >= 0 && nota <= 100)
                    {
                        b = true;
                        notas[i] = nota;
                    }
                    else
                    {
                        Console.WriteLine("\tLa nota introducida no es válida, debe encontrarse entre 0 y 100");
                    }
                } while (!b);
                b = false;
            }

            double average = notas.Average();

            double min = notas.Min();
            double max = notas.Max();   

            Console.WriteLine("\tLa media es: {0}\n\tEl mínimo es: {1}\n\tEl máximo es: {2}", average, min, max);

            double sum = notas.Sum(x => Math.Pow( x - average, 2));

            double deviation = Math.Sqrt((sum) / notas.Count());

            return deviation;
        }

        //Ejercicio 18
        public static void ejercicio18()
        {
            Console.WriteLine("Ejercicio 18\n\tIndique el ángulo al cual aplicar el seno y el coseno");
            double n = double.Parse(Console.ReadLine());

            Console.WriteLine($"\tEl seno de {n} es: {calcSin(n)}\n\tEl coseno de {n} es: {calcCos(n)}");
        }



        //Ejercicio 19
        public static void ejercicio19()
        {
            bool b = false;
            int aux = 1;
            int n = RandomNumber.random_Number(0, 99);
            Console.WriteLine(n);

            Console.WriteLine("Ejercicio 19\nIntenta adivinar el numero generado aleatoriamente entre 0 y 99");

            do
            {
                if (int.TryParse(Console.ReadLine(), out int pred) && pred >= 0 && pred < 100)
                {
                    if (pred == n)
                    {
                        b = true;
                    }
                    else
                    {
                        Console.WriteLine("Intenta {0}", (pred < n) ? "más alto" : "más bajo");
                    }
                    aux ++;
                }
                else
                {
                    Console.WriteLine("\tEl valor introducido no es válido, debe ser un número entre 0 y 99");
                }
            } while (!b);

            Console.WriteLine($"Lo has conseguido en {aux} intentos");
        }


        //Ejercicio 21 perfecto
        public static bool ejercicio21A()
        {
            bool b = false;
            Console.WriteLine("Ejercicio 21A\nIndique el número a comprobar si es entero: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                b = isPerfect(n);

            }
            else Console.WriteLine("El número ingresado no es válido.");

            return b;
        }

        //Ejercicio 21 deficiente
        public static bool ejercicio21B()
        {
            bool b = false;
            Console.WriteLine("Ejercicio 21B\nIndique el número a comprobar si es deficiente: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                b = isDeficient(n);

            }
            else Console.WriteLine("El número ingresado no es válido.");

            return b;
        }


        //Ejercicio 21 lista
        public static void ejercicio21C()
        {
            Console.Write("Ejercicio 21C\nIngresa un límite positivo: ");
            if (int.TryParse(Console.ReadLine(), out int limit) && limit > 0)
            {
                List<int> perfectNumbers = findPerfect(limit);
                List<int> nonDeficientNonPerfectNumbers = findNeitherDeficientPerfect(limit);

                string p = "", t = "";
                int aux = 1;

                Console.WriteLine("Estos son los números perfectos");
                for (int i = 0; i < perfectNumbers.Count(); i++)
                {
                    p += perfectNumbers[i] + " ";

                }
                Console.WriteLine(p);

                Console.WriteLine("Estos son los números que no son decifientes ni perfectos");
                for (int i = 0; i < nonDeficientNonPerfectNumbers.Count(); i++)
                {
                    if (aux == 10)
                    {
                        t += "\n";
                        aux = 0;
                    }
                    t += nonDeficientNonPerfectNumbers[i] + " ";
                    aux++;

                }
                Console.WriteLine(t);
            }
            else Console.WriteLine("El número ingresado no es válido.");
        }




        public static bool isPerfect(int n)
        {
            int sumaDivisores = 1;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    sumaDivisores += i;

                    if (i != n / i)
                    {
                        sumaDivisores += n / i;
                    }
                }
            }

            return sumaDivisores == n;
        }

        public static bool isDeficient(int n)
        {
            int sumaDivisores = 1;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    sumaDivisores += i;

                    if (i != n / i)
                    {
                        sumaDivisores += n / i;
                    }
                }
            }

            return sumaDivisores < n;
        }


        public static List<int> findPerfect(int limit)
        {
            List<int> perfect = new List<int>();
            for (int i = 2; i <= limit; i++)
            {
                if (isPerfect(i))
                {
                    perfect.Add(i);
                }
            }
            return perfect;
        }

        public static List<int> findNeitherDeficientPerfect(int limit)
        {
            List<int> neitherDeficientPerfect = new List<int>();
            for (int i = 2; i <= limit; i++)
            {
                if (!isPerfect(i) && !isDeficient(i))
                {
                    neitherDeficientPerfect.Add(i);
                }
            }
            return neitherDeficientPerfect;
        }






        static long calcSin(double x)
        {

            long seno = 0;
            for (int i = 0; i < 15; i++)
            {
                double aux = Math.Pow(-1, i) * Math.Pow(x, 2 * i + 1) / factorial(2 * i + 1);
                seno += (long)aux;
            }
            return seno;
            /*
            long sin = 0;
            int aux = 1;
            for (int i = 3; i <= 10; i = i+2)
            {
                Console.WriteLine(factorial(i));
                if (aux % 2 == 0)
                {
                    sin += (long) Math.Pow(x, i) / factorial(i);
                }
                else
                {
                    sin -= (long) Math.Pow(x, i) / factorial(i);
                }
                aux++;
            }
            return sin;
            */
        }

        static long calcCos(double x)
        {
            long coseno = 0;
            for (int n = 0; n < 15; n++)
            {
                double aux =Math.Pow(-1, n) * Math.Pow(x, 2 * n) / factorial(2 * n);
                coseno += (long)aux;
            }
            return coseno;
            /*
            long sin = 1;
            int aux = 0;
            for (int i = 2; i <= 10; i = i + 2)
            {
                if (aux % 2 == 0)
                {
                    sin += (long)Math.Pow(x, i) / factorial(i);
                }
                else
                {
                    sin -= (long)Math.Pow(x, i) / factorial(i);
                }
                aux++;
            }
            return sin;
            */
        }

        public static long factorial(int n)
        {
            if (n == 0 && n == 1) return 1;

            long r = 1;
            for (int i = 2; i <= n; i++)
            {
                r *= i;
            }

            return r;
        }






        public static bool validarBinario(string str)
        {
            bool b = false;
            foreach (char item in str.ToCharArray())
            {
                Console.WriteLine(item);
                //if ((int.Parse(item.ToString()) != 1) || (int.Parse(item.ToString()) != 0))
                if (!(Convert.ToInt32(item) == 1) && !(Convert.ToInt32(item) == 0))
                {
                    Console.WriteLine("\tEl numero introducido no es binario");
                    b = false;

                }else b = true;
            }

            return b;
        }




        public static bool isNumber(string str)
        {
            if (int.TryParse(str, out int n)) return true;
            return false;
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

        public static string leerConsola()
        {
            return Console.ReadLine();
        }

        public static double leerDoubleConsola()
        {
           return double.Parse(Console.ReadLine());
        }
    }
}
