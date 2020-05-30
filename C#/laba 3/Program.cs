using System;

namespace geometricFigure
{
    class Program
    {
        static double InputCheck()
        {
            double a;
            while (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка ввода!");
                Console.ForegroundColor = ConsoleColor.Green;
            }
            return a;
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Выберите фигуру:\n0 - треугольник\n1 - квадрат\n2 - прямоугольник\n3 - черырехугольник");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка ввода!");
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            Console.Clear();
            switch (choice)
            {
                case 0:
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Здравствуйте введите данные о фигуре: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Первая сторона: ");
                        double firstSide = InputCheck();
                        Console.WriteLine("Вторая сторона: ");
                        double secondSide = InputCheck();
                        Console.WriteLine("Третья сторона: ");
                        double thirdSide = InputCheck();
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Figura figura = new Figura(firstSide, secondSide, thirdSide);
                        figura.Proverka(firstSide, secondSide, thirdSide);
                        Console.WriteLine("Периметр треугольника: {0:#.##}", figura.Perimetr(firstSide, secondSide, thirdSide));
                        Console.WriteLine();
                        break;
                    } 
                case 1:
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Здравствуйте введите данные о фигуре: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Сторона: ");
                        double firstSide = InputCheck();
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Figura figura = new Figura(firstSide);
                        figura.Proverka(firstSide);
                        Console.WriteLine("Периметр квадрата: {0:#.##}", figura.Perimetr(firstSide));
                        Console.WriteLine();
                        break;
                    }
                case 2:
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Здравствуйте введите данные о фигуре: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Первая/третья сторона: ");
                        double firstSide = InputCheck();
                        Console.WriteLine("Вторая/четвёртая сторона: ");
                        double secondSide = InputCheck();
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Figura figura = new Figura(firstSide, secondSide);
                        figura.Proverka(firstSide, secondSide);
                        Console.WriteLine("Периметр прямоугольника: {0:#.##}", figura.Perimetr(firstSide, secondSide));
                        Console.WriteLine();
                        break;
                    }
                case 3:
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Здравствуйте введите данные о фигуре: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Первая сторона: ");
                        double firstSide = InputCheck();
                        Console.WriteLine("Вторая сторона: ");
                        double secondSide = InputCheck();
                        Console.WriteLine("Третья сторона: ");
                        double thirdSide = InputCheck();
                        Console.WriteLine("Четвёртая сторона: ");
                        double fourthSide = InputCheck();
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Figura figura = new Figura(firstSide, secondSide,thirdSide, fourthSide);
                        figura.Proverka(firstSide, secondSide, thirdSide, fourthSide);
                        Console.WriteLine("Периметр четырёхугольник: {0:#.##}", figura.Perimetr(firstSide, secondSide, thirdSide, fourthSide));
                        Console.WriteLine();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ошибка!");
                        break;
                    }
            }
            Console.ReadLine();
        }
    }
}