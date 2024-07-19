// Напишите программу, 
// которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел.

void Main()
{
    int firstNumber = ReadInt("Введите первое число: ");
    int secondNumber = ReadInt("Введите второе число: ");
    int thirdNumber = ReadInt("Введите третье число: ");

    IsBigger(firstNumber, secondNumber, thirdNumber);
}

void IsBigger(int firstNumber, int secondNumber, int thirdNumber)
{
    if (firstNumber > secondNumber && firstNumber > thirdNumber)
        System.Console.Write("Первое число самое большое!");
    else if (secondNumber > firstNumber && secondNumber > thirdNumber)
        System.Console.Write("Второе число самое большое!");
    else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
        System.Console.Write("Третье число самое большое!");
    else
        System.Console.Write("Нет одного наибольшего числа!");
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();
