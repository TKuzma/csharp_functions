// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

void Main()
{
    System.Console.WriteLine("Введите текст: ");
    string str = Console.ReadLine();

    char[] chars = str.ToCharArray();
    PrintCharArray(chars);
    System.Console.WriteLine();

    if (IsPalindrome(chars))
    {
        System.Console.Write($"{str} - это палиндром!");
    }
    else
    {
        System.Console.Write($"{str} - это не палиндром!");
    }

}

void PrintCharArray(char[] chars)
{
    System.Console.Write(string.Join(", ", chars));
}

bool IsPalindrome(char[] chars)
{
    int size = chars.Length;
    for (int i = 0; i < size / 2; i++)
    {
        if (chars[i] != chars[size - i - 1])
        {
            return false;
        }
    }    
    return true;
}

Main();