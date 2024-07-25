// Задача 3: 
// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(arraySize, 1, 100);
    PrintArray(array);
    System.Console.WriteLine();
    int[] reversedArr = ReverseArray(array);
    PrintArray(reversedArr);
}

// Переворот массива
int[] ReverseArray(int[] array)
{
    // Создаем новый массив
    int sizeNewArr = array.Length;
    int[] newArr = new int[sizeNewArr];

    // Дублируем данные из исходного массива
    for (int i = 0; i < sizeNewArr; i++)
        newArr[i] = array[i]; 

    // Переворот массива
    for (int i = 0; i < sizeNewArr / 2; i++)
    {
        int temp = newArr[i];
        newArr[i] = newArr[sizeNewArr - i - 1];
        newArr[sizeNewArr - i - 1] = temp;
    }
    return newArr;
}

void PrintArray(int[] arrayForPrint)
{
    System.Console.Write(string.Join(", ", arrayForPrint));
}

int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
        tempArray[i] = rand.Next(minValue, maxValue);

    return tempArray;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();