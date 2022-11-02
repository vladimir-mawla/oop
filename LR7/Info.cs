using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7
{
    internal class Info
    {
        private List<Sotrudnik> data;

        public Info()
        {
            data = new List<Sotrudnik>();
        }
        public void Add(Sotrudnik sotrudnik)
        {
            data.Add(sotrudnik);
        }
        public void Delete(Sotrudnik sotrudnik)
        {
            if (data.Contains(sotrudnik)) data.Remove(sotrudnik);
            else Console.WriteLine($" {sotrudnik.fio} не найден");
        }
        public void Find(string name)
        {
            bool found = false;
            foreach (Sotrudnik sotrudnik in data)
            {
                List<Tech> techs = sotrudnik.GetList();
                foreach (Tech tech in techs)
                {
                    if (name.Equals(tech.name))
                    {
                        Console.WriteLine("Информация о сотруднике, владеющим оборудованием");
                        sotrudnik.GetInfo();
                        found = true;
                    }
                }
            }
            if (!found) Console.WriteLine("Оборудование не найдено.");
        }
    }
}
