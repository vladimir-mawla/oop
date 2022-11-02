using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5
{
    internal class ФруктовоеДерево : Дерево, IBlossom
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
        public string GetBlosoom()
        {
            return (name + " цветет, фрукт: " + fruitName +", сезон цветения: "+season);
        }
    }
}
