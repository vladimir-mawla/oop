using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    internal class Дерево : Растение
    {
        public double height;
        public Дерево(string pName, int pAge, double pHeight) : base(pName, pAge)
        {
            height = pHeight;
        }
        public override void GetName()
        {
            Console.WriteLine("Название дерева: " + name);
        }
    }
}
