using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LASP2109E_CORE.BTCanBo
{
    public class CanBo
    {
        public CanBo()
        {

        }

        public CanBo(string hoTen, int tuoi, string gioiTinh, string diaChi)
        {
            _hoTen = hoTen;
            _tuoi = tuoi;
            _gioiTinh = gioiTinh;
            _diaChi = diaChi;
        }
        protected string _hoTen;
        public string HoTen
        {
            get {  return _hoTen; }
            set {  _hoTen = value; }
        }

        protected int _tuoi;
        public int Tuoi
        {
            get {  return _tuoi; }
            set {  _tuoi = value; }
        }

        protected string _gioiTinh;
        public string GioiTinh
        {
            get { return _gioiTinh; }
            set { _gioiTinh = value;}
        }

        protected string _diaChi;
        public string DiaChi
        {
            get {  return _diaChi; }
            set {  _diaChi = value; }
        }
    }
}
