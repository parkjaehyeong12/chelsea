using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp09_02
{
    public class Product
    {
        public int Id;//데이터그리드뷰에 나타나지 않음 //get; set; 안했으니까
        //productBindingSource
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
