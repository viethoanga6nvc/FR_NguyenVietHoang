using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Scientist : People
    {
        public string Position { get; set; }
        public int NumOfArticlesInMonth { get; set; }
        public int NumOfWorkingDayInMonth { get; set; }
        public double Wage { get; set; }
        public Scientist()
        {
        }
        public Scientist(int id, string name, int birthyear, string degree,
            string position, int articles, int workingday, double wage) : base(id, name, birthyear, degree)
        {
            this.Position = position;
            this.NumOfArticlesInMonth = articles;
            this.NumOfWorkingDayInMonth = workingday;
            this.Wage = wage;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Position: ");
            Position = Console.ReadLine();
            Console.Write("Number Of Articles Published In A Month: ");
            NumOfArticlesInMonth = int.Parse(Console.ReadLine());
            Console.Write("Number Of Working Day In A Month:");
            NumOfWorkingDayInMonth = int.Parse(Console.ReadLine());
            Console.Write("Wage: ");
            Wage = double.Parse(Console.ReadLine());
        }
        public override void Output()
        {
            base.Output();
            Console.Write($"{Position,10}{NumOfArticlesInMonth,25}{NumOfWorkingDayInMonth,25}{Wage,10}{Salary(),8}\n");
        }
        public double Salary()
        {
            return Wage * NumOfWorkingDayInMonth;
        }
    }
}
