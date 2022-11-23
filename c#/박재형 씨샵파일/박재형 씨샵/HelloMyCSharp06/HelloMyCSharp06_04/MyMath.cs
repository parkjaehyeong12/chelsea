using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp06_04
{
    public class MyMath
    {
        public int Power(int x)
        {
            return x * x;
        }
        public int Multi(int x, int y)
        {
            return y * x;
        }
        public int Power(int x, int c)
        {   //Math.Pow는 double타입
            return (int)Math.Pow(x, c);
            int result = 1;
            for (int i = 0; i < c; i++)
            {
                result*= x;
            }
            return result;
        }
    }
}
