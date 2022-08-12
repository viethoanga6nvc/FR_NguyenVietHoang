using System.Collections.Generic;

namespace Lambda_Expresion
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Danh sach nhan vien dau vao");
            Console.WriteLine(Header());
            foreach (var e in Add())
            {
                e.Output();
            }

            EmployeeIDMore10();

            FirstEmployeeBirthdayEqual1992();

            EmployeeIDMore10nNameStartByC();
        }

        static List<Employee> Add()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(8, "Hoang",new DateTime(2000, 10, 15)),
                new Employee(11, "Giang", new DateTime(1992, 4, 6)),
                new Employee(66, "Ha", new DateTime(1999, 5, 31)),
                new Employee(5, "Chinh", new DateTime(1992, 8, 9)),
                new Employee(16, "Chien", new DateTime(1991, 6, 7))
            };
            return employees;
        }

        static string Header()
        {
            return $"{"ID",5}{"Name",10}{"Birthday",15}";
        }

        static void EmployeeIDMore10()
        {
            List<Employee> employees = Add();
            var query = employees.Where(e => e.ID > 10);
            Console.WriteLine("Danh sach nhan vien co ID > 10:");
            Console.WriteLine(Header());
            foreach(Employee employee in query.ToList())
            {
                employee.Output();
            }
        }

        static void FirstEmployeeBirthdayEqual1992()
        {
            List<Employee> employees = Add();
            Employee e = employees.FirstOrDefault(e1 => e1.Birthday.Year == 1992);
            Console.WriteLine("Nhan vien dau tien co nam sinh = 1992");
            Console.WriteLine(Header());
            e.Output();
        }

        static void EmployeeIDMore10nNameStartByC()
        {
            List<Employee> employees = Add();
            var query = employees.Where(e => e.ID > 10 && e.Name.StartsWith('C'));
            Console.WriteLine("Danh sach nhan vien co ID > 10 va co ten bat dau bang C:");
            Console.WriteLine(Header());
            foreach (Employee employee in query.ToList())
            {
                employee.Output();
            }
        }
    }
}