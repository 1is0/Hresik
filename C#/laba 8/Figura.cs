using System;
using System.Collections.Generic;
using System.Text;

namespace geometricFigure
{
    abstract class Figura 
    {
        public abstract double Area();
        public abstract double Perimetr();

        public delegate void FigureColor(string message);// объявление делегата
        public event FigureColor Set;  // определение события
        public string Colour1;

        public void Colour(string color)
        {
            Colour1 = color;
            Set?.Invoke($"Цвет: {color}");  // вызов события 
        }
    }
}
