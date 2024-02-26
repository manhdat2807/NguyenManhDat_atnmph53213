using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenManhDat_datnmph53213
{
    internal class Sinhvien
    {
        string masinhvien; string ten; int namsinh; double diem;
        public Sinhvien()
        {
            
        }
        public Sinhvien(string masinhvien, string ten, int namsinh, double diem)
        {
            this.masinhvien = masinhvien;
            this.ten = ten;
            this.namsinh = namsinh;
            this.diem = diem;
        }

        public string Masinhvien { get => masinhvien; set => masinhvien = value; }
        public string Ten { get => ten; set => ten = value; }
        public int Namsinh { get => namsinh; set => namsinh = value; }
        public double Diem { get => diem; set => diem = value; }
        public void inthongtin()
        {
            Console.WriteLine($"Ma sinh vien :{masinhvien}, Ten :{ten},Nam sinh: {namsinh},Diem : {diem}");
        }
    }
}
