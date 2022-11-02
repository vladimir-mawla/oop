using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7
{
    internal class Sotrudnik
    {
        public string fio {get; private set; }
        private string location;
        private List<Tech> tech;

        public Sotrudnik(string pFIO, string pLocation)
        {
            fio = pFIO;
            location = pLocation;
            tech = new List<Tech>();
        }
        public void Add(Tech tech)
        {
            this.tech.Add(tech);
        }
        public void Delete(Tech tech)   
        {
            if (this.tech.Contains(tech))
            {
                this.tech.Remove(tech);
            }
            else
            {
                Console.WriteLine($"{fio} не владеет данной техникой");
                Console.WriteLine();
            }
        }
        public void GetInfo()
        {
            Console.WriteLine($"ФИО сотрудника: {fio} \n Рабочий город: {location}");
            Console.WriteLine();
        }
        public List<Tech> GetList()
        {
            return tech;
        }
    }
}
