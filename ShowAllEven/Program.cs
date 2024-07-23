// Напишите программу, 
// которая на вход принимает число (number), 
// а на выходе выводит все чётные числа от 1 до number (включительно), 
// после каждого числа должен быть знак пробела.

void Main()
{
    int number = ReadInt("Введите натуральное число: ");
    ShowAllEven(number);
}

void ShowAllEven(int number)
{
    for (int i = 1; i <= number; i++)   
        if (i % 2 == 0)
            System.Console.Write(i + " ");
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();