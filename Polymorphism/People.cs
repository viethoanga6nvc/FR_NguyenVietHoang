using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class People
    {
        protected int ID { get; set; }
        protected string Name { get; set; }
        protected int BirthYear { get; set; }
        protected string Degree { get; set; }
        public People()
        { 
        }
        public People(int id, string name, int birthyear, string degree)
        {
            this.ID = id;
            this.Name = name;
            this.BirthYear = birthyear;
            this.Degree = degree;
        }
        public virtual void Input()
        {
            Console.WriteLine("--------Input--------");
            Console.Write("ID: ");
            ID = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Year of Birth: ");
            BirthYear = int.Parse(Console.ReadLine());
            Console.Write("Degree: ");
            Degree = Console.ReadLine();
        }
        public virtual void Output()
        {
            Console.Write($"{ID,5}{Name,10}{BirthYear,10}{Degree,15}");
        }
    }
}
