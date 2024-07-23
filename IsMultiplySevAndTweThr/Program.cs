// Задача 1: 
// Напишите программу, 
// которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.

void Main()
{
    int number = ReadInt("Введите число: ");
    IsMultiply(number);
}

void IsMultiply(int number)
{
    if (number % 7 == 0 && number % 23 == 0)
        System.Console.Write($"Число {number} кратно 7 и 23");
    else
        System.Console.Write($"Число {number} не кратно 7 и 23");
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();