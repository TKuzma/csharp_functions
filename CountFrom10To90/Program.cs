// Задача 1:
// Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,90].

void Main()
{
    int number = 10;

    PrintArray(Array(number));
    System.Console.WriteLine();
    Count(Array(number));
}

void PrintArray(int[] array)
{
    System.Console.Write(string.Join(", ", array));
}

void Count(int[] array)
{
    int count = 0;
    foreach (int i in array)
    {
        if (i >= 10 && i <= 90)
            count++;
    }
    System.Console.Write(count);
}

int[] Array(int number)
{
    int[] array = new int[number];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
        array[i] = rand.Next(1, 101);
    
    return array;
}

Main();