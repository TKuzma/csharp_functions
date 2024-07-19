// Напишите программу, которая принимает на
// вход трёхзначное число и удаляет вторую
// цифру этого числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

void Main()
{
    int number = ReadInt("Введите ТРЕХЗНАЧНОЕ число: ");
    if (number > 99 && number < 1000)
    {
        System.Console.Write(DelSecondDigit(number));
    }
    else
        System.Console.Write("Вы ввели некорректное число!");
}

int DelSecondDigit(int number)
{  
    int result = Convert.ToInt32(number / 100 + "" + number % 10);

    return result;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();





