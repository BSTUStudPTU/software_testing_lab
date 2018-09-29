using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class TestedClass
    {
        public bool TriangleCheck(double firstSide, double secondSide, double thirdSide)
        {
            if ((firstSide + secondSide > thirdSide) && (secondSide + thirdSide > firstSide) && (firstSide + thirdSide > secondSide))
            {
                return true;
            }
            else
                return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
