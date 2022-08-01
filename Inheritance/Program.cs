using Inheritance;
using System.Collections;

Console.WriteLine("Su dung List");
List<Student> students = new();
students.Add(new Student(1, "Hoang", 22, "Ha Noi", "0987654321", "CNTT", 2018));
students.Add(new Student(2, "Hai", 22, "Thai Binh", "0123456789", "KD", 2018));
students.Add(new Student(3, "Long", 23, "Nam Dinh", "015632794", "DL", 2011));
Console.WriteLine($"{"ID",5}{"Ho Ten",20}{"Tuoi",15}{"DiaChi",15}{"SDT",20}{"Khoa",15}{"Nam Nhap Hoc",20}");
foreach(Student student in students)
{
    student.Xuat();
}

Console.WriteLine("Su dung Array List");
ArrayList students1 = new();
students1.Add(new Student(4, "Anh", 18, "Hai Phong", "02378661", "SP", 2022));
students1.Add(new Student(5, "Nam", 22, "Hai Duong", "07852136", "CK", 2021));
Console.WriteLine($"{"ID",5}{"Ho Ten",20}{"Tuoi",15}{"DiaChi",15}{"SDT",20}{"Khoa",15}{"Nam Nhap Hoc",20}");
foreach (Student item in students1)
{
    item.Xuat();
}

Console.ReadKey();