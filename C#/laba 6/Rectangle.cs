using System;
using System.Collections.Generic;
using System.Text;

namespace geometricFigure
{
    class Rectangle : Figura
    {
        double a, b;

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public virtual void Proverka() // проверка
        {
            bool p = false;
            if (this.a > 0 && this.b > 0)
            {
                p = true;
            }
            if (p != true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Фигура не является прямоугольником");
                Console.ReadLine();
                Environment.Exit(-1);
            }
        }

        public override double Area()
        {
            return a * b;
        }

        public override double Perimetr()
        {
            return (a + b) * 2;
        }

        class Kvadrat : Figura
        {
            double a;
            public Kvadrat(double a)
            {
                this.a = 6;
            }
            public override double Area()
            {
                return a * a;
            }

            public override double Perimetr()
            {
                return a * 4;
            }
        }
    }
}
