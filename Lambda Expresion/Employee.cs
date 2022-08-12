using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expresion
{
    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        public Employee(int id, string name, DateTime birthday)
        {
            this.ID = id;
            this.Name = name;
            this.Birthday = birthday;
        }

        public void Output()
        {
            Console.WriteLine($"{ID,5}{Name,10}{Birthday,15:d}");
        }
    }
}
