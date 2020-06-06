using System;
using System.Collections.Generic;
using System.Text;

namespace geometricFigure
{
    class Circle : Figura, IFoo
    {
        double r;

        public Circle(double r, string color)
        {
            this.r = r;
            Colour1 = color;
        }

        public virtual void Proverka() // проверка
        {
            bool p = false;
            if (this.r > 0)
            {
                p = true;
            }
            if (p != true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Фигура не является кругом");          
                Console.ReadLine();
                Environment.Exit(-1);
            }
        }

        public override double Area()
        {
            return r * r * Math.PI;
        }

        public override double Perimetr()
        {
            return 2 * r * Math.PI;
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
