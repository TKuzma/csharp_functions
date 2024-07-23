// Напишите программу, 
// которая на вход принимает число number и выводит, 
// является ли число чётным (делится ли оно на два без остатка).

void Main()
{
    int number = ReadInt("Введите число: ");
    IsEven(number);

}

void IsEven(int number)
{
    if (number % 2 == 0)
        System.Console.Write($"Число {number} четное!");
    else 
        System.Console.Write($"Число {number} нечетное!");
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();