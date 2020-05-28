using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Enter the number of random lines: ");           
            int numberOfLines;

            while (!int.TryParse(Console.ReadLine(), out numberOfLines) || numberOfLines < 0) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Input Error!");
                Console.ForegroundColor = ConsoleColor.Magenta;
            }

            char[,] result = new char[numberOfLines, 4];

            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    result[i, j] = (char)rand.Next(0x0020, 0x007F);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(result[i, j] + "");
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }
    }
}
