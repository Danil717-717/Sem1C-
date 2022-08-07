// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее


Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.Write($"Число {number1} больше");
} 
else
{
    Console.Write($"Число {number2} больше");
}
