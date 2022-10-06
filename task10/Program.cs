/*
Задача 10: Напишите программу, 
которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int number = new Random().Next(100, 1000); // генерируем случайное трехзначное число

int getCreateTwoDigitFromNumber(int number) // функция принимает на вход трёхзначное число и на выходе показывает вторую цифру mid = (n % 100) / 10
{
    int midleNumber = (number % 100) / 10;
    return(midleNumber);
}

Console.Write($"{number} -> ");
int result = getCreateTwoDigitFromNumber(number);
Console.WriteLine(result);
