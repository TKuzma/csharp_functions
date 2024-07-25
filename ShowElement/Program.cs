// Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет: "Позиция по рядам выходит за пределы массива"
// или "Позиция по колонкам выходит за пределы массива"

// Позиции в массиве считать от единицы.

// В коде, начальные условия:

// int[,] numbers = new int[,] {
//     {1, 2, 3, 4},
//     {5, 6, 7, 8},
//     {9, 10, 11, 12}
// };

// int x = 2;
// int y = 2;
// Выводится: 6

void Main()
{
    int rowCount = ReadInt("Введите количество строк: ");
    int colCount = ReadInt("Введите количество столбцов: ");

    int[,] matrix = GenerateMatrix(rowCount, colCount, 0, 100);
    PrintMatrix(matrix);

    int rowNum = ReadInt("Введите номер в строке: ");
    int colNum = ReadInt("Введите номер колонки: ");

    ShowElement(rowNum, colNum, matrix);
}

void ShowElement(int rowNum, int colNum, int[,] matrix)
{
    rowNum--; // Сдвиг для работы с массивами, индексируемыми с 0
    colNum--; // Сдвиг для работы с массивами, индексируемыми с 0

    if (rowNum < 0 || rowNum >= matrix.GetLength(0))
    {
        Console.WriteLine("Позиция по рядам выходит за пределы массива");
    }
    else if (colNum < 0 || colNum >= matrix.GetLength(1))
    {
        Console.WriteLine("Позиция по колонкам выходит за пределы массива");
    }
    else
    {
        Console.WriteLine($"Значение элемента: {matrix[rowNum, colNum]}");
    }
}      

void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixForPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

// Генерация двумерного массива
int[,] GenerateMatrix(int rows, int cols, int minValue, int maxValue)
{
    int[,] tempMatrix = new int[rows, cols];
    Random rand = new Random();

    int numRow = tempMatrix.GetLength(0);
    int colRow = tempMatrix.GetLength(1);
    for (int i = 0; i < numRow; i++)
    {
        for (int j = 0; j < colRow; j++)
        {
            tempMatrix[i, j] = rand.Next(minValue, maxValue + 1);
        }
    }
    return tempMatrix;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();