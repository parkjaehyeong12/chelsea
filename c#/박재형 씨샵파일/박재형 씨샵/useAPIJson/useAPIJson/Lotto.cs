﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace useAPIJson
{
    public class Lotto
    {
        public string drwNo1 { get; set; }//1자리
        public string drwNo2 { get; set; }//2
        public string drwNo3 { get; set; }//3
        public string drwNo4 { get; set; }//4
        public string drwNo5 { get; set; }//5
        public string drwNo6 { get; set; }//6
        public string bnusNo { get; set; }//보너스
        public string drwNo { get; set; }//회차
        public string drwNoDate { get; set; }//날짜

        public Lotto(string drwNo1, string drwNo2, string drwNo3, string drwNo4,
            string drwNo5, string drwNo6, string bnusNo, string drwNo, string drwNoDate)
        {
            this.drwNo1 = drwNo1;
            this.drwNo2 = drwNo2;
            this.drwNo3 = drwNo3;
            this.drwNo4 = drwNo4;
            this.drwNo5 = drwNo5;
            this.drwNo6 = drwNo6;
            this.bnusNo = bnusNo;
            this.drwNo = drwNo;
            this.drwNoDate = drwNoDate;
        }


    }
}
