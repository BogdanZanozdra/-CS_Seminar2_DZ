//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int MiddleNumber(int number)
{
    int number1 = number / 10;
    return number1 % 10;
}
Console.WriteLine(MiddleNumber(number));
