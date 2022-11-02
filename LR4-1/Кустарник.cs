using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5
{
    internal class Кустарник : Растение, IBlossom
    {
        protected bool isBlooming;
        public Кустарник(string pName, int pAge, bool pIsBlooming) : base(pName, pAge)
        {
            isBlooming = pIsBlooming;
        }

        public virtual string GetBlosoom()
        {
            string info=null;
            if (isBlooming)
            {
                info = name + " цветет!";
            }
            else
            {
                info = name + " не цветет!";
            }
            return info;
        }

        public override void GetName()
        {
            Console.WriteLine("Название кустарника: " + name);
        }
    }
}
