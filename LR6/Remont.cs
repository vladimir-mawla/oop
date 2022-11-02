using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    internal class Remont<T> where T : ОфиснаяТехника
    {

        public static string GetInfo(T geo)
        {
            return ($"Название: {geo.name}, Цена: {geo.price}");
        }

        public static float GetRemont(T geo)
        {
            return (geo.price * geo.percentRemont);
        }
    }
}
