using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LASP2109E_CORE.BTCanBo
{
    public class NhanVien : CanBo
    {
        public NhanVien(string hoTen, int tuoi, string gioiTinh, string diaChi) : base(hoTen, tuoi, gioiTinh, diaChi)
        {

        }

        protected string _congViec;
        public string CongViec
        {
            get { return _congViec; }
            set { _congViec = value; }
        }
    }
}
