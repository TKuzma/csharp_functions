// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

// int firstNumber = 9;
// int secondNumber = 4;

void Main()
{
    int firstNumber = ReadInt("Введите первое число: ");
    int secondNumber = ReadInt("Введите второе число: ");
    System.Console.Write(firstNumber);
    System.Console.WriteLine();
    System.Console.Write(secondNumber);
    System.Console.WriteLine();
    System.Console.Write(IsSquare(firstNumber, secondNumber));
}

bool IsSquare(int firstNumber, int secondNumber)
{
    if (firstNumber == secondNumber * secondNumber)
        return true;
    else
        return false; 
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();


