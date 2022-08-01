using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class People
    {
        public int ID { get; set; }
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public People()
        {
        }
        public People(int id, string hoten, int tuoi, string diachi, string sdt)
        {
            this.ID = id;
            this.HoTen = hoten;
            this.Tuoi = tuoi;
            this.DiaChi = diachi;
            this.SDT = sdt;
        }
    }
}
