using System;
using System.Collections.Generic;
using System.Text;

namespace laba_7
{
    class RationalNumber : IEquatable<RationalNumber>
    {
        private int _numerator;
        private int _denominator;

        public RationalNumber(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }

        public RationalNumber(string form)
        {
            char[] numerator = new char[25];
            char[] denominator = new char[25];
            int i = 0;
            for (int j = 0; i < form.Length; i++, j++)
            {
                if (form[i] == '/')
                {
                    numerator[j] = '\0';
                    i++;
                    break;
                }
                numerator[j] = form[i];
            }
            for (int j = 0; i < form.Length; i++, j++)
            {
                denominator[j] = form[i];
            }
            string str1 = new string(numerator);
            string str2 = new string(denominator);
            _numerator = Convert.ToInt32(str1);
            _denominator = Convert.ToInt32(str2);
        }
        
        public bool Equals(RationalNumber another)
        {
            if (another is null)
                return false;
            return _numerator * another._denominator == another._numerator * _denominator;
        }
        
        public static RationalNumber operator +(RationalNumber a, RationalNumber b)
        {
            if (a._denominator == b._denominator)
            {
                return new RationalNumber(a._numerator + b._numerator, a._denominator);
            }
            else
            {
                int denominator = a._denominator * b._denominator;
                int numerator = a._numerator * b._denominator + b._numerator * a._denominator;
                return new RationalNumber(numerator, denominator);
            }
        }

        public static RationalNumber operator -(RationalNumber a, RationalNumber b)
        {
            if (a._denominator == b._denominator)
            {
                return new RationalNumber(a._numerator - b._numerator, a._denominator);
            }
            else
            {
                return new RationalNumber((a._numerator * b._denominator) - (b._numerator * a._denominator), a._denominator * b._denominator);
            }
        }

        public static RationalNumber operator *(RationalNumber a, RationalNumber b)
        {
            return new RationalNumber(a._numerator * b._numerator, a._denominator * b._denominator);
        }

        public static RationalNumber operator /(RationalNumber a, RationalNumber b)
        {
            return new RationalNumber(a._numerator * b._denominator, a._denominator * b._numerator);
        }

        public static bool operator >(RationalNumber a, RationalNumber b)
        {
            return (double)a > (double)b;
        }

        public static bool operator <(RationalNumber a, RationalNumber b)
        {
            return (double)a < (double)b;
        }

        public static bool operator >=(RationalNumber a, RationalNumber b)
        {
            return (double)a >= (double)b;
        }

        public static bool operator <=(RationalNumber a, RationalNumber b)
        {
            return (double)a <= (double)b;
        }

        public static bool operator ==(RationalNumber a, RationalNumber b)
        {
            return a.Equals((object)b);
        }

        public static bool operator !=(RationalNumber a, RationalNumber b)
        {
            return !a.Equals((object)b);
        }

        public static explicit operator double(RationalNumber num)
        {
            return (double)num._numerator / num._denominator;
        }

        public static explicit operator int(RationalNumber num)
        {
            return num._numerator / num._denominator;
        }

        public override string ToString()
        {
            return $"{_numerator} / {_denominator}";
        }
    }
}
