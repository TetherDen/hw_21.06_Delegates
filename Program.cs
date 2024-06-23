using System;
using System.Security.Cryptography.X509Certificates;

namespace hw_21._06_Delegates
{
    public delegate void ShowMsg(string msg);
    public delegate double arithmeticDelegate(double a, double b);

    internal class Program
    {
        public static void Show(string msg)
        {
            Console.WriteLine(msg);
        }

        static void Main(string[] args)
        {
            //            Завдання 1
            //Створіть додаток, який відображає текстове повідомлення.Використовуйте механізми делегатів.Делегат має
            //повертати void та приймати один параметр типу string
            //(текст повідомлення).Для тестування додатка створіть
            //різні методи виклику через делегат.

            TextOut myText = new TextOut();
            ShowMsg methodDelegate = Show;
            myText.ConsoleDisplay("Hello delegate", methodDelegate);
            myText.ConsoleMove("10", methodDelegate);
            myText.ConsoleDisplayGreen("Green Text?",methodDelegate);
            myText.ConsoleDisplayRed("Red Text",methodDelegate);
            myText.ConsoleDisplayYellow("Yellow Text",methodDelegate);

            //            Завдання 2
            //Створіть додаток для виконання арифметичних операцій. Підтримувані операції:
            //■ Додавання двох чисел;
            //■ Віднімання двох чисел;
            //■ Множення двох чисел.
            //Код програми обов’язково має використати механізм
            //делегатів.
            double a = 3;
            double b = 5;
            Console.WriteLine($"a = {a}\nb = {b}");
            arithmeticDelegate arithemtic = ArithmeticOperations.Adding;
            Console.WriteLine($"Add: {arithemtic(a,b)}");
            arithemtic = ArithmeticOperations.Subtraction;
            Console.WriteLine($"Subtraction: {arithemtic(a,b)}");
            arithemtic = ArithmeticOperations.Multiplication;
            Console.WriteLine($"Multiplication: {arithemtic(a,b)}");

            //            Завдання 3
            //Створіть додатки для виконання арифметичних операцій. Підтримувані операції:
            //■ Перевірка числа на парність;
            //■ Перевірка числа на непарність;
            //■ Перевірка на просте число;
            //■ Перевірка на число Фібоначчі.
            //Обов’язково використовуйте делегат типу Predicate.
            Predicate<int> myPredicate;
            int num = 7;
            Console.WriteLine($"num = {num}");
            myPredicate = ArithmeticOperations.IsEven;
            Console.WriteLine($"num IsEven: {myPredicate(num)}");
            myPredicate = ArithmeticOperations.IsOdd;
            Console.WriteLine($"num IsOdd: {myPredicate(num)}");
            myPredicate= ArithmeticOperations.IsPrime;
            Console.WriteLine($"num IsPrime: {myPredicate(num)}");
            myPredicate = ArithmeticOperations.IsFibonacci;
            Console.WriteLine($"num IsFibonacci: {myPredicate(num)}");

            //            Завдання 4
            //Реалізуйте додаток із другого практичного завдання
            //за допомогою виклику Invoke.
            Console.WriteLine($"Invoke Multiplication: {arithemtic(a, b)}");
            arithemtic = ArithmeticOperations.Subtraction;
            Console.WriteLine($"Invoke Subtraction: {arithemtic(a, b)}");
            arithemtic = ArithmeticOperations.Adding;
            Console.WriteLine($"Invoke Adding: {arithemtic(a, b)}");

        }
    }
}
