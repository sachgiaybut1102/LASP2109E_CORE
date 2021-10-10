using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LASP2109E_CORE.Model;
using LASP2109E_CORE.Enum;
using System.Threading;
using LASP2109E_CORE.BTHinh;

namespace LASP2109E_CORE
{
    class Program
    {
        private static void Main(string[] args)
        {
            MainHinh mainHinh = new MainHinh();
            mainHinh.Run();

            Console.ReadKey();
        }

        private static void passByValue(int num)
        {
            num++;
            Console.WriteLine("value in process = " + num);
        }

        private static void passByReference(ref int num)
        {
            num++;
            Console.WriteLine("value in process = " + num);
        }

        private static void DanhSach()
        {
            //List<T>
            //Khởi tạo 
            //List<int> numbers = new List<int>();

            #region Thêm
            ////Thêm một phần tử
            //numbers.Add(1);
            //HienThiDanhSach(numbers);

            //numbers.Add(2);
            //HienThiDanhSach(numbers);

            ////Chèn 1 phần tử vào vị trí lựa chọn
            //numbers.Insert(1, 3);
            //HienThiDanhSach(numbers);

            ////Đọc 1 phần từ
            //Console.WriteLine("Gia tri cua phan tu co index = 1 la: {0}", numbers[1]);

            ////Xử lý với nhiều phần tử
            ////Thêm nhiều phần tử cùng lúc hoặc thêm 1 danh sách vào 

            //Console.WriteLine("-------Xu ly voi nhieu phan tu--------");
            //int[] arrNumbers = { 4, 5, 6, 7, 2 };

            //numbers.AddRange(arrNumbers);
            //HienThiDanhSach(numbers);
            #endregion

            #region
            ////Tìm kiếm
            ////Tìm kiếm vị trí đầu tiên của phần tử
            //Console.WriteLine("Vi tri dau tien cua phan tu co gia tri = 2 la: {0}", numbers.IndexOf(2));
            //Console.WriteLine("Vi tri cuoi cung cua phan tu co gia tri = 2 la: {0}", numbers.LastIndexOf(2));
            //Console.Write("Tim tat ca cac phan tu co gia tri = 2 la: ");
            //List<int> indexs = numbers.FindAll(t => t == 2);
            //foreach (int i in indexs)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();


            ////Sắp xếp
            ////Đưa hàm callback vào phương thức sort
            ////Sắp xếp giảm dần
            //numbers.Sort((num1, num2) =>
            //{
            //    return num1 > num2 ? -1 : ((num1 < num2) ? 1 : 0);
            //});
            //HienThiDanhSach(numbers);


            ////Kiểm tra xem phần tử có được chứa trong danh sách hay không

            //bool result = numbers.Contains(2);
            //Console.WriteLine("So 2 co nam trong danh sach hay khong?: {0}", result);
            //Console.WriteLine("So 10 co nam trong danh sach hay khong?: {0}", numbers.Contains(12));

            ////Đảo ngược danh sách
            //Console.WriteLine("Dao nguoc danh sach:");
            //numbers.Reverse();
            //HienThiDanhSach(numbers);

            ////Chuyển đổi từ List sang mảng
            //int[] arrConvertNumbers = numbers.ToArray();
            //Console.WriteLine("Chuyen doi danh sach ve mang:");

            //Console.WriteLine("Danh sach du lieu trong mang la: ");
            //foreach (int number in arrConvertNumbers)
            //{
            //    Console.Write(number + " ");
            //}
            #endregion

            #region Xóa
            //Console.WriteLine("-------Xoa phan tu--------");
            //Xóa 
            //Xóa 1 phần tử
            //Console.WriteLine("-------Xoa 1 phan tu--------");
            //C1: Xóa theo đối tượng
            //Console.WriteLine("-------Xoa theo doi tuong--------");
            //numbers.Remove(4);
            //HienThiDanhSach(numbers);
            //C2: Xóa theo vị trí
            //Console.WriteLine("-------Xoa theo vi tri--------");
            //numbers.RemoveAt(1);
            //HienThiDanhSach(numbers);


            //Xóa nhiều phần tử
            //1. Xóa nhiều phần tử theo vị trí
            //Console.WriteLine("-------Xoa nhieu phan tu--------");
            // numbers.RemoveRange(2,numbers.Count - 2);
            //for(int i = 0; i < numbers.Count; i++)
            //{
            //    if(numbers[i] == 2)
            //    {
            //        numbers.RemoveRange(i, numbers.Count - i);
            //        break;
            //    }    
            //}    
            //HienThiDanhSach(numbers);
            ////2. Xóa tất cả
            //Console.WriteLine("-------Xoa tat ca--------");
            //numbers.Clear();
            //HienThiDanhSach(numbers);
            #endregion

            //BT: Viết chương trình chạy random số nguyên, tìm cả các số là số nguyên tố trong mảng
            //và sắp xếp các số nguyên đó theo tăng dần.

            //Để làm các cần dùng 1 Class có tên là Random để chạy lấy được số random
            //VD
            //Random random = new Random();
            //Console.WriteLine("Random = {0}", random.Next(1, 100000));

            //1. Tạo danh sách lưu trữ các số
            List<int> numbers = new List<int>();

            //2. Nhập số
            for (int i = 0; i < 30; i++)
            {
                Random random = new Random();
                numbers.Add(random.Next(1, 100000));
                Thread.Sleep(1);
            }

            //3. Hiển thị các số vừa nhập
            Console.WriteLine("Các số có trong danh sách là: ");
            HienThiDanhSach(numbers);

            //4. Tạo danh sách lưu các số nguyên tố
            List<int> snts = new List<int>();

            //5. Lọc ra các số là số nguyên tố có trong danh sách numbers và thêm vào danh sách snts
            foreach (int i in numbers)
            {
                if (KTSNT(i))
                {
                    snts.Add(i);
                }
            }

            //6. Hiển thị ra danh sách các số nguyên tố vừa tìm được được lưu trong danhsachs snts
            Console.WriteLine("Cac so la so nguyen to co trong danh sach la: ");
            HienThiDanhSach(snts);

            //7. Sắp xếp các số nguyên tố tăng dần
            snts.Sort();

            //8. Hiển thị danh sách các số nguyên tố sau khi sắp xếp.
            HienThiDanhSach(snts);

            //Ý tiếp theo
            //Từ danh sách các số nguyên tố từ tìm được, lọc ra các số còn lại trong danh sách
            List<int> numbers2 = new List<int>();

            foreach (int i in numbers)
            {
                //Kiểm tra i có tồn tại trong snts hay không,
                //nếu không tồn tại thì nó không là snt và ta add vào numbers2
                if (!snts.Contains(i))
                {
                    numbers2.Add(i);
                }
            }

            Console.WriteLine("Cac so khong phai la so nguyen to la: ");
            HienThiDanhSach(numbers2);
        }

