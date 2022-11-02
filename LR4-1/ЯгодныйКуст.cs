using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5
{
    internal class ЯгодныйКуст : Кустарник, IBlossom
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
        public override string GetBlosoom()
        {
            return (name+ " цветет, ягода: " + berryName);
        }
    }
}
