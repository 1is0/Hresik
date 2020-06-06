using System;
using System.Collections.Generic;
using System.Text;

namespace geometricFigure
{
    class Trapezia : Figura, IFoo
    {
        double a, b, c, d, h;
        public Trapezia(double a, double b, double c, double d, double h, string color)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.h = h;
            Colour1 = color;
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

        void IFoo.GetInfo() // явная реализация
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Ваша фигура имеет {Colour1} цвет и следующие параметры:");
            Console.ResetColor();
        }
    }
}
