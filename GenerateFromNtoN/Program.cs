// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

void Main()
{
    int number = ReadInt("Введите положительное число: ");
    if (number <= 0)
        System.Console.Write("Ошибка! Введите положительное число!");
    else
        PrintArray(GenerateFromNtoN(number)); 
}
void PrintArray(int[] arrayForPrint)
{
    System.Console.Write(string.Join(", ", arrayForPrint));  // ХОРОШИЙ ВЫВОД МАССИВА
}

int[] GenerateFromNtoN(int number)
{
    int[] array = new int[number * 2 + 1];

    for (int i = -number, j = 0; i <= number; i++, j++)
        array[j] = i;

    return array;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();