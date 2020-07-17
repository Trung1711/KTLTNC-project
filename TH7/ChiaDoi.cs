using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH7
{
    class ChiaDoi : IChiaDoiHandeler
    {


        //public delegate double HamMotBien(double x);
        public  double TimNgiem(double GTDau, double GTCuoi, double saiso, HamMotBien hamfx)
        {
            double Trungdiem = 0;

            while (GTCuoi - GTDau > saiso)
            {
                Trungdiem = (GTDau + GTCuoi) / 2;
                double sign = hamfx(Trungdiem) * hamfx(GTCuoi);
                if (sign > 0)
                    GTCuoi = Trungdiem;
                else if (sign < 0)
                    GTDau = Trungdiem;
                else
                    return Trungdiem;
            }
            return Trungdiem;
        }
    }
}
