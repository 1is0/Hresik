using System;

namespace geometricFigure
{
    class Program
    {
        //делегаты
        delegate void Show();
        delegate void MenuHandler(string message);

        private static void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Здравствуйте!");
        }

        private static void Goodbye()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("До свидания!");
        }
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

        enum Figa
        {
            Circle = 0,
            Romb = 1,
            Trapezia = 2,
            Triangle = 3,
            Rectangle = 4
        }

        static void Main(string[] args)
        {
            Show show = Welcome; // создаем переменную делегата и присваиваем этой переменной адрес метода
            show(); // вызываем метод
            MyInterface checker;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Выберите фигуру:\n0 - круг\n1 - ромб\n2 - трапеция\n3 - треугольник\n4 - прямоугольник, квадрат в том числе\n");
            int a;
            while (!int.TryParse(Console.ReadLine(), out a) || a < 0 || a >= 5)
            {
                checker.CompareTo(true);
            }
            string figureSelection = a.ToString();
            Figa choice = (Figa)Enum.Parse(typeof(Figa), figureSelection);
            Console.Clear();
            switch (choice)
            {
                case Figa.Circle:
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Введите нужные данные о фигуре: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Радиус: ");
                        double radius = InputCheck();
                        Console.WriteLine("Цвет: ");
                        string color = Console.ReadLine();
                        Console.Clear();                        
                        Circle circle = new Circle(radius, color);
                        circle.Proverka();
                        IFoo foo = circle;// переменная интерфейса
                        foo.GetInfo();// получили доступ к элементам интерфейса
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Площадь круга: {0:#.##}", circle.Area());
                        Console.WriteLine("Периметр круга: {0:#.##}", circle.Perimetr());
                        Console.WriteLine();
                        break;
                    }
                case Figa.Romb:
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Введите нужные данные о фигуре: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Cторона: ");
                        double side = InputCheck();
                        Console.WriteLine("Высота: ");
                        double height = InputCheck();
                        Console.WriteLine("Цвет: ");
                        string color = Console.ReadLine();
                        Console.Clear();                        
                        Romb romb = new Romb(side, height, color);
                        romb.Proverka();
                        IFoo foo = romb;// переменная интерфейса
                        foo.GetInfo();// получили доступ к элементам интерфейса
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Площадь ромба: {0:#.##}", romb.Area());
                        Console.WriteLine("Периметр ромба: {0:#.##}", romb.Perimetr());
                        Console.WriteLine();
                        break;
                    }
                case Figa.Trapezia:
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Введите нужные данные о фигуре: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Верхнее основание: ");
                        double upperBase = InputCheck();
                        Console.WriteLine("Нижнее основание: ");
                        double bottomBase = InputCheck();
                        Console.WriteLine("Первая сторона: ");
                        double firstSide = InputCheck();
                        Console.WriteLine("Вторая сторона: ");
                        double secondSide = InputCheck();
                        Console.WriteLine("Высота: ");
                        double height = InputCheck();
                        Console.WriteLine("Цвет: ");
                        string color = Console.ReadLine();
                        Console.Clear();                        
                        Trapezia trapezia = new Trapezia(upperBase, bottomBase, firstSide, secondSide, height, color);
                        trapezia.Proverka();
                        IFoo foo = trapezia;// переменная интерфейса
                        foo.GetInfo();// получили доступ к элементам интерфейса
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Площадь трапеции: {0:#.##}", trapezia.Area());
                        Console.WriteLine("Периметр трапеции: {0:#.##}", trapezia.Perimetr());
                        Console.WriteLine();
                        break;
                    }
                case Figa.Triangle:
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Введите нужные данные о фигуре: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Первая сторона: ");
                        double firstSide = InputCheck();
                        Console.WriteLine("Вторая сторона: ");
                        double secondSide = InputCheck();
                        Console.WriteLine("Третья сторона: ");
                        double thirdSide = InputCheck();
                        Console.WriteLine("Цвет: ");
                        string color = Console.ReadLine();
                        Console.Clear();                        
                        Triangle triangle = new Triangle(firstSide, secondSide, thirdSide, color);
                        triangle.Proverka();
                        IFoo foo = triangle;// переменная интерфейса
                        foo.GetInfo();// получили доступ к элементам интерфейса
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Площадь треугольника: {0:#.##}", triangle.Area());
                        Console.WriteLine("Периметр треугольника: {0:#.##}", triangle.Perimetr());
                        Console.WriteLine();
                        break;
                    }
                case Figa.Rectangle:
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Введите нужные данные о фигуре: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Первая/третья сторона: ");
                        double firstSide = InputCheck();
                        Console.WriteLine("Вторая/четвёртая сторона: ");
                        double secondSide = InputCheck();
                        Console.WriteLine("Цвет: ");
                        string color = Console.ReadLine();
                        Console.Clear();                        
                        Rectangle rectangle = new Rectangle(firstSide, secondSide, color);
                        rectangle.Proverka();
                        IFoo foo = rectangle;// переменная интерфейса
                        foo.GetInfo();// получили доступ к элементам интерфейса
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Площадь прямоугольника: {0:#.##}", rectangle.Area());
                        Console.WriteLine("Периметр прямоугольника: {0:#.##}", rectangle.Perimetr());
                        Console.WriteLine();
                        break;
                    }
                default:
                    {                        
                        Console.WriteLine("Ошибка!");
                        break;
                    }
            }
            show -= Welcome;// убираем обработчик
            show += Goodbye;// добавляем обработчик
            show(); // снова вызываем метод
            Console.ReadLine();
        }
    }
}