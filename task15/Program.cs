/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

int number = new Random().Next(1, 8);

void weekEnd(int number) // функция определения выходных
{
    if (number <= 5)
    {
        Console.WriteLine($"{number} -> будни");
    }
    else Console.WriteLine($"{number} -> выходные");
}

weekEnd(number);
