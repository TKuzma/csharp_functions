// Напишите программу, 
// которая на вход принимает два числа и выводит, 
// какое число большее, а какое меньшее.

void Main()
{
    int firstNumber = ReadInt("Введите первое число: ");
    int secondNumber = ReadInt("Введите второе число: ");

    IsBigger(firstNumber, secondNumber);
}

void IsBigger(int firstNumber, int secondNumber)
{
    if (firstNumber > secondNumber)
        System.Console.Write("Первое число БОЛЬШЕ второго!");
    else if (firstNumber < secondNumber)
        System.Console.Write("Первое число МЕНЬШЕ второго!");
    else  
        System.Console.Write("Числа равны!");
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();