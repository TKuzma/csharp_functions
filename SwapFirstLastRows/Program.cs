// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Начальные условия:

// int[,] numbers = new int[,] {
//     {1, 2, 3, 4},
//     {5, 6, 7, 8},
//     {9, 10, 11, 12}
// }; 
// Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены табуляцией.

// Выводится:

// 9   10  11  12
// 5   6   7   8
// 1   2   3   4

void Main()
{
    int rowCount = ReadInt("Введите количество строк в массиве: ");
    int colCount = ReadInt("Введите количество столбцов в массиве: ");

    int[,] matrix = GenerateMatrix(rowCount, colCount, 0, 10);
    PrintMatrix(matrix);
    System.Console.WriteLine();
    ChangeFirstLastRows(matrix);
    PrintMatrix(matrix);
}

void ChangeFirstLastRows(int[,] matrix)
{
    int row1 = 0;
    int row2 = matrix.GetLength(0) - 1;
    int cols = matrix.GetLength(1);
        for (int i = 0; i < cols; i++)
        {
            int temp = matrix[row1, i];
            matrix[row1, i] = matrix[row2, i];
            matrix[row2, i] = temp;
        }
    
}    

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
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

Main();
