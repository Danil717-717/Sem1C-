// Напишите программу, которая на вход принимает два числа
// и проверяет, 
// является ли первое число квадратом второго.

Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 == number1 * number1)
{
    Console.Write("Да");
} 
else
{
    Console.Write("Нет");
}

