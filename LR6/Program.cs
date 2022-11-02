using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    class Programm
    {
        static void Main(string[] args)
        {
            var Принтер = new ОфиснаяТехника("Принтер", 12000, 1.2f);
            Console.WriteLine(Remont<ОфиснаяТехника>.GetInfo(Принтер));
            Console.WriteLine(Remont<ОфиснаяТехника>.GetRemont(Принтер));
        }
    }
}
