using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Простой калькулятор на C#");
        Console.WriteLine("Доступные операции: +, -, *, /");

        while (true)
        {
            try
            {
                Console.Write("\nВведите первое число: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Введите операцию (+, -, *, /): ");
                string op = Console.ReadLine();

                Console.Write("Введите второе число: ");
                double num2 = double.Parse(Console.ReadLine());

                double result = 0;

                switch (op)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                        {
                            Console.WriteLine("Ошибка: деление на ноль!");
                            continue;
                        }
                        break;
                    default:
                        Console.WriteLine("Ошибка: неизвестная операция!");
                        continue;
                }

                Console.WriteLine($"Результат: {result}");
            }
            catch
            {
                Console.WriteLine("Ошибка ввода! Попробуйте снова.");
            }

            Console.Write("\nХотите продолжить? (y/n): ");
            string choice = Console.ReadLine().ToLower();
            if (choice != "y")
                break;
        }
    }
}