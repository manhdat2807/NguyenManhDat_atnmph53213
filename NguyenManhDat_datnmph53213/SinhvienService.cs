using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenManhDat_datnmph53213
{
    internal class SinhvienService
    {
        List<Sinhvien> list=new List<Sinhvien>();
        private int diem;
        private int namsinh;

        public SinhvienService()
        {
            list = new List<Sinhvien>();
        }
        public void nhaptt()
        {
            Console.WriteLine("Nhap so luong dinh vien");
            int soluong = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < soluong; i++)
            {
                Sinhvien sv = new Sinhvien();
                Console.WriteLine("Nhap ma sinh vien");
                sv.Masinhvien = Console.ReadLine();
                Console.WriteLine("Nhap ten sinh vien");
                sv.Ten = Console.ReadLine();
                Console.WriteLine("Nhap nam sinh cua sinh vien");
                sv.Namsinh= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhap diem cua sinh vien");
                sv.Diem= Convert.ToDouble(Console.ReadLine());
                list.Add(sv);
            }
            Console.WriteLine("Ban co muon tiep tuc khong, Y la co con lai thi thoi");
            string choose = Console.ReadLine();
            if (choose == "Y")
            {
                nhaptt();
            }
            else return;
        }
        public void xuattt()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Chua co du lieu nhap vao, vui long nhap  ");
                nhaptt() ;
                xuattt();
            }
            foreach (var item in list) 
            {
                item.inthongtin();
            }
        }
        public void ngoanseduocthuong()
        {
            if (diem >= 8)
            {
                Console.WriteLine("ve vip ");

            }
            foreach(var item in list)
            {
                item.inthongtin();
            }
        }
        public void xoa()
        {
            if (diem >= 8 || namsinh < DateTime.Now.Year - 25)
            { 
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Namsinh < 25)
                    {
                        list.RemoveAt(i);
                        i--;
                    }
                }
            }
            xuattt();
        }
    }
}
