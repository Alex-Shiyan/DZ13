using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace DZ13
//{
//    internal class Building
//    {
//        string address;
//        float length;
//        float width;
//        float height;

//        public Building(string address, float length, float width, float height)
//        {
//            this.address = address;
//            this.length = length;
//            this.width = width;
//            this.height = height;
//        }
//        public string Print ()
//        {
//            return $"Адрес здания: \t{address}\nДлина здания: \t{length}\nШирина здания: \t{width}\nВысота здания: \t{height}";
//        }


//    }
//}

namespace DZ13
{
    internal class Building
    {
        string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        int length;
        public int Length

        {
            
            set
            {
                if (value<0) { length = 0;}
                else { length = value; }
            }
            get { return length; }
        }
        int width;
        public int Width
        {
            get { return width; }
            set 
            {
                if (value < 0) {width = 0; }
                else { width = value; }
            }
        }

        private int height;
        public int Height
        {
            get { return height; }
            set
            {
                if (value < 0) { height = 0; }
                else { height = value; }
            }
        }

        public Building(string address, int length, int width, int height)
        {
            this.Address = address;
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        public string Print ()
        {
            return $"Адрес здания: \t{address}\nДлина здания: \t{length}\nШирина здания: \t{width}\nВысота здания: \t{height}";
        }


    }
}

