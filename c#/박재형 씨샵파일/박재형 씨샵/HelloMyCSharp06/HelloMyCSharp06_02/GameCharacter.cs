using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp06_02
{
    public class GameCharacter
    {
        //게임 캐릭터의 수
        //캐릭터 생성시 카운터 증가
        //캐릭터의 수는 공통적으로 쓰는값
        public static int Count = 0;
        public string id { get; set; }
        public GameCharacter()
        {
            Count++;
        }
    }
}
