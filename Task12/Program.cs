// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


// int remainder = numb1 % numb2;
// if (remainder == 0)
// {
//     Console.WriteLine("Кратно");
// }
// else 
// {
//     Console.WriteLine($"не кратко, остаток = {remainder}");
// }

Console.Clear();
Console.Write("Введите первое число = ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число = ");
int number2 = Convert.ToInt32(Console.ReadLine());

int remainder = Remainder(number1, number2);

string result = remainder != 0 ? $"не кратко, остаток = {remainder}" : "Кртано";

Console.WriteLine(result);

int Remainder(int num1, int num2)
{
    return num1 % num2;
}