using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7
{
    class Programm
    {
        static void Main(string[] args)
        {
            Tech tech1 = new Tech("Принтер", 12000);
            Tech tech2 = new Tech("Компьютер", 123000);
            Tech tech3 = new Tech("Клавиатура", 1900);
            Tech tech4 = new Tech("Монитор", 9000);
            Tech tech5 = new Tech("Холодильник", 9999);
            Sotrudnik sotrudnik = new Sotrudnik("Vladimir", "Stavropol");
            Sotrudnik sotrudnik1 = new Sotrudnik("Micheal", "Rostov");
            tech1.GetInfo();
            tech2.GetInfo();
            sotrudnik.GetInfo();
            sotrudnik1.Add(tech1);
            sotrudnik1.Add(tech2);
            sotrudnik1.Add(tech5);
            var list = sotrudnik1.GetList();
            foreach (var item in list)
            {
                Console.WriteLine(item.name);
            }
            var data = new Info();
            data.Add(sotrudnik);
            data.Add(sotrudnik1);
            data.Find("Компьютер");
            data.Find("Мышь");
        }
    }
}
