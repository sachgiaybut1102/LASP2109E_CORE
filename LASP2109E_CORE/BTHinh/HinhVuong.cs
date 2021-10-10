using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LASP2109E_CORE.BTHinh
{
    public class HinhVuong : HinhChuNhat
    {
        public HinhVuong() : base()
        {

        }

        public HinhVuong(double doDai) : base(doDai, doDai)
        {

        }

        public double DoDai
        {
            get { return ChieuDai; }
            set
            {
                _chieuDai = value;
                _chieuRong = value;
            }
        }
    }
}
