﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp02_02
{
    public class KBBank //:ICloneable
    {
        public string Name { get; set; }
        public int Balance { get; set; }
        public void info()
        {
            Console.WriteLine("이름:" + Name);
            Console.WriteLine("잔액:" + Balance);
        }
        //public object Clone()
        //{
        //    return new KBBank();
        //}
    }
}
