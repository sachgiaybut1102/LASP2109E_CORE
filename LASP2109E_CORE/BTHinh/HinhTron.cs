using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LASP2109E_CORE.BTHinh
{
    public class HinhTron : Hinh
    {
        private double _r;
        public double R
        {
            get { return _r; }
            set { _r = value; }
        }

        public HinhTron()
        {
            _r = 0;
        }

        public HinhTron(double r)
        {
            _r = r;
        }

        public override double ChuVi()
        {
            return 2 * Math.PI * _r;
        }

        public override double DienTich()
        {
            return Math.PI * Math.Pow(_r, 2);
        }
    }
}
