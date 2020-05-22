using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba__2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("How many times do you want to mix the string? ");
            int numberOfLines ;

            while (!int.TryParse(Console.ReadLine(), out numberOfLines) || numberOfLines < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Input Error!");
                Console.ForegroundColor = ConsoleColor.Magenta;
            }

            for (int i = 0; i < numberOfLines; i += 1) 
            {
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Enter the line you want to mix: ");
                string enterLine = Console.ReadLine();
                var rand = new Random();
                var resultLine = string.Join("", enterLine.OrderBy(x => rand.Next()));
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Result: ");
                Console.WriteLine(resultLine);
            }
            Console.ReadLine();
        }
    }
}
