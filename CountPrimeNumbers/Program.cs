// Задание 1. Совместная работа
// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.
// Примеры
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3

void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(arraySize, 0, 20);
    PrintArray(array);
    System.Console.WriteLine();
    System.Console.WriteLine(CountPrimary(array));
}

int CountPrimary(int[] array)
{
    int count = 0;

    foreach (int e in array)
    {
        if (IsPrimary(e))
            count++;
    }
    return count;
}

bool IsPrimary(int number)
{
    if (number < 2)
        return false;
    for (int i = 2; i <= Math.Sqrt(number); i++)
        if (number % i == 0)
            return false;
    return true;
}

void PrintArray(int[] array)
{
    System.Console.Write(string.Join(", ", array));
}

int[] GenerateArray(int arraySize, int minValue, int maxValue)
{
    int[] array = new int[arraySize];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
        array[i] = rand.Next(minValue, maxValue);
    
    return array;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();