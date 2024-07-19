// Задание 1. Совместная работа
// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да 

void Main()
{
    int arraySize = ReadInt("Введите размер массива:  ");
    int[] array = GenerateArray(arraySize, 0, 10);
    PrintArray(array);
    System.Console.WriteLine();
    int findNumber = ReadInt("Введите искомое число: ");
    System.Console.Write(NumberIsFinded(array, findNumber));
}

bool NumberIsFinded(int[] array, int findNumber)
{
    bool numberIsFinded = false;

    for (int i = 0; i < array.Length; i++)
        if (array[i] == findNumber)
    {
        numberIsFinded = true;
        break;
    }
    return numberIsFinded;
} 

void PrintArray(int[] array)
{
    System.Console.Write(string.Join(", ", array));  // ХОРОШИЙ ВЫВОД МАССИВА
}

int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
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