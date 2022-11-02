using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5
{
    internal class Трава : Растение
    {
        protected string type;
        public Трава(string pName, int pAge, string pType) : base(pName, pAge)
        {
            type = pType;
        }
        public override void GetName()
        {
            Console.WriteLine("Название травы: "+name);
        }
    }
}
