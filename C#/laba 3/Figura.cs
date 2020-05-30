using System;
using System.Text;

namespace geometricFigure
{
    class Figura
    {
        double a, b, c, d;

        public Figura(double a)
        {
            this.a = a;
        }
        public Figura(double a, double b)
        {
            this.a = a;
            this.b = b;

        }
        public Figura(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public Figura(double a, double b, double c, double d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public void Proverka(double a) // проверка
        {
            bool p = false;
            if (this.a > 0 )
            {
                p = true;
            }
            if (p != true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Это не фигура");
                Console.ReadLine();
                Environment.Exit(-1);
            }
        }

        public void Proverka(double a, double b) // проверка
        {
            bool p = false;
            if (this.a > 0 && this.b > 0 )
            {
                p = true;
            }
            if (p != true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Это не фигура");
                Console.ReadLine();
                Environment.Exit(-1);
            }
        }

        public void Proverka(double a, double b, double c) // проверка
        {
            bool p = false;
            if (this.a > 0 && this.b > 0 && this.c > 0)
            {
                p = true;
            }
            if (p != true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Это не фигура");
                Console.ReadLine();
                Environment.Exit(-1);
            }
        }

        public void Proverka(double a, double b, double c, double d) // проверка
        {
            bool p = false;
            if (this.a > 0 && this.b > 0 && this.c > 0 && this.d > 0)
            {
                p = true;
            }
            if (p != true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Это не фигура");
                Console.ReadLine();
                Environment.Exit(-1);
            }
        }

        public double Perimetr(double a)
        {
            return a + a + a + a;
        }

        public double Perimetr(double a, double b)
        {
            return a + a + b + b;
        }

        public double Perimetr(double a, double b, double c)
        {
            return a + b + c ;
        }

        public double Perimetr(double a, double b, double c, double d)
        {
            return a + b + c + d;
        }
    }
}
