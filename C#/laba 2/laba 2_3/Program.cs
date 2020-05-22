using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string aWithoutSpaces = a.Replace(" ", "");
            Console.ForegroundColor = ConsoleColor.Magenta;

            string str = new String(new char[256]); ;

            Random rand = new Random();
            for (int i = 0; i < 30; i += 1)
            {                
                int value = rand.Next(aWithoutSpaces.Length);
                StringBuilder sb = new StringBuilder(str);
                sb[i] = aWithoutSpaces[value];
                str = sb.ToString();            
            }
            string result = String.Join(" ", str.AsEnumerable());
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}