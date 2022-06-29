// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите любое число");
int number = Convert.ToInt32(Console.ReadLine());
int FindThird(int number)
{
if (number < 100)
{
    Console.WriteLine("Третьей цыфры нет");
}
while (number > 999)
{
   number = number / 10;
}
return number % 10;
}

Console.WriteLine($"Третья цифра числа - {FindThird(number)}");
