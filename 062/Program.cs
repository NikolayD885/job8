// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

Console.Clear();
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine("");
    }
}

Console.WriteLine("Введите размер массива (size)");
if (!int.TryParse(Console.ReadLine()!, out var size))
{
    Console.WriteLine("Ошибка. Введите число");
}
var size2 = size;
int[,] CreateArrayWithRandomNumbers(int size, int size2)
{
    int[,] result = new int[size, size2];

    int num = 1;
    int i = 0;
    int j = 0;

    while (num <= size * size2)
    {
        result[i, j] = num;
        if (i <= j + 1 && i + j < size - 1)
            ++j;
        else if (i < j && i + j >= size - 1)
            ++i;
        else if (i >= j && i + j > size - 1)
            --j;
        else
            --i;
        ++num;
    }
    return result;
}
var array = CreateArrayWithRandomNumbers(size, size2);
PrintArray(array);

// Подскажите как в выводе поставить ноли, перед цифрами 1-9?




