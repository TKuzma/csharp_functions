// Задание 2.
// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.
// Пример
// [1 -5 6] => [-1 5 -6]

void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(arraySize, -10, 11);
    PrintArray(array);
    System.Console.WriteLine();
    PrintArray(ArrFromNegToPos(array));

}

int[] ArrFromNegToPos(int[] array)
{   
    for (int i = 0; i < array.Length; i++)
        array[i] *= -1;
    return array; 
}

void PrintArray(int[] array)
{
    System.Console.Write(string.Join("\t", array));
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




// // Сделали массив с противоположным знаком
// for (int i = 0; i < array.Length; i++)
//     array[i] *= -1;       //array[i] = -array[i];    //array[i] = array[i] * -1;    // Три разных варианта
// // Вывод массива с противоположным знаком
// for (int i = 0; i < array.Length; i++)
//     System.Console.Write(array[i] + "\t");    // добавили табуляцию \t для красоты вывода