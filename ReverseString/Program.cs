// Задача 4*(не обязательная): 
// Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

void Main()
{
    System.Console.WriteLine("Введите строку: ");
    string str = Console.ReadLine();
    System.Console.WriteLine(str);

    string newStr = ReverseString(str);
    System.Console.Write(newStr);
}

string ReverseString(string str)
{
    string[] newString = str.Split(' ');
    Array.Reverse(newString);
    return string.Join(" ", newString);
}


Main();