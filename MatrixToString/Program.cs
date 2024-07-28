// // Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
// // Мое решение
// void Main()
// {
//     int numRow = ReadInt("Введите количество строк: ");
//     int colRow = ReadInt("Введите количество столбцов: ");

//     char[,] matrix = GenerateCharMatrix(numRow, colRow);
//     PrintMatrix(matrix);
//     System.Console.WriteLine();

//     char[] array = MatrixToArray(matrix);
//     PrintArray(array);
//     System.Console.WriteLine();    

//     string str = new string(array);
//     System.Console.Write(str);
// }

// void PrintArray(char[] array)
// {
//     System.Console.Write(string.Join(", ", array));
// }

// char[] MatrixToArray(char[,] matrix)
// {
//     int rows = matrix.GetLength(0);
//     int cols = matrix.GetLength(1);
//     char[] charArr = new char[rows * cols];
    
//     int index = 0;
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             charArr[index] = matrix[i, j];
//             index++;
//         }
//     }
//     return charArr;
// }

// void PrintMatrix(char[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int ReadInt(string msg)
// {
//     System.Console.Write(msg);
//     return Convert.ToInt32(Console.ReadLine());
// }

// char[,] GenerateCharMatrix(int numRow, int colRow)
// {
//     char[,] tempMatrix = new char[numRow, colRow];
//     Random rand = new Random();

//     for (int i = 0; i < numRow; i++)
//     {
//         for (int j = 0; j < colRow; j++)
//         {
//             tempMatrix[i, j] = (char)rand.Next('A', 'Z');
//         }
//     }
//     return tempMatrix;
// }

// Main();

// Эталонное решение
void Main()
{
    int numRow = ReadInt("Введите количество строк: ");
    int colRow = ReadInt("Введите количество столбцов: ");

    char[,] matrix = GenerateCharMatrix(numRow, colRow);
    PrintMatrix(matrix);
    System.Console.WriteLine();

    string result = CreateStringFrom2DArray(matrix);
    
    Console.WriteLine(result);
}

// Метод для создания строки из двумерного массива символов
string CreateStringFrom2DArray(char[,] array)
{
    string result = "";
    // Цикл по каждому элементу в двумерном массиве
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            // Добавление каждого символа в результирующую строку
            result += array[i, j];
        }
    }
    return result;
}

void PrintMatrix(char[,] matrix)
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

char[,] GenerateCharMatrix(int numRow, int colRow)
{
    char[,] tempMatrix = new char[numRow, colRow];
    Random rand = new Random();

    for (int i = 0; i < numRow; i++)
    {
        for (int j = 0; j < colRow; j++)
        {
            tempMatrix[i, j] = (char)rand.Next('A', 'Z');
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