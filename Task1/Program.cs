using System;

class Program
{
    static void Main()
    {
        int m = 3; // Количество строк
        int n = 4; // Количество столбцов

        // Создание генератора случайных чисел
        Random random = new Random();

        // Создание двумерного массива
        double[,] array = new double[m, n];

        // Заполнение массива случайными вещественными числами
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                // Генерация случайного числа в диапазоне [-10, 10)
                double randomNumber = (random.NextDouble() * 20) - 10;
                array[i, j] = randomNumber;
            }
        }

        // Вывод массива на экран
        Console.WriteLine("Случайный двумерный массив:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}