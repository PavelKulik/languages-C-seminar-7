double[,] GetArray(int row, int col)
{
    double[,] array = new double[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble() * 10, 2);
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
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите m = ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите n = ");
int col = int.Parse(Console.ReadLine()!);

double[,] array = GetArray(row, col);
PrintArray(array);