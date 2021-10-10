using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LASP2109E_CORE
{
    public class Point
    {       

        //Khai báo các thuộc tính
        public int x;
        public int y;

        //Hàm tạo không tham số
        public Point()
        {

        }

        //Hàm tạo có tham số
        public Point(int x, int y)
        {
            this.x = x; 
            this.y = y; 
        }

        //Khai báo các phương thức
        public void Hien()
        {
            Console.Write("toa do :(");
            Console.Write("{0},{1}", x, y);
            Console.WriteLine(")");
        }

        public void Chuyen()
        {
            x = -x;
            y = -y;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap toa do :");
            Console.Write("X = ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Y = ");
            y = int.Parse(Console.ReadLine());
        }

        public void Move(int x0, int y0)
        {
            x += x0;
            y += y0;
        }


        //Khởi tạo hàm hủy
        ~Point()
        {
            Console.WriteLine("Huy");
        }
    }
}
