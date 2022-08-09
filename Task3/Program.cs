// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.Write("Введите число от (1-7): ");
string numeric = Console.ReadLine();
switch (numeric)
{
    case "1": 
        Console.WriteLine($"{numeric} нет, Рабочий день, понедельник.");
        break;
    case "2":
        Console.WriteLine($"{numeric} нет, Рабочий день, вторник.");
        break;
    case "3":
        Console.WriteLine($"{numeric} нет, Рабочий день, среда.");
        break;
    case "4":
        Console.WriteLine($"{numeric} нет, Рабочий день, четверг.");
        break;
    case "5":
        Console.WriteLine($"{numeric} нет, Рабочий день, пятница.");
        break;
    case "6":
        Console.WriteLine($"{numeric} да, Выходной день, суббота.");
        break;
    case "7":
        Console.WriteLine($"{numeric} да, Выходной день, воскресенье.");
        break;
}
