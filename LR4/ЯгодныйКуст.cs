using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    internal class ЯгодныйКуст : Кустарник
    {
        protected string berryName;
        protected string season;
        public ЯгодныйКуст(string pName, int pAge, string pBerryName, string pSeason,bool pIsBlooming=true) : base(pName, pAge, pIsBlooming=true)
        {
            this.berryName = pName;
            this.season = pSeason;
        }
        public override void GetName()
        {
            Console.WriteLine("Название ягодного куста: " + name);
        }
    }
}
