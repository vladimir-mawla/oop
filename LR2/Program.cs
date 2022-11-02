using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    class Programm
    {
        static void Main(string[] args)
        {

            Browser.Initial();
            Console.WriteLine("Система учета сетевых запросов готова к работе");
            Console.Write("Как к вам обращаться? ");
            string fio = Console.ReadLine();
            Console.Write(fio + ", Введите id клиента ");
            string id = Console.ReadLine();
            User client=new User(fio, id);
            Console.WriteLine("Уважаемый " + client.name + ", выберите действие\n" +
                "1-Вывод списка запросов\n" +
                "2-Ввести запрос\n" +
                "0-Выход");
            int doIt = int.MaxValue;
            while (doIt > 0)
            {
                Console.Write("Ваш выбор: ");
                doIt = int.Parse(Console.ReadLine());
                switch (doIt)
                {
                    case 1:
                        Browser.Info(client);
                        break;
                    case 2:
                        Console.WriteLine("Введите запрос >");
                        string zapros = Console.ReadLine();
                        Console.WriteLine("Запрос принят!");
                        Browser.Zapros(client, zapros);
                        break;
                    case 0:
                        doIt = 0;
                        break;
                    default: break;

                }
            }
            Console.ReadLine();
        }
    }
}