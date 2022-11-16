// Задача 10: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру 
// этого числа. Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).
// 456 -> 5
// 782 -> 8  
// 918 -> 1

Console.WriteLine("Введите Трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if ((Math.Abs(number) < 99) || (Math.Abs(number) > 999))
{
    Console.WriteLine("Число не трехзначное, введите другое число");
}
else
{
    int firstD = number % 100;
    int result = firstD / 10;
    int res = Math.Abs (result);    // если нужно отрицательное число, удаляем эту строку.
    Console.WriteLine($"{number} -> {res}");
}







