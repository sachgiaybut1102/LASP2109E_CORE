using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LASP2109E_CORE
{
    public class Cat
    {
        //Khai báo thuộc tính và phương thức get set cho thuộc tính
        private double _weight;
        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        private double _height;
        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        //Khai báo biến static
        public static int Count = 0;

        public Cat()
        {
            _height = 300;
            _weight = 500;

            Count++;
        }

        public Cat(double weight, double height)
        {
            _height = height;
            _weight = weight;

            Count++;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Height: {0}", _height);
            Console.WriteLine("Weight: {0}", _weight);
            Console.WriteLine("Count Cat: {0}", Count);


        }
    }
}
