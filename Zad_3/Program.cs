// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру обозначающую день недели");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber < 1 ^ dayNumber > 7)
{
    Console.WriteLine("Эта цифра не соответствует дню недели, введите цифру от 1 до 7 !");
}

bool IfRestDay(int dayNumber)
{
    return (dayNumber == 6 ^ dayNumber ==7);
} 

Console.WriteLine($"Выходной! {IfRestDay(dayNumber)}");




