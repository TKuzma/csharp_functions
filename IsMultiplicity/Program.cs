// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число некратно
// второму, то программа выводит остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

void Main()
{
    int firstNumber = ReadInt("Введите первое число: ");
    int secondNumber = ReadInt("Введите второе число: ");

    IsMultiplicity(firstNumber, secondNumber);
}

void IsMultiplicity(int firstNumber, int secondNumber)
{
    if (firstNumber % secondNumber == 0)
    {
        System.Console.WriteLine("да");
    }
    else
    {
        int result = firstNumber % secondNumber;
        System.Console.WriteLine($"нет, {result}");
    }
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();


