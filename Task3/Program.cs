using System;

class Program
{
    static void Main()
    {
        // Заданный двумерный массив
        int[,] array = {
            {1, 4, 7, 2},
            {5, 9, 2, 3},
            {8, 4, 2, 4}
        };

        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        // Создание массива для хранения сумм элементов в каждом столбце
        int[] columnSums = new int[cols];

        // Вычисление сумм элементов в каждом столбце
        for (int col = 0; col < cols; col++)
        {
            for (int row = 0; row < rows; row++)
            {
                columnSums[col] += array[row, col];
            }
        }

        // Вычисление среднего арифметического элементов в каждом столбце
        double[] columnAverages = new double[cols];
        for (int col = 0; col < cols; col++)
        {
            columnAverages[col] = (double)columnSums[col] / rows;
        }

        // Вывод среднего арифметического каждого столбца
        Console.WriteLine("Среднее арифметическое каждого столбца:");
        for (int col = 0; col < cols; col++)
        {
            Console.WriteLine($"{col + 1}: {columnAverages[col]}");
        }
    }
}