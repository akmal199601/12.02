using System;

namespace ConsoleApplication
{

    class Program
    {
        delegate T Operation<T>(T number1, T number2);

        public static T Plus<T>(T number1, T number2)
        {
            return (dynamic)number1 + (dynamic)number2;
        }

        public static T Minus<T>(T number1, T number2)
        {
            return (dynamic)number1 - (dynamic)number2;
        }
        public static T Umnojenie<T>(T number1, T number2)
        {
            return (dynamic)number1 * (dynamic)number2;
        }
        public static T Delenie<T>(T number1, T number2)
        {
            return (dynamic)number1 / (dynamic)number2;
        }


        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            var akmal1 = decimal.TryParse(Console.ReadLine(), out var akmal1);
            if (!akmal1)
            {
                System.Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Вы ввели не число в");
                System.Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            Console.Write("Введите второй число: ");
            var akmal2 = decimal.TryParse(Console.ReadLine(), out var akmal2);
            if (!akmal2)
            {
                System.Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Вы ввели не число в");
                System.Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            Console.WriteLine("Выберите операцию: 1.(+) 2.(-) 3.(*) 4.(/)");
            Console.WriteLine("Пример выбора операции: 1");
            Console.Write("Введите операцию: ");
            var Number = decimal.TryParse(Console.ReadLine(), out var number);
            Operation<decimal> operation = null;
            Console.WriteLine();

            if (!Number)
            {
                System.Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Вы ввели не число в");
                System.Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            if (number == 1)
            {
                operation = Plus;
                System.Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ответ = " + operation.Invoke(akmal1, akmal2));
                return;
            }

            if (number == 2)
            {
                operation = Minus;
                System.Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ответ = " + operation.Invoke(akmal1, akmal2));
                return;
            }
            if (number == 3)
            {
                operation = Umnojenie;
                System.Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ответ = " + operation.Invoke(akmal1, akmal2));
                return;
            }
            if (number == 4)
            {
                if (akmal1==0 || akmal2==0)
                {
                    System.Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Нельзя делить на 0");
                    System.Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
                operation = Delenie;
                System.Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ответ = " + operation.Invoke(akmal1, akmal2));
                return;
            }
        }
    }
}