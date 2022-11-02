using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1_M
{
    internal class MyTask2Edit
    {
        private List<float> numbers = new List<float>();
        private int n;

        public void InputArray()
        {
            Console.Write("Введите количество чисел > ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите " + (i + 1) + " число >");
                numbers.Add(float.Parse(Console.ReadLine()));
            }
        }

        public void PrintResult()
        {
            Console.WriteLine("Результирующая последовательность :");
            float res = 0;
            for (int i = 0; i < n; i++)
            {
                res += (1 - numbers[i]) / (1 + numbers[i] * numbers[i]);
                Console.WriteLine(res);
            }
        }
    }
}
