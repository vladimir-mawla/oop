using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3_Matrix
{
    public class Matrix
    {
        private int m;
        private int n;
        public int[,] numbers;
        public Matrix(int pM, int pN)
        {
            m = pM;
            n = pN;
            numbers = new int[n,m];
            Console.WriteLine("Введите значение матрицы >");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    numbers[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public static void PrintMatrix(Matrix matrix)
        {
            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    Console.Write(matrix.numbers[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static int GetMin(Matrix matrix)
        {
            int min = int.MaxValue;
            for (int i = 0; i < matrix.m; i++)
            {
                for (int j = 0; j < matrix.n; j++)
                {
                    if (matrix.numbers[i, j] < min) min = matrix.numbers[i, j];
                }
            }
            return min;
        }

        public static float GetSrArif(Matrix matrix)
        {
            int count = 0;
            int sum = 0;
            for (int i = 0; i < matrix.m; i++)
            {
                for (int j = 0; j < matrix.n; j++)
                {
                    count++;
                    sum+=matrix.numbers[i, j];
                }
            }
            return sum / count;
        }

        public static void PrintResultMatrix(Matrix matrix)
        {
            float srArif = GetSrArif(matrix);
            int min = GetMin(matrix);
            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    if (matrix.numbers[i, j] > srArif)
                    {
                        matrix.numbers[i, j] = min;
                    }
                    Console.Write(" " + (matrix.numbers[i, j]));
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
