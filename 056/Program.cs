//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}, ");
        }
        Console.WriteLine();
    }
}

int[,] CreateArrayWithRandomNumbers(int m, int n)
{
    int[,] result = new int[m, n];

    var random = new Random();

    for (var i = 0; i < result.GetLength(0); i++)
    {
        for (var j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = random.Next(1, 10);
        }
    }
    return result;
}

Console.WriteLine("Введите число строк (m)");
if (!int.TryParse(Console.ReadLine()!, out var m))
{
    Console.WriteLine("Ошибка. Введите число");
}

Console.WriteLine("Введите число столбцов (n)");
if (!int.TryParse(Console.ReadLine()!, out var n))
{
    Console.WriteLine("Ошибка. Введите число");
}

var array = CreateArrayWithRandomNumbers(m, n);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();

void MinSumString(int[,] array)
{
    int index = 0, minsum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} строки = {sum}");
        if (i == 0)
        {
            minsum = sum;
        }
        else if (sum < minsum)
        {
            minsum = sum;
            index = i;
        }
    }
    Console.WriteLine("\n" + $"Строка с наименьшей суммой элементов: {index + 1} строка ");
}

MinSumString(array);
