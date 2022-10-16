//Задача 4: Напишите программу, 
//которая принимает на вход три числа и 
Console.WriteLine("Программа для поиска максимального числа из тех чисел");
Console.WriteLine("Впишите первое число");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Впишите второе число");
int numberB = int.Parse(Console.ReadLine()!);
Console.WriteLine("Впишите третье число");
int numberC = int.Parse(Console.ReadLine()!);
int max = 0;
//выдаёт максимальное из этих чисел
if(numberA>numberB)
{
    max = numberA;
}
else
{
    max = numberB;
}
if(max>numberC)
{
    Console.WriteLine("Максимальное число");
    Console.WriteLine(max);
}
else
{
    Console.WriteLine("Максимальное число");
    Console.WriteLine(numberC);
}

    
