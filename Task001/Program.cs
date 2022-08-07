//Напишите программу, которая на вход 
//принимает число и выдаёт его квадрат 

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number*number;
Console.Write($"Квадрат числа {number}: ");
Console.Write(result);
