using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Student : People
    {
        public string Khoa { get; set; }
        public int NamNhapHoc { get; set; }
        public Student()
        {
        }
        public Student(int id, string hoten, int tuoi, string diachi, string sdt,
            string khoa, int namnhaphoc)
            : base(id, hoten, tuoi, diachi, sdt)
        {
            this.Khoa = khoa;
            this.NamNhapHoc = namnhaphoc;
        }
        public void Xuat()
        {
            Console.WriteLine($"{ID,5}{HoTen,20}{Tuoi,15}{DiaChi,15}{SDT,20}{Khoa,15}{NamNhapHoc,20}");
        }
    }
}
