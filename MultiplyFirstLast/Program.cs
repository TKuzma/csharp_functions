// Задание 3.
// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(arraySize, 0, 10);
    PrintArray(array);
    System.Console.WriteLine();
    PrintArray(MultPairs(array));
}

int[] MultPairs(int[] array)
{
    int[] multPairs = new int[array.Length / 2];
    for (int i = 0; i < multPairs.Length; i++)
        multPairs[i] = array[i] * (array[array.Length - 1 - i]);
    return multPairs;
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