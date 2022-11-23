using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 수학
{
    public class MyMath
    {
        public int Power(int x)
        {
            return x * x;
        }
        public int Power(int x, int c)
        {
            int count = 1;
            for (int i = 0; i < c; i++)
            {
                count *= x;
            }
            return count;
        }
        public int Multi(int x, int y)
        {
            return (x * y);
        }
    }
}
