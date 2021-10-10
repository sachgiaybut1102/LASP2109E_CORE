using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LASP2109E_CORE.BTCanBo
{
    public class KySu : CanBo
    {
        public KySu(string hoTen, int tuoi, string gioiTinh, string diaChi) : base(hoTen, tuoi, gioiTinh, diaChi)
        {

        }

        protected string _nganhDaoTao;
        public string NganhDaoTao
        {
            get { return _nganhDaoTao; }
            set {  _nganhDaoTao = value;}
        }
    }
}
