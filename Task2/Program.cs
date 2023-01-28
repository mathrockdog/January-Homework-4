// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
//    0. 1. 2. 3.
// 0. 1  4  7  2

// 1. 5  9  2  3

// 2. 8  4  2  4

// 1, 7 -> такого числа в массиве нет

int? GetValueFromArray(int[,] array, int rowIndex, int colIndex)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (rowIndex == i)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (colIndex == j)
                {
                    return array[i, j];
                }
            }
        }
    }
    return null;
}

int[,] nums = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
Console.Write("Введите первое число: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int columns = Convert.ToInt32(Console.ReadLine());

int? valueFromArray = GetValueFromArray(nums, rows, columns);
if (valueFromArray == null)
{
    Console.Write("Такого элемента не существует");
}
else
{
    Console.Write("Элемент массива по заданным координатам равен " + valueFromArray);
}