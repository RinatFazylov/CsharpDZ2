// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите день недели:");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 0 && day < 8)
    if (day == 6 || day == 7)
    {
        Console.WriteLine($"{day} -> Выходной");
    }
    else 
    {
        Console.WriteLine($"{day} -> Рабочий день");
    }
    else 
    {
        Console.WriteLine($"{day} -> Введите число от 1 до 7");
    }
