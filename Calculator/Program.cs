using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Вас приветствует консольный калькулятор C#");
            Console.WriteLine("Введите числа для операций");
            Console.WriteLine("Первое число");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Второе число");

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Выберите операцию");
            Console.WriteLine("\ta - Сложение");
            Console.WriteLine("\tb - Вычитание");
            Console.WriteLine("\tc - Умножение");
            Console.WriteLine("\td - Деление");
            Console.Write("Ваш выбор?");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Результат: {num1}+{num2} = " +(num1+num2));
                    break;
                case "b":
                    Console.WriteLine($"Результат: {num1}-{num2} = " + (num1-num2));
                    break;
                case "c":
                    Console.WriteLine($"Результат: {num1}*{num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Результат: {num1}/{num2} = " + (num1 / num2));
                    break;
            }
        }
    }
}
