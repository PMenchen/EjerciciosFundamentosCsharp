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
                for(int j = 0; j < 8; j++) { }
                
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

        }
        public static void patternG()
        {

        }
            
        public static void patternH()
        {

        }

        public static void patternI()
        {


        }

        public static void patternJ()
        {

        }

        public static void patternK()
        {

        }

        public static void patternL()
        {

        }
        public static void patternM()
        {

        }
        public static void patternN()
        {

        }
        public static void patternO()
        {

        }
        public static void patternP()
        {

        }
        public static void patternQ()
        {

        }
        public static void patternR()
        {

        }
        public static void patternS()
        {

        }
        public static void patternT()
        {

        }
    }
}
