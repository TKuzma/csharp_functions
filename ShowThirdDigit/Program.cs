// Напишите программу, которая выводит третью с
// конца цифру заданного числа или сообщает, что
// третьей цифры нет.
// 456 => 6
// 7812 => 8
// 91 => Третьей цифры нет

void Main()
{
    int number = ReadInt("Введите натуральное число: ");
    if (number > 99)
        ShowThirdDigit(number);
    else
        System.Console.Write("Третьей цифры нет!");
}

void ShowThirdDigit(int number)
{
    if (number > 99)                                
    {
        while (number > 999)                          // Ищем третью цифру от начала
        number /= 10;
        System.Console.WriteLine(number % 10);
    }
    else
        System.Console.WriteLine("Третьей цифры нет");
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();
