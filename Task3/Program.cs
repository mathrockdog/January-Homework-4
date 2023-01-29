// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateRndArray(int rows, int columns, int minValue = 1, int maxValue = 10)
{
    int[,] array = new int[rows, columns];

    var random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(minValue, maxValue + 1);
            Console.Write($"{array[i, j], -3}" + " ");
        }
        Console.WriteLine();
    }
    return array;
}

void GetArithmeticMeanColumns(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        Console.Write($"{Math.Round(sum / array.GetLength(0), 1)}  ");
    }
}

int[,] RndArray = CreateRndArray(3, 4);
Console.WriteLine();
GetArithmeticMeanColumns(RndArray);
