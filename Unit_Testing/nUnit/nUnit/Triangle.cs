using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nUnit
{
    public class Triangle
    {
        public bool IsTriangle(double SideLength_1, double SideLength_2, double SideLength_3)
        {
            if(SideLength_1>0 && SideLength_2>0 && SideLength_3>0)
            return ((SideLength_1 + SideLength_2 > SideLength_3) && (SideLength_1 + SideLength_3 > SideLength_2) && (SideLength_2 + SideLength_3 > SideLength_1));
            return false;
        }
    }
}
