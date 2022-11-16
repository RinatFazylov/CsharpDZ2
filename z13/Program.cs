// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// Выполнить с помощью числовых операций (целочисленное деление,
// остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result1 = number ;
int result2 = number ;
int count1 = 0;
int count2 =0;

if ((number / 100) == 0)
{
    Console.WriteLine($"{number} --> Третьей цифры нет ");
}
else
{
        while ((result1 / 10) > 0)   
    {
        result1 = result1 / 10;
        count1++;
    }
    
         while
        (count2 < (count1-2))
    { 
    result2 = result2 / 10;
    count2++;
    }
    int itog= result2 % 10;
    Console.WriteLine ($"3е число числа {number} ----> {itog}  ");




}





