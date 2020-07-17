using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH7
{
    class Hinhthang: IHinhthanghandle
    {
        //public delegate double HamMotBien(double x);
        public double TichPhan(double giaTriDau, double giaTriCuoi, double SoDoan, HamMotBien hamfx)
        {
            double h = (giaTriCuoi - giaTriDau) / SoDoan;
            double kq = (h / 2) * (hamfx(giaTriDau) + hamfx(giaTriCuoi));
            for (int i = 1; i <= SoDoan - 1; i++)
            {
                kq = kq + h * (hamfx(giaTriDau + i * h));
            }
            return kq;
        }
    }
}
