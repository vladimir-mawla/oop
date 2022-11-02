using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    internal class ОфиснаяТехника
    {
        public string name { get; private set; }
        public int price { get; private set; }
        public float percentRemont { get; private set; }
        public ОфиснаяТехника(string pName, int pPrice, float pPercentRemont)
        {
            name = pName;
            price = pPrice;
            percentRemont = pPercentRemont;
        }
    }
}
