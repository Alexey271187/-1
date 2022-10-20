// Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа. Через строку решать нельзя.

//456 -> 5
//782 -> 8
//918 -> 1
Console.WriteLine("Программа для поиска второй цифры трехзначного числа");
Console.WriteLine("Впишите трехзначное число");
int numberA = int.Parse(Console.ReadLine()!);
int numberB = 0;
if(numberA < 1000)
{
    if(numberA > 99)
    {
        numberB = numberA / 10 % 10;
        Console.WriteLine("Вторая цифра: " + numberB);
    }
    else 
    {
        Console.WriteLine("Вы ввели не трехзначное число");
    }
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число");
}