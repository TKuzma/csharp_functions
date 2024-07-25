// Задача 2: 
// Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет
// количество чётных чисел в массиве.

void Main()
{
    int[] array = GenerateArray();
    PrintArray(array);
    System.Console.WriteLine();
    System.Console.Write(CountEven(array));
}

int CountEven(int[] array)
{
    int count = 0;
    foreach(int e in array)
    {
        if (e % 2 == 0)
            count++;
    }
    return count;
}

void PrintArray(int[] array)
{
    System.Console.Write(string.Join(", ", array));
}

int[] GenerateArray()
{
    int[] array = new int[10];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
        array[i] = rand.Next(1, 101);

    return array;
}

Main();