using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7
{
    internal class Tech
    {
        public string name { get; private set; }
        public double price { get; private set; }
        public Tech(string pName, double pPrice)
        {
            name = pName;
            price = pPrice;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Название: {name} " +
                $"\n Цена: {price} ");
            Console.WriteLine();
        }
    }
}
