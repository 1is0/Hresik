using System;
using System.Collections.Generic;
using System.Text;

namespace geometricFigure
{
    class Romb : Figura, IFoo
    {
        double a, h;
        public Romb(double a, double h, string color)
        {
            this.a = a;
            this.h = h;
            Colour1 = color;
        }

        public virtual void Proverka() // проверка
        {
            bool p = false;
            if (this.a > 0 && this.h > 0)
            {
                p = true;
            }
            if (p != true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Фигура не является ромбом");
                Console.ReadLine();
                Environment.Exit(-1);
            }
        }

        public override double Area()
        {
            return a * h;
        }

        public override double Perimetr()
        {
            return 4 * a;
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
