using System;
using System.Collections.Generic;
using System.Text;

namespace geometricFigure
{
    class Rectangle : Figura, IFoo
    {
        double a, b;

        public Rectangle(double a, double b, string color)
        {
            this.a = a;
            this.b = b;
            Colour1 = color;
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

        void IFoo.GetInfo()// явная реализация
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Ваша фигура имеет {Colour1} цвет и следующие параметры:");
            Console.ResetColor();
        }
    }
}
