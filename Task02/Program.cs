// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 998);
Console.WriteLine($"Случайное трехзначное число на отрезке 100 - 998 -> {number}");

int DeleteSecondDigit (int num)
{
    int firstDigit = num / 100;
    int thirsDigit = num % 10;
    int result = firstDigit * 10 + thirsDigit;
    return result;
}

int result = DeleteSecondDigit(number);
Console.WriteLine($"{number} -> {result}");

