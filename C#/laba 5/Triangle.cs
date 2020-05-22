using System;
using System.Collections.Generic;
using System.Text;

namespace geometricFigure
{
    class Triangle : Figura
    {
        double a, b, c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public virtual void Proverka()  // проверка
        {
            bool p = false;
            if ((this.a + this.b) > this.c & (this.a + this.c) > this.b & (this.b + this.c) > this.a)
            {
                p = true;
            }
            if (p != true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Фигура не является трeугольником");
                Console.ReadLine();
                Environment.Exit(-1);
            }
        }

        public override double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public override double Perimetr()
        {
            return (a + b + c);
        }
    }
}
