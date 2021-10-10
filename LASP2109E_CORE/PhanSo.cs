using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LASP2109E_CORE
{
    public class PhanSo
    {
        private int _tu;
        public int Tu
        {
            get { return _tu; }
            set { _tu = value; }
        }

        private int _mau;
        public int Mau
        {
            get { return _mau; }
            set {  _mau = value; }
        }

        public PhanSo()
        {
            _tu = 0;
            _mau = 1;
        }

        public PhanSo(int tu, int mau)
        {
            _tu = tu;
            _mau = mau;
        }

        public static PhanSo operator + (PhanSo ps1, PhanSo ps2)
        {
            PhanSo ps = new PhanSo();

            ps.Tu = ps1.Tu * ps2.Mau + ps2.Tu * ps1.Mau;
            ps.Mau = ps1.Mau * ps2.Mau;

            return ps;
        }

        public static PhanSo operator +(PhanSo ps1, int t)
        {
            PhanSo ps = new PhanSo();

            ps.Tu = ps1.Tu + t * ps1.Mau;
            ps.Mau = ps1.Mau;

            return ps;
        }

        public void In()
        {
            Console.WriteLine("{0}/{1}", _tu, _mau);
        }
    }
}
