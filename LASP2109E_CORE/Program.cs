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
            TongSoUoc();

            Console.ReadKey();
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
                if(n % i == 0)
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
