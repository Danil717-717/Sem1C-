// Напишите программу, которая будет выдавать 
// название дня недели по заданному номеру

Console.Write("Введите число от 1 до 7 и получите день недели: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 == 1)
{
    Console.Write("Понедельник");
} 
else if (number1 == 2)
{
    Console.Write("Вторник");
}
else if (number1 == 3)
{
    Console.Write("Среда");
}
else if (number1 == 4)
{
    Console.Write("Четверг");
}
else if (number1 == 5)
{
    Console.Write("Пятница");
}
else if (number1 == 6)
{
    Console.Write("Суббота");
}
else if (number1 == 7)
{
    Console.Write("Воскресенье");
}
else
{
    Console.Write("Нужно от 1 до 7!");
}
