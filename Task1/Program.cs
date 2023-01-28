// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


double[,] CreateArray(int rows, int columns, double minValue = -10, double maxValue = 10)
{
    double[,] array = new double[rows, columns];

    var random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            bool isPositive = Convert.ToBoolean(random.Next(0, 2));
            array[i, j] = Math.Round(random.NextDouble() * (isPositive ? maxValue : minValue), 1);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    } 
}

double[,] array = CreateArray(3, 4);

PrintArray(array);