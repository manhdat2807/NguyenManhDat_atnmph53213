using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenManhDat_datnmph53213
{
    internal class SinhvienUD: Sinhvien
    {
        int kyhochientai = 2;
        public SinhvienUD()
        {
            
        }

        public SinhvienUD(int kyhochientai,string masinhvien, string ten, int namsinh, double diem) :base(masinhvien,ten,namsinh,diem)
        {
            this.kyhochientai = kyhochientai;
        }

        public int Kyhochientai { get => kyhochientai; set => kyhochientai = value; }
        public void inthongtin() {
            base.inthongtin();
            Console.WriteLine("Ky hoc "+kyhochientai);
        }

    }
}
