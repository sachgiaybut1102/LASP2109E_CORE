using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LASP2109E_CORE.BTCanBo
{
    public class CongNhan : CanBo
    {
        public CongNhan(string hoTen, int tuoi, string gioiTinh, string diaChi) : base(hoTen, tuoi, gioiTinh, diaChi)
        {

        }

        protected int _soBac;
        public int SoBac
        {
            get { return _soBac; }
            set { _soBac = value; }
        }
    }
}
