// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе 
// показывает последнюю цифру этого числа

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int a = number % 10;
Console.Write($"Последняя цифра числа {number}:  ");
Console.Write(a);

