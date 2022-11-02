using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5
{
    internal class Кактус : Растение
    {
        protected bool hasWater;
        public string clas;
        public Кактус(string pName, int pAge, bool pHasWater, string pClass) : base(pName, pAge)
        {
            this.hasWater = pHasWater;
            this.clas = pClass;
        }
        public override void GetName()
        {
            Console.WriteLine("Название кактуса: " + name);
        }
    }
}
