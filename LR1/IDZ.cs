using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1
{
    internal class IDZ
    {
        public static void DoTask()
        {
            Console.Write("Введите количество чисел >");
            int n = int.Parse(Console.ReadLine());
            float [] numb = new float[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите "+(i+1)+" число >");
                numb[i] = float.Parse(Console.ReadLine());
            }
            Console.Write("Куб суммы всех чисел равен: ");
            float sum = numb.Sum();
            Console.WriteLine(sum*sum*sum);
        }
    }
}
