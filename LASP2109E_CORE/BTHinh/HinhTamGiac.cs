using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LASP2109E_CORE.BTHinh
{
    public class HinhTamGiac : Hinh
    {
        private double _canhA;
        public double CanhA
        {
            get { return _canhA; }
            set { _canhA = value; }
        }

        private double _canhB;
        public double CanhB
        {
            get { return _canhB; }
            set { _canhB = value; }
        }

        private double _canhC;
        public double CanhC
        {
            get { return _canhC; }
            set { _canhC = value; }
        }

        public HinhTamGiac()
        {
            _canhA = 0;
            _canhB = 0;
            _canhC = 0;
        }

        public HinhTamGiac(double canhA, double canhB, double canhC)
        {
            _canhA = canhA;
            _canhB = canhB;
            _canhC = canhC;
        }

        public override double ChuVi()
        {
            return _canhA + _canhB + _canhC;
        }

        public override double DienTich()
        {
            double nuaCv = ChuVi() / 2;

            return Math.Sqrt(nuaCv * (nuaCv - _canhA) * (nuaCv - _canhB) * (nuaCv - _canhC));
        }
    }
}
