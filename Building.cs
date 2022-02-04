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
            set
            {
                if (address == null)
                    address = value;
                else
                {
                    string noName = "Без адреса";
                    address = noName;
                }
            }

        }
        float length;
        public float Length
        {
            get { return length; }
            set
            {
                if (length <0)
                    length = 0;
                else { length = value; }
            }
        }
        float width;
        public float Width
        {
            get { return width; }
            set
            {
                if (width <0)
                    width = 0;
                else { width = value; }
            }
        }
        float height;
        public float Height
        {
            get { return height; }
            set
            {
                if (height < 0)
                    height = 0;
                else { height = value; }
            }
        }

        public Building(string address, float length, float width, float height)
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

