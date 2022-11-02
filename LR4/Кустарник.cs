using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    internal class Кустарник : Растение
    {
        protected bool isBlooming;
        public Кустарник(string pName, int pAge, bool pIsBlooming) : base(pName, pAge)
        {
            isBlooming = pIsBlooming;
        }
        public override void GetName()
        {
            Console.WriteLine("Название кустарника: " + name);
        }
    }
}
