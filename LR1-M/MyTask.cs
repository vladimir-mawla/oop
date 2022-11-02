using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1_M
{
    internal class MyTask
    {
        public static void DoTask()
        {
            Console.Write("Введите количество чисел > ");
            int n = int.Parse(Console.ReadLine());
            float [] numbers = new float[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Введите " + (i+1) + " число > ");
                numbers[i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("Результирующая последовательность >");
            float res=0;
            for (int i = 0; i < numbers.Length; i++)
            {
                res+= (1 - numbers[i]) / (1 + numbers[i] * numbers[i]);
                Console.WriteLine(res);
            }
        }
    }
}
