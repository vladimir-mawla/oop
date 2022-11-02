using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5
{
    internal class Растение
    {
        protected string name;
        protected int age;
        public Растение(string pName, int pAge)
        {
            name = pName;
            age = pAge;
        }

        public virtual void GetName()
        {
            Console.WriteLine("Название растения: "+name);
        }
    }
}
