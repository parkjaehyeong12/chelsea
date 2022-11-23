using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 아침
{
    public class Jik
    {
        private int garo;
        private int sero;


        public int wide()
        {
            return (this.garo * this.sero);
        }
        public void setGaro(int g)
        {
            this.garo = g;
        }
        public void setSero(int s)
        {
            this.sero = s;
        }
        public int getGaro()
        {
            return this.garo;
        }
        public int getSero()
        {
            return this.sero;
        }

    }
    public class Circle
    {
      
        private int r;
        public static double pi = 3.14;      
        public double wide()
        {
            return this.r * this.r *pi;
        }
        public int getR()
        {
            return this.r;
        }
        public void setR(int r)
        {
            this.r = r;
        }
        
    }

    public class Jung : Jik
    {
        private int height;

        public void setHeight(int h)
        {
            this.height = h;
        }

       public int bupi()
        {
            return (getHeight() * getGaro() * getSero());
        }
        public int getHeight()
        {
            return this.height;
        }
    }

    public class Gu : Circle
    {
        public double bupi()
        {
            return ((4.0 / 3.0) * (getR() * getR() * getR())*pi);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Jik j1 = new Jik();
            Console.Write("가로 ");
            j1.setGaro(int.Parse(Console.ReadLine()));
            Console.Write("세로 ");
            j1.setSero(int.Parse(Console.ReadLine()));
            Console.WriteLine("넓이: "+j1.wide());
            
            Jung j2 = new Jung();
            Console.Write("가로 ");
            j2.setGaro(int.Parse(Console.ReadLine()));

            Console.Write("세로 ");
            j2.setSero(int.Parse(Console.ReadLine()));

            Console.Write("높이 ");
            j2.setHeight(int.Parse(Console.ReadLine()));
            Console.WriteLine(j2.getGaro());
            Console.WriteLine(j2.getSero());
            Console.WriteLine(j2.getHeight());

            Console.WriteLine("부피는: " + j2.bupi());


            Circle c1 = new Circle();
            Console.Write("반지름 ");
            c1.setR(int.Parse(Console.ReadLine()));
            Console.WriteLine("넓이: "+c1.wide());

            Gu g1 = new Gu();
            g1.setR(c1.getR());
            Console.WriteLine("부피: "+g1.bupi());

                        
        }
    }
}
