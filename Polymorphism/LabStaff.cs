using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class LabStaff : People
    {
        public double Salary { get; set; }
        public LabStaff()
        {
        }
        public LabStaff(int id, string name, int birthyear, string degree, double salary) : base(id, name, birthyear, degree)
        {
            this.Salary = salary;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Salary: ");
            Salary = double.Parse(Console.ReadLine());
        }
        public override void Output()
        {
            base.Output();
            Console.Write($"{Salary,8}\n");
        }
    }
}
