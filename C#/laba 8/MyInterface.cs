using System;
using System.Collections.Generic;
using System.Text;

namespace geometricFigure
{
    struct MyInterface : IComparable
    {
        public int CompareTo(object o)
        {
            if (true.CompareTo(o) == 0)
            {
                showMessage();
            }
            return 0;
        }

        private void showMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ОШИБКА ВВОДА!");
            Console.ForegroundColor = ConsoleColor.Cyan;
        }        
    }

    interface IFoo
    {
        void GetInfo();
    }
}


