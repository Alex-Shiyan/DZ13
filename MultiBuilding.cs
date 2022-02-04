using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace DZ13
//{
//    internal sealed class MultiBuilding : Building
//    {
//        int level;
//        public MultiBuilding(string address, float length, float width, float heightint, int level)
//            : base(address, length, width, heightint)
//        {
//            this.level = level;
//        }
//        public string Print()
//        {
//            string result = base.Print();
//            result += $"\nЭтажность: \t{level}";
//            return result;
//        }

//    }
//}
namespace DZ13
{
    internal sealed class MultiBuilding : Building
    {
        int level;
        public int Level
        {
            get { return level; }
            set
            {
                if (value < 0) { level = 0; }
                else { level = value; }
            }
        }
        public MultiBuilding(string address, int length, int width, int height, int level)
            : base(address, length, width, height)
        {
            this.Level = level;
        }
        public string Print()
        {
            string result = base.Print();
            result += $"\nЭтажность: \t{level}";
            return result;
        }

    }
}
