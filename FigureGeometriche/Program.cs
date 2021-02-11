using System;

namespace FigureGeometriche
{
    class Program
    {
        static void Main(string[] args)
        {
            Figura quadrato = new Figura(12,13);

            quadrato.Area(12,13);

            Console.WriteLine("l'area del quadrato è: "+ quadrato.Area(12, 13));

            Cerchio circle = new Cerchio(24);

            circle.Area(24);

            Console.WriteLine("l'area del cerchio è: " + circle.Area(24));

            Triangolo triangle = new Triangolo(12, 22);

            triangle.Area(12, 22);

            Console.WriteLine("l'area del triangolo è: " + triangle.Area(12,22));


        }

        public class Figura
        {
            protected int x;
            protected int y;


            public Figura(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            

            public virtual int Area(int x, int y)
            {
                return x * y;
            }
        }


        public class Cerchio : Figura
        {
           int raggio;

            public Cerchio(int raggio) : base(raggio,0)
            {
                this.raggio = raggio;
            }

            public double Area(int raggio)
            {
                return raggio * raggio * 3.14;
            }
            
        }

        public class Triangolo : Figura
        {
            int b;
            int h;

            public Triangolo(int b, int h) : base(b,h)
            {
                this.b = b;
                this.h = h;
            }

            public double Area(int b, int h)
            {
                return 0.5 * b * h;
            }

        }
    }
}
