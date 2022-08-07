// Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих чисел.


Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2 && number1 > number3)
{
    Console.Write($"Число {number1} больше");
} 
else if (number2 > number1 && number2 > number3)
{
    Console.Write($"Число {number2} больше");
}
else
{
    Console.Write($"Число {number3} больше");
}