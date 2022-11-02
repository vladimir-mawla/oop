using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4;

class Programm 
{
    static void Main(string[] args)
    {
        var list = new List<Растение>();
        var member = new Растение("Гриб", 2);
        list.Add(member);
        member = new Трава("Укроп", 1, "Однолетнее");
        list.Add(member);
        member = new Дерево("Береза", 12, 12.4);
        list.Add(member);
        member = new Кустарник("Папоротник", 2, false);
        list.Add(member);
        member = new Кактус("Нотокактус", 3, false, "notokaktus");
        list.Add(member);
        member = new ЯгодныйКуст("Малина", 5, "Малина", "Лето", true);
        list.Add(member);
        member = new ФруктовоеДерево("Яблоня", 14, 3, "яблоко", "лето");
        list.Add(member);
        foreach (var item in list)
        {
            item.GetName();
        }
    }
}
