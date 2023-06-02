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

double[] FindArithmeticMean(int[,] array)
{
    double[] meanArray = new double[array.GetLength(1)];
    double sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        meanArray[j] = Math.Round(sum / array.GetLength(0), 2);
        sum = 0;
    }
    return meanArray;
}



int[,] array = GetArray(3, 4, 1, 9);
PrintArray(array);
double[] meanArray = FindArithmeticMean(array);
Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join("; ", meanArray)}");