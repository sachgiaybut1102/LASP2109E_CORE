using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LASP2109E_CORE.BTTuyenSinh
{
    public class ThiSinh
    {
        public ThiSinh()
        {

        }

        public ThiSinh(string soBaoDanh, string hoTen, string diaChi, int mucDoUuTien)
        {
            _soBaoDanh = soBaoDanh;
            _hoTen = hoTen;
            _diaChi = diaChi;
            _mucDoUuTien = mucDoUuTien;
        }
        protected string _soBaoDanh;
        public string SoBaoDanh
        {
            get { return _soBaoDanh; }
            set { _soBaoDanh = value; }
        }

        protected string _hoTen;
        public string HoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }

        protected string _diaChi;
        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }

        protected int _mucDoUuTien;
        public int MucDoUuTien
        {
            get { return _mucDoUuTien; }
            set { _mucDoUuTien = value; }
        }
    }
}
