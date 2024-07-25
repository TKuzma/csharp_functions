// Задача 2: 
// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, 
// которая покажет количество чётных чисел в массиве.

void Main()
{
    int sizeArray = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(sizeArray);
    PrintArray(array);
    System.Console.WriteLine();
    System.Console.Write(CountEven(array));

}

void PrintArray(int[] array)
{
    System.Console.Write(string.Join(", ", array));
}

int CountEven(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            count++;
    
    return count;
}

int[] GenerateArray(int sizeArray)
{
    int[] array = new int[sizeArray];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
        array[i] = rand.Next(100, 1000);

    return array;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();