// Задание 2.
// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2

void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(arraySize, 19, 23);
    PrintArray(array);
    System.Console.WriteLine();
    System.Console.Write(CountNumbers(array));
}

// Поиск количества чисел, которые оканчиваются на 1 и делятся нацело на 7
int CountNumbers(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
        if (arr[i] % 7 == 0 && arr[i] % 10 == 1)
            count++;
    return count;
}

// Вывод массива
void PrintArray(int[] arrayForPrint)
{
    System.Console.Write(string.Join(", ", arrayForPrint));  // ХОРОШИЙ ВЫВОД МАССИВА
}
    
// Генерация массива
int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
        tempArray[i] = rand.Next(minValue, maxValue);

    return tempArray;
}

// Берем данные от пользователя (размер массива)
int ReadInt(string msg)
{
    System.Console.Write(msg);
    // Можно написать вот так:
    // int number = Convert.ToInt32(Console.ReadLine()); 
    // return number;
    // Но так проще и красивее:
    return Convert.ToInt32(Console.ReadLine());
}

Main();