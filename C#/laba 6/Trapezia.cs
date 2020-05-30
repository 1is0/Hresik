using System;
using System.Collections.Generic;
using System.Text;

namespace geometricFigure
{
    class Trapezia : Figura
    {
        double a, b, c, d, h;
        public Trapezia(double a, double b, double c, double d, double h)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.h = h;
        }

        public virtual void Proverka() // проверка
        {
            bool p = false;
            if (this.a > 0 && this.b > 0 && this.c > 0 && this.d > 0 && this.h > 0)
            {
                p = true;
            }
            if (p != true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Фигура не является трапецией");
                Console.ReadLine();
                Environment.Exit(-1);
            }
        }

        public override double Area()
        {
            return ((a + b) / 2) * h;
        }

        public override double Perimetr()
        {
            return a + b + c + d;
        }
    }
}
