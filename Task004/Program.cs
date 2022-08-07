// Напишите программу, которая на вход принимает 
// одно число (N), а на выходе показывает 
// все целые числа в промежутке от -N до N

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = -1-number;
while (i < number)
{
    i += 1;
    Console.Write(i);
}


