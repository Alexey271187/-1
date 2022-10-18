// Напишите программу, которая на вход принимает число 
//и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Программа для определения четное ли число");
Console.WriteLine("Впишите число");
int numberA = int.Parse(Console.ReadLine()!);
if (numberA%2 == 0)
{
    Console.WriteLine("Да " + numberA + " четное" );
}

else Console.WriteLine("Нет " + numberA + " не четное");
