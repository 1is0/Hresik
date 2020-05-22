using System;
using System.Collections.Generic;
using System.Text;

namespace laba_7
{   
    class Program
    {
        static void Main(string[] args)
        {
            RationalNumber number1, number2;
            int numerator1, denominator1;
            Console.WriteLine("Здравствуйте!");
            Console.WriteLine("Введите числитель первой рациональной дроби:");
            numerator1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель первой рациональной дроби:");
            denominator1 = Convert.ToInt32(Console.ReadLine());
            number1 = new RationalNumber(numerator1, denominator1);
            Console.WriteLine("Введите второе число в формате a/b");
            string form = Console.ReadLine();
            number2 = new RationalNumber(form);
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1.Сложение");
                Console.WriteLine("2.Вычетание");
                Console.WriteLine("3.Умнажение");
                Console.WriteLine("4.Деление");
                Console.WriteLine("5.Вывести большее число");
                Console.WriteLine("6.Вывести меньшее число");
                Console.WriteLine("7.Проверить числа на равенство");
                Console.WriteLine("8.Преобразовать в int");
                Console.WriteLine("9.Преобразовать в double");
                Console.WriteLine("10.Завешить работу");
                int otvet = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (otvet)
                {
                    case 1: Console.WriteLine($"{(number1 + number2).ToString()}"); break;
                    case 2: Console.WriteLine($"{(number1 - number2).ToString()}"); break;
                    case 3: Console.WriteLine($"{(number1 * number2).ToString()}"); break;
                    case 4: Console.WriteLine($"{(number1 / number2).ToString()}"); break;
                    case 5:
                        if (number1 > number2)
                            Console.WriteLine($"{number1.ToString()}");
                        else
                            Console.WriteLine($"{number2.ToString()}");
                        break;
                    case 6:
                        if (number1 < number2)
                            Console.WriteLine($"{number1.ToString()}");
                        else
                            Console.WriteLine($"{number2.ToString()}");
                        break;
                    case 7:
                        if (number1 == number2)
                            Console.WriteLine("Числа равны");
                        else
                            Console.WriteLine("Числа не равны");
                        break;
                    case 8: Console.WriteLine($"{(int)number1}    {(int)number2}"); break;
                    case 9: Console.WriteLine($"{(double)number1}    {(double)number2}"); break;
                    case 10: return;
                    default:
                        break;
                }
            }
        }
    }
}