using System;

class Program
{
    static void Main()
    {
        // Пример двумерного массива
        int[,] array = {
            {1, 4, 7, 2},
            {5, 9, 2, 3},
            {8, 4, 2, 4}
        };

        // Позиция элемента
        Console.Write("Введите номер строки: ");
        int row = int.Parse(Console.ReadLine());

        Console.Write("Введите номер столбца: ");
        int col = int.Parse(Console.ReadLine());

        // Получение значения элемента
        int value = GetElementValue(array, row, col);

        // Вывод результата
        if (value != -1)
            Console.WriteLine($"Значение элемента: {value}");
        else
            Console.WriteLine("Такого элемента нет");
    }

    static int GetElementValue(int[,] array, int row, int col)
    {
        if (row < 0 || row >= array.GetLength(0) || col < 0 || col >= array.GetLength(1))
            return -1;
        else
            return array[row, col];
    }
}