using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5;

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
        Кустарник member1 = new Кустарник("Папоротник", 2, false);
        Console.WriteLine(member1.GetBlosoom());
        list.Add(member1);
        member = new Кактус("Нотокактус", 3, false, "notokaktus");
        list.Add(member);
        ЯгодныйКуст member2 = new ЯгодныйКуст("Малина", 5, "Малина", "Лето", true);
        Console.WriteLine(member2.GetBlosoom());
        list.Add(member2);
        ФруктовоеДерево member3 = new ФруктовоеДерево("Яблоня", 14, 3, "яблоко", "лето");
        Console.WriteLine(member3.GetBlosoom());
        list.Add(member3);
        foreach (var item in list)
        {
            item.GetName();
        }
    }
}
