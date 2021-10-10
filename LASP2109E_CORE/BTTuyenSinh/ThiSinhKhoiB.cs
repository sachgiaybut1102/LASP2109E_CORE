using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LASP2109E_CORE.BTTuyenSinh
{
    public class ThiSinhKhoiB : ThiSinh
    {
        public ThiSinhKhoiB(string soBaoDanh, string hoTen, string diaChi, int mucDoUuTien) : base(soBaoDanh, hoTen, diaChi, mucDoUuTien)
        {
        }

        private double _diemToan;
        public double DiemToan
        {
            get { return _diemToan; }
            set { _diemToan = value; }
        }

        private double _diemHoa;
        public double DiemHoa
        {
            get { return _diemHoa; }
            set { _diemHoa = value; }
        }

        private double _diemSinh;
        public double DiemSinh
        {
            get { return _diemSinh; }
            set { _diemSinh = value; }
        }
    }
}
