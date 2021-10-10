using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LASP2109E_CORE
{
    public class SoPhuc
    {
        //Khai báo thuộc tính
        private double _thuc;
        public double Thuc
        {
            get { return _thuc; }
            set { _thuc = value; }
        }

        private double _ao;
        public double Ao
        {
            get { return _ao; }
            set { _ao = value; }
        }

        //Khai báo hàm tạo
        public SoPhuc()
        {
            _thuc = 0;
            _ao = 0;
        }

        public SoPhuc(int thuc, int ao)
        {
            _thuc = thuc;
            _ao = ao;
        }

        //Khai báo phương thức
        public SoPhuc Cong(SoPhuc soPhuc)
        {
            SoPhuc rSoPhuc = new SoPhuc();

            rSoPhuc.Thuc = _thuc + soPhuc.Thuc;
            rSoPhuc.Ao = _ao + soPhuc.Ao;

            return rSoPhuc;
        }

        public SoPhuc Cong(double t)
        {
            SoPhuc rSoPhuc = new SoPhuc();

            rSoPhuc.Thuc = _thuc + t;
            rSoPhuc.Ao = _ao;

            return rSoPhuc;
        }

        public void In()
        {
            Console.WriteLine("({0}, {1})", _thuc, _ao);
        }

        //Khai báo phương thức tĩnh
        public static SoPhuc Cong(SoPhuc soPhuc1, SoPhuc soPhuc2)
        {
            SoPhuc rSoPhuc = new SoPhuc();

            rSoPhuc.Thuc = soPhuc1._thuc + soPhuc2.Thuc;
            rSoPhuc.Ao = soPhuc1._ao + soPhuc2.Ao;

            return rSoPhuc;
        }

        public static SoPhuc Cong(SoPhuc soPhuc, double t)
        {
            SoPhuc rSoPhuc = new SoPhuc();

            rSoPhuc.Thuc = soPhuc.Thuc + t;
            rSoPhuc.Ao = soPhuc.Ao;

            return rSoPhuc;
        }

        //Nạp chồng toán tử trên lớp
        public static SoPhuc operator +(SoPhuc soPhuc1, SoPhuc soPhuc2)
        {
            SoPhuc rSoPhuc = new SoPhuc();

            rSoPhuc.Thuc = soPhuc1._thuc + soPhuc2.Thuc;
            rSoPhuc.Ao = soPhuc1._ao + soPhuc2.Ao;

            return rSoPhuc;
        }

        public static SoPhuc operator +(SoPhuc soPhuc, double t)
        {
            SoPhuc rSoPhuc = new SoPhuc();

            rSoPhuc.Thuc = soPhuc.Thuc + t;
            rSoPhuc.Ao = soPhuc.Ao;

            return rSoPhuc;
        }

    }
}
