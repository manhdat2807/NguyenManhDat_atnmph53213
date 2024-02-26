using Microsoft.Win32.SafeHandles;

namespace NguyenManhDat_datnmph53213
{
    internal class Program
    {
        static string Menu()
        {
            Console.WriteLine("1.Nhap thong tin sinh vien");
            Console.WriteLine("2.Xuat thong tin sinh vien");
            Console.WriteLine("3.Xuat thong tin sinh vien co ve vip");
            Console.WriteLine("4.Xoa  sinh vien kho co ve");
            Console.WriteLine("5.Sinh vienUD");
            Console.WriteLine("6.thoat");
            Console.WriteLine("Nhap cu luong chon cua ban");
            string chon= Console.ReadLine();
            if (chon !="1"&& chon !="2"&& chon!="3"&& chon!="4"&& chon!="5") 
            {
                Console.WriteLine("hay nhap lai");
                return Menu();
            }
            else return chon;


        }
        static void Main(string[] args)
        {
            SinhvienService svs = new SinhvienService();
            while (true)
            {
                switch(Menu())
                {
                    case "1":
                        svs.nhaptt(); break;
                    case "2":
                        svs.xuattt(); break;
                    case "3":
                        svs.ngoanseduocthuong();
                        break;
                    case "4":
                        svs.xoa(); break;
                    case "5":
                        SinhvienUD svud = new SinhvienUD();
                        Console.WriteLine("nhap ma sinh vien");
                        svud.Masinhvien = Console.ReadLine();
                        Console.WriteLine("nhap ten");
                        svud.Ten = Console.ReadLine();
                        Console.WriteLine("Nhap nam sinh");
                        svud.Namsinh=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("nhap diem");
                        svud.Diem=Convert.ToDouble(Console.ReadLine());
                        svud.inthongtin();
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
