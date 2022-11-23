using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloMyCSharp03
{
    public class CircularButton : Button
    {
        //protected:상속한 클래스에서만 쓸수있는 메소드
        //override 기존의 조상 클래스 메소드를 덮어쓴는 것을 의미
        protected override void OnPaint(PaintEventArgs prevent)
        {
            GraphicsPath g = new GraphicsPath();
            g.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(g);
            base.OnPaint(prevent);
        }
    }
}
