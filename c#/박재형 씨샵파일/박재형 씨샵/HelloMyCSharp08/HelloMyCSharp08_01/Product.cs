using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp08_01
{
    public class Product : IComparable<Product>
    {
        //ICompareble<Product> 대신 ICompareable만
        //적으면
        //public int CompareTo(object other) 매개변수가 obejct가 도니다.
        //그러면 별도의 형변환을 해줘야 한다.
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public int CompareTo(Product other)
        {
            //이 값이 음수 , 0, 양수냐에 따라서 정렬이 달라진다.

            //내림차순
            //return -price.CompareTo(other.price);
            return other.price.CompareTo(price);


            //throw new NotImplementedException();//미구현 오류
        }
    }
}
