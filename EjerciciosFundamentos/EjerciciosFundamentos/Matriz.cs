using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosFundamentos
{
    public class Matriz
    {
        private double[,] data;

        public int Rows { get; }
        public int Columns { get; }

        public Matriz(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            data = new double[rows, columns];
        }

        public double this[int row, int column]
        {
            get => data[row, column];
            set => data[row, column] = value;
        }

        public static Matriz operator +(Matriz a, Matriz b)
        {
            if (a.Rows != b.Rows || a.Columns != b.Columns)
            {
                throw new InvalidOperationException("Las matrices deben tener la misma dimensión");
            }

            Matriz result = new Matriz(a.Rows, a.Columns);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Columns; j++)
                {
                    result[i, j] = a[i, j] + b[i, j];
                }
            }
            return result;
        }

        public static Matriz operator -(Matriz a, Matriz b)
        {
            if (a.Rows != b.Rows || a.Columns != b.Columns)
            {
                throw new InvalidOperationException("Las matrices deben tener la misma dimensión");
            }

            Matriz result = new Matriz(a.Rows, a.Columns);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Columns; j++)
                {
                    result[i, j] = a[i, j] - b[i, j];
                }
            }
            return result;
        }

        public static Matriz operator *(Matriz a, Matriz b)
        {
            if (a.Columns != b.Rows)
            {
                throw new InvalidOperationException("El número de columnas de la primera matriz debe ser igual al número de filas de la segunda matriz");
            }

            Matriz result = new Matriz(a.Rows, b.Columns);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < b.Columns; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < a.Columns; k++)
                    {
                        sum += a[i, k] * b[k, j];
                    }
                    result[i, j] = sum;
                }
            }
            return result;
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    result += data[i, j] + "\t";
                }
                result += "\n";
            }
            return result;
        }
    }
}
