using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    internal class ФруктовоеДерево : Дерево
    {
        protected string fruitName;
        protected string season;
        public ФруктовоеДерево(string pName, int pAge, double pHeight, string pFruitName, string pSeason) : base(pName, pAge, pHeight)
        {
            this.fruitName = pName;
            this.season = pSeason;
        }
        public override void GetName()
        {
            Console.WriteLine("Название фруктового дерева: " + name);
        }
    }
}
