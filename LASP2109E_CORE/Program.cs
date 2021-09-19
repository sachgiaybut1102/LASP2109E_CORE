using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LASP2109E_CORE.Model;
using LASP2109E_CORE.Enum;

namespace LASP2109E_CORE
{
    class Program
    {
        static void Main(string[] args)
        {
            // PhuongTrinhBacNhat();
            //TenCuaSo();
            //TimGiaTriLonNhatCuaHaiSo();
            //TimGiaTriLonNhatCuaBaSo();
            //HienThiABC();
            // HienThiABCDungFor();
            //TongSoChan();
            //HienThiTamGiac();
            //TongSoUoc();
            //TinhTong();
            InDayNguoc();
            Console.ReadKey();
        }

        private static void InDayNguoc()
        {
            int[] arr;
            int n;

            bool flag;

            //Nhập và lấy số lượng n phần tử
            do
            {
                flag = true;

                Console.Write("Nhap vao n phan tu: ");

                //Xử lý bắt buộc nhập vào 1 số chứ không phải 1 chữ;
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    if (!(0 < n && n <= 100))
                    {
                        Console.WriteLine("n phai nam trong khoang 0 < n <= 100, vui long nhap lai!");
                        flag = false;
                    }

                }
                else
                {
                    Console.WriteLine("Gia tri nhap vao phai la mot so, vui long nhap lai!");
                    flag = false;
                }

            } while (!flag);

            //Khởi tạo mảng
            arr = new int[n];

            //Duyệt mảng và nhập giá trị
            for (int i = 0; i < n; i++)
            {
                do
                {
                    flag = true;

                    Console.Write("A[{0}] = ", i);

                    //Xử lý bắt buộc nhập vào 1 số chứ không phải 1 chữ;
                    if (!int.TryParse(Console.ReadLine(), out arr[i]))
                    {
                        Console.WriteLine("Gia tri nhap vao phai la mot so, vui long nhap lai!");
                        flag = false;
                    }

                } while (!flag);
            }

            //Duyệt mảng và in dãy vừa nhập
            ///3, 4, 5
            Console.Write("Day so vua nhap la: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i]);

                if (i < n - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();

            Console.Write("Day so theo thu tu nguoc la: ");
            //Duyệt mảng và in ngược dãy
            //5, 4, 3
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);

                if (i > 0)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            //Bài 2
            //Câu a: Tính tổng các số chẵn và tổng các số lẻ
            Console.WriteLine("Bai 2");
            Console.WriteLine("Cau a: Tinh tong cac so chan va tong cac so le");
            int tongChan = 0;
            int tongLe = 0;

            foreach (int num in arr)
            {
                if (num % 2 == 0)
                {
                    tongChan += num;
                }
                else
                {
                    tongLe += num;
                }
            }

            Console.WriteLine("Tong cac so chan trong mang la: {0}", tongChan);
            Console.WriteLine("Tong cac so le trong mang la: {0}", tongLe);

            //Câu b: Tính hiệu số chẵn và số lẻ
            Console.WriteLine("Cau b: Tinh hieu so chan va so le");
            Console.WriteLine("Hieu so chan le la: {0}", tongChan - tongLe);

            //câu c: Tìm các số xuất hiện một lần trong mảng và in ra
            Console.WriteLine("Cau c: Tim cac so xuat hien mot lan trong mang va in ra");
            Console.Write("Cac so xuat hien 1 lan trong mang la: ");

            bool flag1 = false;
            foreach (int num in arr)
            {
                int count = 0;
                bool flag2 = true;
                foreach (int numCheck in arr)
                {
                    if (numCheck == num)
                    {
                        count++;

                        if (count > 1)
                        {
                            flag2 = false;
                            break;
                        }
                    }
                }

                if (flag2)
                {
                    if (flag1)
                    {
                        Console.Write(", ");
                    }

                    Console.Write(num);

                    flag1 = true;
                }
            }

            if (!flag1)
            {
                Console.Write("Khong co gia tri nao trong mang la xuat hien 1 lan!");
            }

            Console.WriteLine();

            //Câu d: Tìm số xuất hiện nhiều nhất trong mảng
            Console.WriteLine("Cau d: Tim so xuat hien nhieu nha trong mang");
            int maxCount = 0;
            int maxNum = 0;

            foreach (int num in arr)
            {
                int count = 0;
                foreach (int numCheck in arr)
                {
                    if (numCheck == num)
                    {
                        count++;
                    }
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    maxNum = num;
                }
            }

            if (maxCount > 0)
            {
                Console.WriteLine("{0} la so xuat hien nhieu nhat trong mang voi {1} lan", maxNum, maxCount);
            }
            else
            {
                Console.WriteLine("Khong co so la co hien thi nhieu nhat trong mang!");
            }
        }

