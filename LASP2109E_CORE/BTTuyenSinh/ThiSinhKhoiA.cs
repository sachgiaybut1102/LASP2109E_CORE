using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LASP2109E_CORE.BTTuyenSinh
{
    public class ThiSinhKhoiA : ThiSinh
    {
        public ThiSinhKhoiA(string soBaoDanh, string hoTen, string diaChi, int mucDoUuTien) : base(soBaoDanh, hoTen, diaChi, mucDoUuTien)
        {
        }

        private double _diemToan;
        public double DiemToan
        {
            get {  return _diemToan; }
            set {  _diemToan = value; }
        }

        private double _diemLy;
        public double DiemLy
        {
            get { return _diemLy; }
            set { _diemLy = value; }
        }

        private double _diemHoa;    

        public double DiemHoa
        {
            get { return _diemHoa; }
            set { _diemHoa = value; }
        }
    }
}
