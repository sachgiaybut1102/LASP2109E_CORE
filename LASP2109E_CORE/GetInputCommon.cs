using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LASP2109E_CORE
{
    public static class GetInputCommon
    {
        public static double GetInputValue(double minValue, double maxValue, string content)
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
    }
}
