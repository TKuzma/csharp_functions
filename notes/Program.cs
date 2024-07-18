// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Console.WriteLine("Hello world!");

// типы данных int, long - целые числа
// float, double - вещественные (дробные)
// char - символьный
// bool - логический

int value = 100;
Console.WriteLine(value);

double d = 5.55;
char c = '!';
bool b = true;

Console.WriteLine(d);
Console.WriteLine(c);
Console.WriteLine(b);

int i1 = 5;
int i2 = 6;
int sum = i1 + i2;
Console.WriteLine(sum);

long l1 = 95;
long sum2 = l1 + i1;
Console.WriteLine(sum2);

double d1 = 5.5;
double sum3 = i1 + d1;
Console.WriteLine(sum3);

int product1 = i1 * i2;
long product2 = l1 * i2;
double product3 = d1 * i2;
Console.WriteLine(product1);
Console.WriteLine(product2);
Console.WriteLine(product3);

int quotiant = i1 / i2;
Console.WriteLine(quotiant);

double quotiant2 = d1 / i1;
Console.WriteLine(quotiant2);

// // Добавление "d" даст нам нормальный ответ с запятыми
// System.Console.WriteLine(5d / 10d);
// // Тут выдаст 0
// System.Console.WriteLine(5 / 10);

// // Конкатенация
// System.Console.WriteLine("result " + "good");   // result good
// System.Console.WriteLine("result = " + 10);     // result = 10
// System.Console.WriteLine("result = " + (10 + 10));  // result = 20
// System.Console.WriteLine("result = " + 10 + 10);    // result = 1010cd

// // Контекст
// for (int i = 0; i < 5; i++)
// {
//     System.Console.Write(i);                // Обрабатывает обе строки внутри контекста
//     System.Console.Write(" _text_ ");
// }

// for (int i = 0; i < 5; i++)
//     System.Console.Write(i);               // Обрабатывает ТОЛЬКО 1 строку, вторая идет отдельно от for
// System.Console.Write(" _text_ ");

// // Пометка NEW(new)
// int[] name = new name1; // new выделяет новую ячейку памяти под что то

// // Массив
// string[] names = { "Кузьма", "Эрс", "Кирилл" }; // Массив, его нельзя увеличить или уменьшить, но можно редактировать значения
// names[0] = "Георгий";
// System.Console.WriteLine(names[0]);

// // Варианты заполнения массива
// // 1-й вариант заполнения
// int[] nums1 = { 1, 3, 4, 7, 76, 32 }; // Задание массива в коде

// // 2-й вариант заполнения (заполняется пользователем)
// int size = 7;   // Можно избавиться от этой строчки, и задать число
// int[] nums2 = new int[size];  // вместо size
// for (int i = 0; i < nums2.Length; i++)
// {
//     System.Console.WriteLine($"Введите {i + 1}-й элемент массива");
//     nums2[i] = Convert.ToInt32(Console.ReadLine());
// }

// // Вывод на консоль (можно использовать не только тут)
// for (int i = 0; i < nums2.Length; i++)
// {
//     System.Console.Write(nums2[i] + " ");
// }


// // 3 варинат заполнения массива
// int[] nums3 = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse); // Можно допустить ошибку, если надо вводит очень много данных
// // Вывод на консоль
// for (int i = 0; i < nums3.Length; i++)
// {
//     System.Console.Write(nums3[i] + " ");
// }


// // 4 вариант заполнения (генерация случйных чисел) 
// // Каждый раз добавляет новую ячейку памяти для новой генерации
// int[] nums4 = new int[5];
// for (int i = 0; i < nums4.Length; i++)
//     nums4[i] = new Random().Next(0, 10);   // сгенерирует случайные числа от 0 до 10 НЕ включительно
// // Вывод на консоль
// for (int i = 0; i < nums4.Length; i++)
//     System.Console.Write(nums4[i] + " ");

// int[] nums4 = new int[5];
// Random rand = new Random()  // выделили новую ячейку памяти для генерации
// for(int i = 0; i < nums4.Length; i++)
//     nums4[i] = rand.Next(0, 10);   // здесь поменяли и теперь меньше памяти требуется, чем в примере выше
// // Вывод на консоль
// for (int i = 0; i < nums4.Length; i++)
//     System.Console.Write(nums4[i] + " ");


// // Бесконечная генерация
// for (; ; )
// {
//     System.Console.WriteLine(new Random().Next(0, 10));
//     Console.ReadLine();
// }


// // Функции == Методы
// // Первое определяем тип данных, второе даем название, третье объявляем переменные (или оставляем скобки пустые)
// int Square(int value)    // Эта функция возвращает число умноженное на само себя
// {
//     int result = value * value;
//     return result;
// }

// // Если функция ничего не возвращет, то мы указываем тип данных VOID
// void ShowSquare(int value)
// {
//     int result = value * value;
//     System.Console.Write(result);
// }

// // Виды методов (функций)
// // БЕЗ ПАРАМЕТРОВ
// // Без возвращаемого значения
// void SayHelloMessage()
// {
//     System.Console.Write("Hello, World");  // побочный эффект (не влияет ни на что, но выводит текст)
// }
// // С возвращаемым значением
// double GetPi()
// {
//     return 3.14159;
// }

// // С ПАРАМЕТРАМИ
// // Без возвращаемого значения
// void ShowMessage(string message)
// {
//     System.Console.Write(message); // используется для вывода на консоль, в файл или диалоговые окна
// }
// // С возвращаемым значением
// int AddValues(int a, int b)
// {
//     int result = a + b;    // может хранить какие-либо действия и возвращать их результат
//     return result;
// }

// // СКЕЛЕТ ДЛЯ СОЗДАНИЯ МАССИВА С МЕТОДОМ
// void Main()
// {
//     int arraySize = ReadInt("Введите размер массива: ");
//     int[] array = GenerateArray(arraySize, 10, 15);
//     PrintArray(array);
// }

// // Вывод массива
// void PrintArray(int[] arrayForPrint)
// {
//     foreach (int number in arrayForPrint)
//         System.Console.Write(number + " ");
// }

// // Генерация массива
// int[] GenerateArray(int size, int minValue, int maxValue)
// {
//     int[] tempArray = new int[size];
//     Random rand = new Random();

//     for (int i = 0; i < tempArray.Length; i++)
//         tempArray[i] = rand.Next(minValue, maxValue);

//     return tempArray;
// }

// // Берем данные от пользователя (размер массива)
// int ReadInt(string msg)
// {
//     System.Console.Write(msg);
//     // Можно написать вот так:
//     // int number = Convert.ToInt32(Console.ReadLine()); 
//     // return number;
//     // Но так проще и красивее:
//     return Convert.ToInt32(Console.ReadLine());
// }

// Main();

// System.Console.Write(string.Join(", ", arrayForPrint));  // ХОРОШИЙ ВЫВОД 

// // Двумерные массивы
// int[,] matrix =
// {
//     {1,2,3,4,5},
//     {6,7,8,9,10},
//     {1,3,5,7,9}
// };
// System.Console.WriteLine(matrix.Length); // Показывает кол-во элементов в массиве
// System.Console.WriteLine(matrix.GetLength(0)); // Показывает количество строк
// System.Console.WriteLine(matrix.GetLength(1)); // Показывает количество столбцов

// int[,] matr = new int[10, 5]; // Выделение памяти: кол-во строк, кол-во столбцов

// int[] a = {1,2,3,4,5};
// int[] b = a[..] // Копирование массива