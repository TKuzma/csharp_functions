// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

void Main()
{
    int number = ReadInt("Введите ТРЕХЗНАЧНОЕ число: ");

    if (number > 99 && number < 1000)
        System.Console.Write(SumFirstThird(number));
    else
        System.Console.Write("Вы ввели некорректноре число!");
}

int SumFirstThird(int number)
{
    int firstDigit = number / 100;
    int thirdDigit = number % 10;
    int sum = firstDigit + thirdDigit;
    return sum;
}


int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();


