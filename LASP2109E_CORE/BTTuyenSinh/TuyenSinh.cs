using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LASP2109E_CORE.BTTuyenSinh
{
    public class TuyenSinh
    {
        List<ThiSinh> _thiSinhs;

        public TuyenSinh()
        {
            _thiSinhs = new List<ThiSinh>();
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
                        ThiSinh thiSinh = InitThiSinh();
                        _thiSinhs.Add(thiSinh);
                        break;
                    case 2://hiên thị danh sách thí sinh
                        ShowListInfo();
                        break;
                    case 3://Tìm kiếm theo số báo danh
                        string sbd = "";
                        Console.Write("Nhap vao so bao danh can tim: ");
                        sbd = Console.ReadLine();
                        FindInfoBySBD(sbd);
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
            Console.WriteLine("1. Them thi sinh");
            Console.WriteLine("2. Hien thi thong tin thi sinh va khoi thi cua thi sinh");
            Console.WriteLine("3. Tim kiem theo SBD");
            Console.WriteLine("4. Ket thuc chuong trinh");
        }

        private void DisplayMenuAddThiSinh()
        {
            Console.WriteLine("Danh sach cac loai thi sinh:");
            Console.WriteLine("1. Thi sinh thi khoi A");
            Console.WriteLine("2. Thi sinh thi khoi B");
            Console.WriteLine("3. Thi sinh thi khoi C");
        }

        private ThiSinh InitThiSinh()
        {
            ThiSinh thiSinh = new ThiSinh();

            DisplayMenuAddThiSinh();
            int selectionMenu = (int)GetInputCommon.GetInputValue(1, 3, "Lua chon loai thi sinh: ");

            Console.WriteLine("So bao danh: ");
            thiSinh.SoBaoDanh = Console.ReadLine();
            Console.WriteLine("Ho ten: ");
            thiSinh.HoTen = Console.ReadLine();
            Console.WriteLine("Dia chi: ");
            thiSinh.DiaChi = Console.ReadLine();
            thiSinh.MucDoUuTien = (int)GetInputCommon.GetInputValue(1, 3, "Muc do uu tien: ");

            switch (selectionMenu)
            {
                case 1://Thí sinh thi khối A
                    ThiSinhKhoiA thiSinhKhoiA = new ThiSinhKhoiA(thiSinh.SoBaoDanh, thiSinh.HoTen, thiSinh.DiaChi, thiSinh.MucDoUuTien);
                    thiSinhKhoiA.DiemToan = GetInputCommon.GetInputValue(0, 10, "Diem toan: ");
                    thiSinhKhoiA.DiemLy = GetInputCommon.GetInputValue(0, 10, "Diem ly: ");
                    thiSinhKhoiA.DiemHoa = GetInputCommon.GetInputValue(0, 10, "Diem hoa: ");
                    return thiSinhKhoiA;
                case 2://hiên thị danh sách thí sinh
                    ThiSinhKhoiB thiSinhKhoiB = new ThiSinhKhoiB(thiSinh.SoBaoDanh, thiSinh.HoTen, thiSinh.DiaChi, thiSinh.MucDoUuTien);
                    thiSinhKhoiB.DiemToan = GetInputCommon.GetInputValue(0, 10, "Diem toan: ");
                    thiSinhKhoiB.DiemHoa = GetInputCommon.GetInputValue(0, 10, "Diem hoa: ");
                    thiSinhKhoiB.DiemSinh = GetInputCommon.GetInputValue(0, 10, "Diem sinh: ");
                    return thiSinhKhoiB;

                case 3://Tìm kiếm theo số báo danh
                    ThiSinhKhoiC thiSinhKhoiC = new ThiSinhKhoiC(thiSinh.SoBaoDanh, thiSinh.HoTen, thiSinh.DiaChi, thiSinh.MucDoUuTien);
                    thiSinhKhoiC.DiemVan = GetInputCommon.GetInputValue(0, 10, "Diem van: ");
                    thiSinhKhoiC.DiemSu = GetInputCommon.GetInputValue(0, 10, "Diem su: ");
                    thiSinhKhoiC.DiemDia = GetInputCommon.GetInputValue(0, 10, "Diem dia: ");

                    return thiSinhKhoiC;

            }

            return thiSinh;
        }

        private void ShoInfo(ThiSinh thiSinh)
        {
            Console.WriteLine("SBD: {0}", thiSinh.SoBaoDanh);
            Console.WriteLine("Ho ten: {0}", thiSinh.HoTen);
            Console.WriteLine("Dia chi: {0}", thiSinh.DiaChi);
            Console.WriteLine("Mu do uu tien: {0}", thiSinh.MucDoUuTien);

            if (thiSinh is ThiSinhKhoiA)
            {
                var thiSinhKhoiA = thiSinh as ThiSinhKhoiA;
                Console.WriteLine("Khoi thi: Khoi A");
                Console.WriteLine("Diem toan: {0}", thiSinhKhoiA.DiemToan);
                Console.WriteLine("Diem ly: {0}", thiSinhKhoiA.DiemLy);
                Console.WriteLine("Diem hoa: {0}", thiSinhKhoiA.DiemHoa);
            }
            else if (thiSinh is ThiSinhKhoiB)
            {
                var thiSinhKhoiB = thiSinh as ThiSinhKhoiB;
                Console.WriteLine("Khoi thi: Khoi B");
                Console.WriteLine("Diem toan: {0}", thiSinhKhoiB.DiemToan);
                Console.WriteLine("Diem hoa: {0}", thiSinhKhoiB.DiemHoa);
                Console.WriteLine("Diem sinh: {0}", thiSinhKhoiB.DiemSinh);
            }
            else
            {
                var thiSinhKhoiC = thiSinh as ThiSinhKhoiC;
                Console.WriteLine("Khoi thi: Khoi C");
                Console.WriteLine("Diem van: {0}", thiSinhKhoiC.DiemVan);
                Console.WriteLine("Diem su: {0}", thiSinhKhoiC.DiemSu);
                Console.WriteLine("Diem dia: {0}", thiSinhKhoiC.DiaChi);
            }
        }

        private void ShowListInfo()
        {
            int i = 1;
            foreach(var thiSinh in _thiSinhs)
            {
                Console.WriteLine("Thong tinh thi sinh thu {0}:", i++);

                ShoInfo(thiSinh);
            }
        }

        private void FindInfoBySBD(string sbd)
        {
            bool flag = false;

            foreach (var thiSinh in _thiSinhs)
            {
                if(thiSinh.SoBaoDanh.Equals(sbd))
                {
                    Console.WriteLine("Thong tinh thi sinh can tim:");

                    ShoInfo(thiSinh);

                    flag = true;

                    break;
                }    
            }

            if(!flag)
            {
                Console.WriteLine("Khong tim thay thi sinh co so bao danh vua nhap!");
            }    
        }
    }
}