        private static bool KTSNT(int num)
        {
            if (num == 2)
            {
                return true;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static void HienThiDanhSach(List<int> numbers)
        {
            Console.Write("Cac so hien co trong danh sach la: ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }


        private static void ThoiGian()
        {
            //Hiển thị thời gian hiện tại
            Console.WriteLine("Thoi gian hien tai: {0}", DateTime.Now);

            //Hiển thị các thuộc tính thời gian của một đối tượng dateTime
            DateTime dateTime = DateTime.Now;

            Console.WriteLine("Nam = {0}", dateTime.Year);
            Console.WriteLine("Thang = {0}", dateTime.Month);
            Console.WriteLine("Ngay = {0}", dateTime.Day);
            Console.WriteLine("Gio = {0}", dateTime.Hour);
            Console.WriteLine("Phut = {0}", dateTime.Minute);
            Console.WriteLine("Giay = {0}", dateTime.Second);
            Console.WriteLine("Ngay trong tuan = {0}", dateTime.DayOfWeek);
            Console.WriteLine("Ngay trong nam = {0}", dateTime.DayOfYear);


            //Tạo DateTime Truyền tham số 
            DateTime dateTime1 = new DateTime(1998, 10, 3);
            //Console.WriteLine("Truoc khi them thoi gian:");

            //HienThoiGian(dateTime1);

            //Thêm thời gian và DateTime
            dateTime1 = dateTime1.AddMonths(100);
            //Console.WriteLine("Sau khi them thoi gian:");
            //HienThoiGian(dateTime1);

            //So sánh thời gian
            int result = DateTime.Compare(dateTime, dateTime1);
            if (result == 1)
            {
                Console.WriteLine("{0} > {1}", dateTime.ToString(), dateTime1.ToString());
            }
            else if (result == -1)
            {
                Console.WriteLine("{0} < {1}", dateTime.ToString(), dateTime1.ToString());
            }
            else
            {
                Console.WriteLine("{0} = {1}", dateTime.ToString(), dateTime1.ToString());
            }


            //So sánh 2 date thông qua các toán tử
            if (dateTime > dateTime1)
            {
                Console.WriteLine("{0} > {1}", dateTime.ToString(), dateTime1.ToString());
            }
            else if (dateTime < dateTime1)
            {
                Console.WriteLine("{0} < {1}", dateTime.ToString(), dateTime1.ToString());
            }
            else
            {
                Console.WriteLine("{0} = {1}", dateTime.ToString(), dateTime1.ToString());
            }

            //Định dạng cho thời gian
            //Định dạng theo ngày tháng năm

            Console.WriteLine("Đinh dang theo ngày Viet: {0}", dateTime.ToString("dd/MM/yyyy"));
            Console.WriteLine("Đinh dang ngay thang nam gio phut giay theo ngày Viet: {0}", dateTime.ToString("dd/MM/yyyy HH:mm:ss"));
        }

        private static void HienThoiGian(DateTime dateTime)
        {
            Console.WriteLine("Nam = {0}", dateTime.Year);
            Console.WriteLine("Thang = {0}", dateTime.Month);
            Console.WriteLine("Ngay = {0}", dateTime.Day);
            Console.WriteLine("Gio = {0}", dateTime.Hour);
            Console.WriteLine("Phut = {0}", dateTime.Minute);
            Console.WriteLine("Giay = {0}", dateTime.Second);
            Console.WriteLine("Ngay trong tuan = {0}", dateTime.DayOfWeek);
            Console.WriteLine("Ngay trong nam = {0}", dateTime.DayOfYear);
        }

        private static void ChuanHoaTen()
        {
            string hoTen = "";

            Console.Write("Nhap vao ho ten: ");
            hoTen = Console.ReadLine();


            //Chuẩn hóa dữ liệu
            //B1: Đưa tất cả về viết thường và Xóa khoảng trắng ở 2 đầu chuỗi
            hoTen = hoTen.ToLower().Trim();

            //B2: Xóa các khoảng trắng thừa ở giữa 2 từ
            //B3: Viết xóa ký tự đầu
            string[] strArr = hoTen.Split(' ').ToArray();

            hoTen = "";

            foreach (string str in strArr)
            {
                if (String.IsNullOrEmpty(str))
                {
                    continue;
                }

                string str0 = str.Trim();

                if (str0.Length > 1)
                {
                    hoTen += str0[0].ToString().ToUpper() + str0.Substring(1) + " ";
                }
                else
                {
                    hoTen = str0;
                }
            }

            Console.WriteLine("Ho ten sau khi duoc chuan hoa la: {0}", hoTen);
        }

        private static void HinhTamGiac()
        {
            double a = Nhap("Canh a");
            double b = Nhap("Canh b");
            double c = Nhap("Canh c");

            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                Console.WriteLine("Dien tich tam giac la: {0}", DienTichTamGiac(a, b, c));
            }
            else
            {
                Console.WriteLine("So do 3 canh vua nhap khong phai la do dai 3 canh cua 1 tam giac!");
            }
        }

        private static double ChuViTamGiac(double a, double b, double c)
        {
            return a + b + c;
        }

        private static double DienTichTamGiac(double a, double b, double c)
        {
            double nuaChuVi = ChuViTamGiac(a, b, c) / 2;

            return Math.Sqrt(nuaChuVi * (nuaChuVi - a) * (nuaChuVi - b) * (nuaChuVi - c));
        }

        private static void HinhTron()
        {
            double r = Nhap("Ban kinh r");

            Console.WriteLine("Chu vi hình tron la: 2 * pi * {0}", r, ChuViHinhTron(r));
            Console.WriteLine("Dien tich hinh tron la: pi * {0}^2 = {1}", r, DienTichHinhTron(r));
        }

        private static double ChuViHinhTron(double r)
        {
            return 2 * Math.PI * r;
        }

        private static double DienTichHinhTron(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }

        private static void HinhChuNhat()
        {
            double chieuDai = Nhap("Chieu dai");
            double chieuRong = Nhap("Chieu rong");

            Console.WriteLine("Chu vi hinh chu nhat la: 2 * ({0} + {1}) = {2}", chieuDai, chieuRong, ChuViHinhChuNhat(chieuDai, chieuRong));
            Console.WriteLine("Dien tich hinh chu nhat la: {0} * {1} = {2}", chieuDai, chieuRong, DienTichHinhChuNhat(chieuDai, chieuRong));
        }

        private static double ChuViHinhChuNhat(double chieuDai, double chieuRong)
        {
            return 2 * (chieuDai + chieuRong);
        }

        private static double DienTichHinhChuNhat(double chieuDai, double chieuRong)
        {
            return chieuDai * chieuRong;
        }

        private static double Nhap(string tieuDe)
        {
            double num;

        NHAP:
            try
            {
                Console.Write("{0} = ", tieuDe);
                num = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Co loi xay ra, vui long nhap lai!");

                goto NHAP;
            }

            return num;
        }

        private static void HoanVi(ref int a, ref int b)
        {
            int tam = a;
            a = b;
            b = tam;

            Console.WriteLine("a = {0}, b = {1}", a, b);
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
