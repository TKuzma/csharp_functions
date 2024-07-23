// Задача 3:
// Напишите программу, 
// которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

void Main()
{
    int number = ReadInt();
    if (number > 99 || number < 10)
        System.Console.Write("Введите корректное число!");
    else
        IsBigger(number);
}   

void IsBigger(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    if (firstDigit > secondDigit)
        System.Console.WriteLine($"Первая цифра {firstDigit} > второй цифры {secondDigit}");
    else if (secondDigit > firstDigit)
        System.Console.WriteLine($"Первая цифра {firstDigit} < второй цифры {secondDigit}");
    else
        System.Console.WriteLine("Цифры равны между собой");
}

int ReadInt()
{
    System.Console.Write("Введите число от 10 до 99: ");
    return Convert.ToInt32(Console.ReadLine());
}

Main();