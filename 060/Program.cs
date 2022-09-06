// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

Console.Clear();

void PrintArray(int[,,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}, ");
            }
        }
        Console.WriteLine();
    }
}

int[,,] CreateArrayWithRandomNumbers(int m, int n, int z)
{
    int[,,] result = new int[m, n, z];

    var random = new Random();

    for (var i = 0; i < result.GetLength(0); i++)
    {
        for (var j = 0; j < result.GetLength(1); j++)
        {
            for (var k = 0; k < result.GetLength(2); k++)
            {
                result[i, j, k] = random.Next(1, 10 + 1);
            }
        }
        return result;
    }
}


Console.WriteLine("Введите размерность 1 (m)");
if (!int.TryParse(Console.ReadLine()!, out var m))
{
    Console.WriteLine("Ошибка. Введите число");
}

Console.WriteLine("Введите размерность 2 (n)");
if (!int.TryParse(Console.ReadLine()!, out var n))
{
    Console.WriteLine("Ошибка. Введите число");
}

Console.WriteLine("Введите размерность 3 (z)");
if (!int.TryParse(Console.ReadLine()!, out var z))
{
    Console.WriteLine("Ошибка. Введите число");
}

var array = CreateArrayWithRandomNumbers(m, n, z);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
