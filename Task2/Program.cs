// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Write("Введите число: ");
string numeric = Console.ReadLine();
if(numeric.Length < 3) Console.WriteLine($"третьей цифры числа {numeric} нет.");
else Console.WriteLine($"Третья цифра числа {numeric} равна: {numeric[2]}");
