// Задача 4: Напишите программу, 
// которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.

void Main()
{
    int number = ReadInt("Введите натуральное число: ");

    if (number <= 0)
        {
            Console.WriteLine("Ошибка! Введите натуральное число.");
        }
        else
        {
            int[] digitsArray = GetDigitsArray(number);
            PrintArray(digitsArray);
        }    
}
        
int[] GetDigitsArray(int number)
{
    // Преобразуем число в строку
    string numberString = number.ToString();
    // Создаем массив нужного размера
    int[] digitsArray = new int[numberString.Length];
        
    // Заполняем массив цифрами из строки
    for (int i = 0; i < numberString.Length; i++)
    {
        digitsArray[i] = numberString[i] - '0'; // Преобразуем символ в цифру
    }
    return digitsArray;
}

void PrintArray(int[] arrayForPrint)
{
    Console.WriteLine("Массив цифр числа: " + string.Join(", ", arrayForPrint));
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();