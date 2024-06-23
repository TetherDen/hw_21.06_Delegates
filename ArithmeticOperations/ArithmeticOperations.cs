using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_21._06_Delegates
{
    internal static class ArithmeticOperations
    {
        public static double Adding(double a, double b) {  return a + b; }
        public static double Subtraction(double a, double b) {return a - b; }
        public static double Multiplication(double a, double b) { return (a * b); }
        
        //   Завдання 3
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        public static bool IsFibonacci(int number)
        {
            int a = 0;
            int b = 1;
            if (number == a || number == b) return true;
            int c = a + b;
            while (c <= number)
            {
                if (c == number) return true;
                a = b;
                b = c;
                c = a + b;
            }
            return false;
        }

    }
}
