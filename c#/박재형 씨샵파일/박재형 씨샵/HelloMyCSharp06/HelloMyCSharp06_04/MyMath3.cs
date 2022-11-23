using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp06_04
{
    public class MyMath3
    {
        //클래스 메소드
        //static있으면 인스턴스 만들지 않아도 바로 쓴다.
    
        //y 는 선택적 매개변수, 선택적 매개변수는 필수매개변수 뒤에 쓰여야 한다.
        public static int Multi(int x, int y=10)
        {
            return y * x;
        }
        public static int Power(int x, int c = 2)
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
