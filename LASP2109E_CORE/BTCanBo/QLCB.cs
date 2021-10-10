using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LASP2109E_CORE.BTCanBo
{
    public class QLCB
    {
        List<CanBo> _canBos;

        public QLCB()
        {
            _canBos = new List<CanBo>();
        }

        public void Run()
        {
            while (true)
            {
                DisplayMenuFunction();
                int selectionMenu = (int)GetInputCommon.GetInputValue(1, 4, "Lua chon chuc nang: ");

                switch (selectionMenu)
                {
                    case 1://Thêm thí sinh
                        CanBo canBo = InitCanBo();
                        _canBos.Add(canBo);
                        break;
                    case 2://hiên thị danh sách thí sinh
                        string hoTen = "";
                        Console.Write("Nhap vao ho ten can bo can tim: ");
                        hoTen = Console.ReadLine();
                        FindInfoByHoTen(hoTen);
                        break;
                    case 3://Tìm kiếm theo số báo danh
                        ShowListInfo();
                        break;
                    case 4://thoát khỏi chương trình                    
                        Console.WriteLine("Ket thuc chuong trinh!");
                        return;
                }
            }
        }

        private void DisplayMenuFunction()
        {
            Console.WriteLine("Danh muc chuc nang:");
            Console.WriteLine("1. Them can bo");
            Console.WriteLine("2. Tim kiem theo ho ten");
            Console.WriteLine("3. Hien thi thong tin thi sinh va khoi thi cua thi sinh");
            Console.WriteLine("4. Ket thuc chuong trinh");
        }

        private void DisplayMenuAddThiSinh()
        {
            Console.WriteLine("Danh sach cac loai can bo:");
            Console.WriteLine("1. Cong nhan");
            Console.WriteLine("2. Ky su");
            Console.WriteLine("3. Nhan vien");
        }

        private CanBo InitCanBo()
        {
            CanBo canBo = new CanBo();

            DisplayMenuAddThiSinh();
            int selectionMenu = (int)GetInputCommon.GetInputValue(1, 3, "Lua chon loai can bo: ");

            Console.WriteLine("Ho ten: ");
            canBo.HoTen = Console.ReadLine();
            canBo.Tuoi = (int)GetInputCommon.GetInputValue(18, 80, "Tuoi: ");
            Console.WriteLine("Gioi tinh: ");
            canBo.GioiTinh = Console.ReadLine();
            Console.WriteLine("Dia chi: ");
            canBo.DiaChi = Console.ReadLine();

            switch (selectionMenu)
            {
                case 1://Thí sinh thi khối A
                    canBo = new CongNhan(canBo.HoTen, canBo.Tuoi, canBo.GioiTinh, canBo.DiaChi);
                    (canBo as CongNhan).SoBac = (int)GetInputCommon.GetInputValue(1, 10, "Bac luong: ");
                    break;
                case 2://hiên thị danh sách thí sinh
                    canBo = new KySu(canBo.HoTen, canBo.Tuoi, canBo.GioiTinh, canBo.DiaChi);
                    Console.Write("Nganh dao tao: ");
                    (canBo as KySu).NganhDaoTao = Console.ReadLine();
                    break;
                case 3://Tìm kiếm theo số báo danh
                    canBo = new NhanVien(canBo.HoTen, canBo.Tuoi, canBo.GioiTinh, canBo.DiaChi);
                    Console.Write("Cong viec: ");
                    (canBo as NhanVien).CongViec = Console.ReadLine();
                    break;
            }

            return canBo;
        }

        private void ShoInfo(CanBo canBo)
        {
            Console.WriteLine("Ho ten: {0}", canBo.HoTen);
            Console.WriteLine("Tuoi: {0}", canBo.Tuoi);
            Console.WriteLine("Gioi tinh: {0}", canBo.GioiTinh);
            Console.WriteLine("Dia chi: {0}", canBo.DiaChi);

            if (canBo is CongNhan)
            {
                var congNhan = canBo as CongNhan;
                Console.WriteLine("Chu vu: Cong nhan");
                Console.WriteLine("Bac luong: {0}", congNhan.SoBac);
            }
            else if (canBo is KySu)
            {
                var kySu = canBo as KySu;
                Console.WriteLine("Chu vu: Ky su");
                Console.WriteLine("Nganh dao tao: {0}", kySu.NganhDaoTao);
            }
            else
            {
                var nhanVien = canBo as NhanVien;
                Console.WriteLine("Chu vu: Nhan vien");
                Console.WriteLine("Cong viec: {0}", nhanVien.CongViec);
            }
        }

        private void ShowListInfo()
        {
            int i = 1;
            foreach (var canBo in _canBos)
            {
                Console.WriteLine("Thong tinh can bo thu {0}:", i++);

                ShoInfo(canBo);
            }
        }

        private void FindInfoByHoTen(string sbd)
        {
            bool flag = false;

            foreach (var canBo in _canBos)
            {
                if (canBo.HoTen.Equals(sbd))
                {
                    Console.WriteLine("Thong tinh can bo can tim:");

                    ShoInfo(canBo);

                    flag = true;

                    break;
                }
            }

            if (!flag)
            {
                Console.WriteLine("Khong tim thay can bo nao co ho ten vua nhap!");
            }
        }
    }
}
