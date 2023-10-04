using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EjerciciosFundamentos
{
    public class PrintPatterns
    {
        public static void patternA()
        {
            string s = "";

            for (int i = 0; i < 8; i++)
            {
                s += "#";
                //for(int j = 0; j < 8; j++) { }
                
                Console.WriteLine(s);
            }
            Console.WriteLine("\n\n");
        }

        public static void patternB()
        {
            string s = "";
            int aux = 8;

            for (int i = 0; i < 8; i++)
            {
                
                for (int j = 0; j < aux; j++) 
                {
                    s += "#";
                }
                Console.WriteLine(s);
                aux--;
                s = "";

            }
            Console.WriteLine("\n\n");
        }

        public static void patternC()
        {
            int n = 8;
            string s = new string('#', n);
            string spaces = string.Empty;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(spaces + s);
                spaces += ' ';
                s = s.Substring(1);
            }


            Console.WriteLine("\n\n");
        }

        public static void patternD()
        {

            int val = 8;
            int i, j, k;
            for (i = 1; i <= val; i++)
            {
                for (j = 1; j <= val - i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("\n\n");
        }

        public static void patternE()
        {
            int n = 8;

            for (int i = 0; i <= n; i++)
            {
                if (i == 0 || i == 7)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }
                if (i >= 1 && i <= 5)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (j == 0 || j == 7)
                        {
                            Console.Write("#");
                        }
                        else if (j >= 1 && j <= 6)
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("\n\n");

        }

        public static void patternF()
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (i == 0 || i == 6 || i == j)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\n\n");
        }

        public static void patternG()
        {
            for (int x = 0; x < 7; x++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (x == 0 || x == 6 || j == 6 - x)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\n\n");
        }
            
        public static void patternH()
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (i == 0 || i == 6 || i == j || j == 6 - i)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\n\n");
        }

        public static void patternI()
        {

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (i == 0 || i == 6 || i == j || j == 6 - i || j == 0 || j == 6)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\n\n");
        }

        public static void patternJ()
        {
            for (int x = 0; x < 6; x++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 11 - (2 * x); j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\n\n");
        }

        public static void patternK()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6 - 1 - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < ((i + 1) * 2) - 1; j++)
                {
                    Console.Write("#");
                }

                Console.WriteLine("");
            }
            Console.WriteLine("\n\n");
        }

        public static void patternL()
        {
            for(int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6 - 1 - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < ((i + 1) * 2) - 1; j++)
                {
                    Console.Write("#");
                }

                Console.WriteLine("");
            }
            for (int x = 0; x < 6; x++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 11 - (2 * x); j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\n\n");
        }
        public static void patternM()
        {
            int aux = 1;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 1; j <= aux; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
                aux++;
            }
            Console.WriteLine("\n\n");
        }
        public static void patternN()
        {
            int aux = 8;
            int blank = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < blank; j++)
                {
                    Console.Write(" ");
                }
                blank++;
                for (int k = 1; k <= aux; k++)
                {
                    Console.Write(k);
                }
                aux--;
                Console.WriteLine();
            }
            Console.WriteLine("\n\n");
        }
        public static void patternO()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (j <= 8 - i - 2)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(8 - j);
                    }
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\n\n");
        }
        public static void patternP()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int x = 0; x < 8; x++)
                {
                    if (i <= x)
                    {
                        Console.Write(8 - x);
                    }
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\n\n");
        }
        public static void patternQ()
        {
            int blank = 7;
            int aux = 1;
            int num = 1;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < blank; j++)
                {
                    Console.Write(' ');
                }
                blank--;
                for (int k = 0; k < aux; k++)
                {
                    Console.Write(num);
                    if (k < i)
                    {
                        num++;
                    }
                    else
                    {
                        num--;
                    }
                }
                num = 1;
                aux += 2;
                Console.WriteLine("");
            }
            Console.WriteLine("\n\n");
        }
        public static void patternR()
        {
            int num = 1;
            int cantidadnumeros = 16;
            for (int x = 0; x < 8; x++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < cantidadnumeros - 1; j++)
                {
                    Console.Write(num);

                    if (j < 8 - x - 1)
                    {
                        num++;
                    }
                    else
                    {
                        num--;
                    }
                }
                cantidadnumeros -= 2;
                num = 1;
                Console.WriteLine("");
            }
            Console.WriteLine("\n\n");
        }
        public static void patternS()
        {
            int n = 8;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                for (int k = 1; k <= 2 * (n - i); k++)
                {
                    Console.Write(" ");
                }
                for (int l = i; l >= 1; l--)
                {
                    Console.Write(l);
                }

                Console.WriteLine("");
            }
            Console.WriteLine("\n\n");
        }
        
    }
}