        private static void TinhTong()
        {
            int[] arr;
            int n;
            int tong = 0;

            bool flag;

            //Nhập và lấy số lượng n phần tử
            do
            {
                flag = true;

                Console.Write("Nhap vao n phan tu: ");

                //Xử lý bắt buộc nhập vào 1 số chứ không phải 1 chữ;
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    if (!(0 < n && n <= 100))
                    {
                        Console.WriteLine("n phai nam trong khoang 0 < n <= 100, vui long nhap lai!");
                        flag = false;
                    }

                }
                else
                {
                    Console.WriteLine("Gia tri nhap vao phai la mot so, vui long nhap lai!");
                    flag = false;
                }

            } while (!flag);

            //Khởi tạo mảng
            arr = new int[n];

            //Duyệt mảng và nhập giá trị
            for (int i = 0; i < n; i++)
            {
                do
                {
                    flag = true;

                    Console.Write("A[{0}] = ", i);

                    //Xử lý bắt buộc nhập vào 1 số chứ không phải 1 chữ;
                    if (!int.TryParse(Console.ReadLine(), out arr[i]))
                    {
                        Console.WriteLine("Gia tri nhap vao phai la mot so, vui long nhap lai!");
                        flag = false;
                    }

                } while (!flag);
            }

            //Duyệt mảng và tính tổng
            foreach (int num in arr)
            {
                tong += num;
            }

            Console.WriteLine("Tong gia tri trong mang = {0}", tong);
        }

        private static void TongSoUoc()
        {
            int n;
            bool flag;
            int s = 0;

            do
            {
                flag = true;

                Console.Write("Nhap vao gia tri n (0 < n < 1000):");
                n = int.Parse(Console.ReadLine());

                if (!(0 < n && n < 1000))
                {
                    Console.WriteLine("n khong nam trong khoang gia tri cho phep, vui long nhap lai!!!");
                    flag = false;
                }
            } while (!flag);

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    s++;
                }
            }

            Console.WriteLine("Tong US cua {0} = {1}", n, s);
        }

        private static void HienThiTamGiac()
        {
            int n = 4;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        private static void TongSoChan()
        {
            int s = 0;

            int[] a = new int[5] { 3, 4, 6, 7, 1 };

            foreach (int m in a)
            {
                if (m % 2 == 0)
                {
                    s += m;
                }
            }

            Console.WriteLine("S = {0}", s);
        }

        private static void HienThiABCDungFor()
        {
            for (int d = 1; d <= 10; d++)
            {
                Console.WriteLine("{0} - ABC", d);
            }
        }

        private static void HienThiABC()
        {
            int d = 1;

            while (d <= 10)
            {
                Console.WriteLine("{0} - ABC", d);
                d++;
            }
        }

        private static void TimGiaTriLonNhatCuaHaiSo()
        {
            int a;
            int b;

            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());

            if (b > a)
            {
                a = b;
            }

            Console.WriteLine("Gia tri lon nhat = {0}", a);
        }

        private static void TimGiaTriLonNhatCuaBaSo()
        {
            int a;
            int b;
            int c;

            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = int.Parse(Console.ReadLine());

            if (b > a && b > c)
            {
                a = b;
            }
            else if (c > a && c > b)
            {
                a = c;
            }

            Console.WriteLine("Gia tri lon nhat = {0}", a);
        }

        private static void TenCuaSo()
        {
            int n;

            Console.Write("Nhap vao gia tri cua n (0 < n <= 5): ");
            n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine("Mot");
                    break;
                case 2:
                    Console.WriteLine("Hai");
                    break;
                case 3:
                    Console.WriteLine("Ba");
                    break;
                case 4:
                    Console.WriteLine("Bon");
                    break;
                case 5:
                    Console.WriteLine("Nam");
                    break;
                default:
                    Console.WriteLine("Gia tri khong hop le");
                    break;
            }
        }

        private static void PhuongTrinhBacNhat()
        {
            int a;
            int b;

            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phuong trinh co vo so nghiem");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
            }
            else
            {
                Console.WriteLine("Nghiem cua phuong trinh =  {0}", (float)-b / a);
            }
        }

        private static void CauTrucReNhanh()
        {
            int n;

            Console.Write("Nhap vao so n: ");
            n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                n++;
            }

            Console.WriteLine("Ket qua n = {0}", n);
        }

        private void ChuyenDoiNamAm()
        {
            int year;

            Console.Write("Nhap vao nam can chuyen: ");
            year = int.Parse(Console.ReadLine());

            Console.WriteLine("Nam am lich la: {0} {1}", (ENumCan)(year % 10), (ENumChi)(year % 12));

            Console.ReadKey();
        }
    }
}
