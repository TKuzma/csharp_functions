// Задача 3: 
// Задайте массив из вещественных чисел с
// ненулевой дробной частью. Найдите разницу между
// максимальным и минимальным элементов массива.

void Main()
{
    double[] array = GenerateArray(10);
    PrintArray(array);

    double diff = FindDifferenceBetweenMaxAndMin(array);
    System.Console.WriteLine();
    System.Console.Write(diff);
}

double FindDifferenceBetweenMaxAndMin(double[] array)
{
    double max = array[0];
    double min = array[0];

    foreach (double number in array)
    {
        if (number > max)
            max = number;
        if (number < min)
            min = number;
    }

    return max - min;
}

void PrintArray(double[] array)
{
    System.Console.Write(string.Join(", ", array));
}

double[] GenerateArray(int size)
{
    double[] array = new double[size];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(rand.Next(0, 10) + rand.NextDouble(), 2);
    
    return array;
}

Main();

// double maxValue = 0;
// double minValue = 5.5;

// for (int i = 0; i < array.Length; i++)  // Обязательно на семинар ВОПРОС ПО ДЗ
// {
//     if (minValue > array[i])
//     {
//         minValue = array[i];
//     }
//     else if (maxValue < array[i])
//     {
//         maxValue = array[i];
//     }
// }
// System.Console.Write("Минимальное значение: " + minValue + " Максимальное значение: " + maxValue);
// System.Console.WriteLine("\nРазница: " + (maxValue - minValue));
