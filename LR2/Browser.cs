using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    internal class Browser
    {
        public static Dictionary<User,String> zapros = new Dictionary<User,String>();
        public static List<User> Users = new List<User>();

        public static void Initial()
        {
            User user1 = new User("Vlad", "001");
            User user2 = new User("Vova", "002");
            Users.Add(user1);
            Users.Add(user2);
            zapros.Add(Users[0], "Запрос");
            zapros.Add(Users[1], "Двугой запрос");
        }
        public static void Zapros(User user, string pZapros)
        {
            Users.Add(user);
            zapros.Add(user, pZapros);
        }
        public static void Info(User user)
        {
            bool find = false;
            foreach (User us in Users)
            {
                if (user.id == us.id)
                {
                    Console.WriteLine("Список ваших запросов: ");
                    foreach (var user1 in zapros.Keys)
                    {
                        if (user.id == user1.id)
                        {
                            find = true;
                            string zapr = zapros[user1];
                            Console.WriteLine(zapr);
                        }
                        else
                        {
                            if (!find)
                            {
                                Console.WriteLine("У вас нет запросов");
                                break;
                            }
                        }
                    }
                    break;

                }
                else
                {
                    Console.WriteLine("Клиент не существует в базе данных браузера");
                    break;
                }
            }
        }
    }
}
