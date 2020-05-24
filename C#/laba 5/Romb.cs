using System;
using System.Text;

namespace geometricFigure
{
    class Romb : Figura
    {
        double a, h;
        public Romb(double a, double h)
        {
            this.a = a;
            this.h = h;
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
    }
}
