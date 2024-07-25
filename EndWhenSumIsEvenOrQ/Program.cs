// Задача 1: 
// Напишите программу, 
// которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, 
// сумма цифр которого чётная.

void Main()
{
    while (true)
    {
        Console.WriteLine("Введите целое число или 'q' для выхода: ");
        string input = Console.ReadLine();

        if (input.ToLower() == "q")
        {
            break;
        }

        if (int.TryParse(input, out int number))
        {
            if (IsSumOfDigitsEven(number))
            {
                Console.WriteLine("Сумма цифр числа четная. Программа завершена.");
                break;
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q'.");
        }
    }
}

bool IsSumOfDigitsEven(int number)
{
    int sum = 0;
    while (number != 0)
    {
        sum += number % 10;
        number /= 10;
    }

    return sum % 2 == 0;
}

Main();