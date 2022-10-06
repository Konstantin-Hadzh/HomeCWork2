/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int thirdNumber = new Random().Next(1, 999);
string thirdNumberText = Convert.ToString(thirdNumber);
if (thirdNumberText.Length > 2)
{
    Console.Write($"{thirdNumberText} третья цифра -> {thirdNumberText[2]}");
    Console.WriteLine();
}
else 
{
    Console.WriteLine($"{thirdNumberText} -> третьей цифры нет");
}
