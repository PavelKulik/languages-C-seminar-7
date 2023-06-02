int[,] GetArray(int row, int col, int valueMin, int valueMax)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(valueMin, valueMax);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}


bool isIndex(int[,] array, int indexI, int indexJ)
{
    if (indexI < 0 || indexJ < 0 || indexI >= array.GetLength(0) || indexJ >= array.GetLength(1))
        return false;
    return true;
}

Console.Write("Введите первую позицию элемента: ");
int indexI = int.Parse(Console.ReadLine()!);
Console.Write("Введите второю позицию элемента: ");
int indexJ = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(3, 4, 1, 9);
PrintArray(array);
Console.Write($"[{indexI}, {indexJ}] -> ");
if (!isIndex(array, indexI, indexJ))
    Console.WriteLine("такого числа в массиве нет");
else
    Console.WriteLine($"{array[indexI, indexJ]}");