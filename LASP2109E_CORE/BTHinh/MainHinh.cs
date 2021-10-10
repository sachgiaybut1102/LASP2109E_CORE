using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LASP2109E_CORE.BTHinh
{
    public class MainHinh
    {
        private List<Hinh> _hinhs;

        public MainHinh()
        {
            _hinhs = new List<Hinh>();
        }

        public void Run()
        {
            while (true)
            {
                DisplayFunction();
                int selectionMenu = (int)GetInputValue(1, 10, "Lua chon chuc nang: ");

                switch (selectionMenu)
                {
                    case 1://Thêm hình chữ nhật
                        double chieuDai = GetInputValue(0, 9999999, "Nhap vao chieu dai hinh chu nhat: ");
                        double chiuRong = GetInputValue(0, 9999999, "Nhap vao chieu rong hinh chu nhat: ");
                        HinhChuNhat hinhChuNhat = new HinhChuNhat(chieuDai, chiuRong);

                        _hinhs.Add(hinhChuNhat);
                        break;
                    case 2://Thêm hình vuông
                        double kichThuc = GetInputValue(0, 9999999, "Nhap vao kich thuoc cac canh: ");
                        HinhVuong hinhVuong = new HinhVuong(kichThuc);

                        _hinhs.Add(hinhVuong);
                        break;
                    case 3://Thêm hình tròn
                        double r = GetInputValue(0, 9999999, "Nhap vao ban kinh: ");
                        HinhTron hinhTron = new HinhTron(r);

                        _hinhs.Add(hinhTron);
                        break;
                    case 4:// Thêm hình tam giác
                        double a = GetInputValue(0, 9999999, "Nhap vao kich thuoc canh a: ");
                        double b = GetInputValue(0, 9999999, "Nhap vao kich thuoc canh b: ");
                        double c = GetInputValue(0, 9999999, "Nhap vao kich thuoc canh c: ");

                        HinhTamGiac hinhTamGiac = new HinhTamGiac(a, b, c);

                        _hinhs.Add(hinhTamGiac);
                        break;
                    case 5://thống kê số lượng các hình
                        ShapeCountStatistics();
                        break;
                    case 6://tính chu vi các hình
                        CalculatePerimeterShapes();
                        break;
                    case 7://tính diện tích các hình
                        CalculateAreaShapes();
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        Console.WriteLine("Ket thuc chuong trinh!");
                        return;
                }
            }
        }

        private void DisplayFunction()
        {
            Console.WriteLine("Danh muc chuc nang:");
            Console.WriteLine("1. Them hinh chu nhat");
            Console.WriteLine("2. Them hinh vuong");
            Console.WriteLine("3. Them hinh tron");
            Console.WriteLine("4. Them hinh tam giac");
            Console.WriteLine("5. Thong ke so luong cac hinh");
            Console.WriteLine("6. Tinh chu vi cac hinh");
            Console.WriteLine("7. Tinh dien tich cac hinh");
            Console.WriteLine("8. Hien thi danh sach hinh");
            Console.WriteLine("9. Hinh co chu vi lon nhat");
            Console.WriteLine("10. Hinh co dien tich lon nhat");
            Console.WriteLine("11. Ket thuc chuong trinh");
        }

        private double GetInputValue(double minValue, double maxValue, string content)
        {
            double num;
            bool flag;

            do
            {
                flag = true;

                Console.Write(content + ": ");
                if (double.TryParse(Console.ReadLine(), out num))
                {
                    if (!(minValue <= num && num <= maxValue))
                    {
                        Console.WriteLine("Gia tri nhap vao phai lon nhat {0} va nho hon {1}, vui long nhap lai gia tri!", minValue, maxValue);
                        flag = false;
                    }
                }
                else
                {
                    flag = false;
                    Console.WriteLine("Gia tri vua nhap vao ban phim khong phai la 1 so, vui long nhap lai gia tri!");
                }
            } while (!flag);

            return num;
        }

        private void ShapeCountStatistics()
        {
            int countHinhChuNhat = 0;
            int countHinhTamGiac = 0;
            int countHinhTron = 0;
            int countHinhVuong = 0;

            foreach (var hinh in _hinhs)
            {
                if (hinh is HinhChuNhat)
                {
                    countHinhChuNhat++;
                }
                else if (hinh is HinhTamGiac)
                {
                    countHinhTamGiac++;
                }
                else if (hinh is HinhTron)
                {
                    countHinhTron++;
                }
                else
                {
                    countHinhVuong++;
                }
            }

            Console.WriteLine("So luong cac hinh co trong danh sach la: ");
            Console.WriteLine("Hinh chu nhat: {0} hinh.", countHinhChuNhat);
            Console.WriteLine("Hinh vuong: {0} hinh.", countHinhVuong);
            Console.WriteLine("Hinh tron: {0} hinh.", countHinhTron);
            Console.WriteLine("Hinh tam giac: {0} hinh.", countHinhTamGiac);

        }

        private void CalculatePerimeterShapes()
        {
            int i = 1;
            Console.WriteLine("Chu vi cac hinh la: ");
            foreach (var hinh in _hinhs)
            {
                string tenHinh = "";
                if (hinh is HinhChuNhat)
                {
                    tenHinh = "chu nhat";
                }
                else if (hinh is HinhTamGiac)
                {
                    tenHinh = "tam giac";
                }
                else if (hinh is HinhTron)
                {
                    tenHinh = "tron";
                }
                else
                {
                    tenHinh = "vuong";
                }

                Console.WriteLine("Hinh {0}: P {1} = {2}", i, tenHinh, hinh.ChuVi());
            }
        }

        private void CalculateAreaShapes()
        {
            int i = 1;
            Console.WriteLine("Dien tich cac hinh la: ");
            foreach (var hinh in _hinhs)
            {
                string tenHinh = "";
                if (hinh is HinhChuNhat)
                {
                    tenHinh = "chu nhat";
                }
                else if (hinh is HinhTamGiac)
                {
                    tenHinh = "tam giac";
                }
                else if (hinh is HinhTron)
                {
                    tenHinh = "tron";
                }
                else
                {
                    tenHinh = "vuong";
                }

                Console.WriteLine("Hinh {0}: S {1} = {2}", i, tenHinh, hinh.DienTich());
            }
        }

    }
}
