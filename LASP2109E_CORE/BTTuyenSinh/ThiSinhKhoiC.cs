using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LASP2109E_CORE.BTTuyenSinh
{
    public class ThiSinhKhoiC : ThiSinh
    {
        public ThiSinhKhoiC(string soBaoDanh, string hoTen, string diaChi, int mucDoUuTien) : base(soBaoDanh, hoTen, diaChi, mucDoUuTien)
        {
        }

        private double _diemVan;
        public double DiemVan
        {
            get { return _diemVan; }
            set { _diemVan = value; }
        }

        private double _diemSu;
        public double DiemSu
        {
            get { return _diemSu; }
            set { _diemSu = value; }
        }

        private double _diemDia;
        public double DiemDia
        {
            get { return _diemDia; }
            set { _diemDia = value; }
        }
    }
}
