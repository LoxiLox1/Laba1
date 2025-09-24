using System;

class Program
{
    static void Main()
    {
        Console.Write("апыпыпк (m): ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Вапоаооапоапов (n): ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[m, n];

        Console.WriteLine("Ввераеаераопоаноаоанрматрицы:");

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Элемент [{i + 1},{j + 1}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nВаша ыппвырвыр:");
        for (int i = 1; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Пример вычисления: сумма всех элементов
        int sum = 0;
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                sum += matrix[i, j];

        Console.WriteLine($"\nбебесбабаб {sum}");
    }
}