// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Программа для поиска четных чисел от 1 до N");
Console.WriteLine("Впишите число N");
int numberA = int.Parse(Console.ReadLine()!);
int numberB = 2;
if (numberA>0)
{
    while (numberA>=numberB)
    {
        Console.Write(numberB + ", ");  
        numberB=numberB + 2;
    }
}
else Console.WriteLine("Введите число больше 1");
