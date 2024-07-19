// Напишите программу, которая принимает на вход
// трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.

void Main()
{
    int number = ReadLine("Введите ТРЕХЗНАЧНОЕ число: ");
    if (number > 99 && number < 1000)
        System.Console.Write(SecondSquareThird(number));
    else
    {
        System.Console.Write("Вы ввели некорректное число!");
    }
}

int SecondSquareThird(int number)
{
    int secondDigit = number / 10 % 10; // Узнали вторую цифру
    int result = 1;
    for (int power = number % 10; power > 0; power--)
        result *= secondDigit;
    
    return result;
}

int ReadLine(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();