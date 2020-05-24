using System;
using System.Text;

namespace geometricFigure
{
    class Circle : Figura
    {
        double r;

        public Circle(double r)
        {
            this.r = r;
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
    }
}
