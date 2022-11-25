// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:

// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []




// void Prompt(string[] args)
// {
// 	string[] AS;
//     int count;
//     string s;
//     string[] AS2;
//     System.Console.WriteLine("Введите строку: ");
//     count = 0;
//     AS = new string[count];
//     do
//     {
//         s = Console.ReadLine();
//         if (s!="")
//         {
//             count++;
//             AS2 = new string[count];
//             for (int i = 0; i < AS2.Length; i++)
//             {
//                 AS2[i] = AS[i];
//                 AS2[count - 1] = s;
//                 AS = AS2;
//             }
//         }
//     } while (s != "");
//     for (int i = 0; i < AS.Length; i++)
//     {
//         System.Console.WriteLine("AS[{0}] = {1}", i, AS[i]);
//         Console.ReadKey();
//     }
// }

// void PrintArray(string[] args)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < args.Length; i++)
//     {
//         Console.Write($"“{args[i]}”, ");
//     }
//     Console.Write("] ");
// }

// Prompt(args);
// PrintArray(args);

// ПЫТАЛАСЬ

// void Prompt(string[] args)
// {
//     Console.Write(msg);
//     return Console.ReadLine();
// }

// //  Функция вывода массива в терминал
// void PrintArray(string[] array)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"“{array[i]}”, ");
//     }
//     Console.Write("] ");
// }


// string fromUser = ReadInput("Введите команду: ");
// PrintArray(fromUser);

// ЕГО ДАЛЕЕ
// Commands();
// string[] array = new string[] {};

// string fromUser = ReadInput("Введите команду: ");
// switch (fromUser)
// {
//     case "1":
//         array = new string[] { "Hello", "2", "world", ":-)" };
//         break;
//     case "2":
//         array = new string[] { "1234", "1567", "-2", "computer science" };
//         break;
//     case "3":
//         array = new string[] { "Russia", "Denmark", "Kazan" };
//         break;
//     default:
//         Console.WriteLine($"{fromUser} - Такой команды нет");
//         break;
// }


// int lenNewArray = 0;
// for (int i = 0; i <= array.Length - 1; i++)
// {
//     if (array[i].Length <= 3) lenNewArray++;
// }

// string[] newArray = new string[lenNewArray];
// int idx = 0;

// for (int i = 0; i <= array.Length - 1; i++)
// {
//     if (array[i].Length <= 3)
//     {
//         newArray[idx] = array[i];
//         idx++;
//     }
// }

// PrintArray(array);
// Console.Write("→ ");
// PrintArray(newArray);

// // Функция: Вывод команд для работы с программой
// void Commands()
// {
//     Console.WriteLine();
//     Console.WriteLine("СПИСОК КОМАНД:");
//     Console.WriteLine("1 – использовать массив: [“Hello”, “2”, “world”, “:-)”]");
//     Console.WriteLine("2 – использовать массив: [“1234”, “1567”, “-2”, “computer science”]");
//     Console.WriteLine("3 – использовать массив: [“Russia”, “Denmark”, “Kazan”]");
//     Console.WriteLine();
// }

// // Функция ввода
// string ReadInput(string msg)
// {
//     Console.Write(msg);
//     return Console.ReadLine();
// }

// //  Функция вывода массива в терминал
// void PrintArray(string[] array)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"“{array[i]}”, ");
//     }
//     Console.Write("] ");
// }

// Функция ввода
string ReadInput(string msg)
{
    Console.Write(msg);
    return Console.ReadLine();
}

//  Функция вывода массива в терминал
void PrintArray(string array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"“{array[i]}”, ");
    }
    Console.Write("] ");
}

string fromUser = ReadInput("Введите команду: ");
PrintArray(fromUser);
