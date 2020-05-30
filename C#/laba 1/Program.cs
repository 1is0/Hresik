using System;

namespace laba_1
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string str = Console.ReadLine().Replace('.', ',');
            string[] a = str.Split(new char[] { '-', '+', '*', '/' }, StringSplitOptions.RemoveEmptyEntries);
            string[] b = str.Split(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            int numberOfMistak = 0;

            while (a.Length == b.Length)
            {
                numberOfMistak += 1;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInput Error!");           
            }

            double fromStringToNumber;
            for (int i = 0; i < a.Length; i += 1) 
            {
                while (!double.TryParse(a[i], out fromStringToNumber))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nInput Error!");
                    Console.ResetColor();
                    Console.WriteLine("Click to end the program");
                    Console.ReadLine();
                    Environment.Exit(-1);
                }
            }

            for (int i = 0; i < b.Length; i += 1)
            {
                if (b[i] != "-" && b[i] != "+" && b[i] != "*" && b[i] != "/" && numberOfMistak == 0) 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nInput Error!");
                    Console.ResetColor();
                    Console.WriteLine("Click to end the program");
                    Console.ReadLine();
                    Environment.Exit(-1);
                }
            }
            string[] c = new string[a.Length + b.Length];

            for (int i = -1, k = 0; i < (c.Length - 1); i += 1, k++) 
             {
                i += 1;
                c[i] = a[k];              
            }

            int d = 0;
            for (int j = 0, k = 0; j < (c.Length - 1); j += 1, k++)
            { j += 1;
                if (d < b.Length) c[j] = b[k];
                d++;
            }

            int count = 0;
            for (int i = 1; i < c.Length - 1; i++)
            {
                if (c[i] == "*")
                {
                    c[i - 1] = Convert.ToString(Convert.ToDouble(c[i - 1]) * Convert.ToDouble(c[i + 1]));
                    c[i] = null;
                    c[i + 1] = null;
                    count += 2;
                }
                if (c[i] == "/")
                {
                    c[i - 1] = Convert.ToString(Convert.ToDouble(c[i - 1]) / Convert.ToDouble(c[i + 1]));
                    c[i] = null;
                    c[i + 1] = null;
                    count += 2;
                }
            }

            string[] n = new string[c.Length - count];

            for (int i = 0, j = 0; i < c.Length; i++)
            {
                if (c[i] != null)
                {
                    n[j] = c[i];
                    j++;
                }
            }

            for (int i = 1; i < n.Length - 1; i++)
            {
                if (n[i] == "+")
                {
                    n[i + 1] = Convert.ToString(Convert.ToDouble(n[i - 1]) + Convert.ToDouble(n[i + 1]));
                    n[i - 1] = null;
                    n[i] = null;
                }
                if (n[i] == "-")
                {
                    n[i + 1] = Convert.ToString(Convert.ToDouble(n[i - 1]) - Convert.ToDouble(n[i + 1]));
                    n[i - 1] = null;
                    n[i] = null;
                }
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nResult " + n[n.Length - 1]);
            Console.ReadLine();
        }
    }
}
