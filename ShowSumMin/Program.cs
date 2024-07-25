// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void Main()
{
    int rowCount = ReadInt("Введите количество строк: ");
    int colCount = ReadInt("Введите количество столбцов: ");

    int[,] matrix = GenerateMatrix(rowCount, colCount, 0, 10);

    PrintMatrix(matrix);

    int[] array = SumEveryRow(matrix);
    PrintArray(array);
    System.Console.WriteLine();

    System.Console.Write(ShowMin(array));
}

int[,] GenerateMatrix(int rowCount, int colCount, int minValue, int maxValue)
{
    int[,] matrix = new int[rowCount, colCount];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int ShowMin(int[] array)
{
    int minIndex = 0;
    int minValue = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minValue)
        {
            minValue = array[i];
            minIndex = i;
        }    
    }
    return minIndex;
}

void PrintArray(int[] array)
{
    System.Console.Write(string.Join(", ", array));
}

int[] SumEveryRow(int[,] matrix)
{
    int[] sumRow = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow[i] += matrix[i, j];
        }
    }
    return sumRow;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Main();