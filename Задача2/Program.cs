// Описание
Console.WriteLine("Программа для поиска большего числа и двух");
// Ввод чисел
Console.WriteLine("Впишите первое число");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Впишите второе число");
int numberB = int.Parse(Console.ReadLine()!);
// Выбираем большее и ыводим в консоль
if(numberA>numberB)
{
    Console.WriteLine("Число");
    Console.WriteLine(numberA);
    Console.WriteLine("Больше");
}
else
{
    Console.WriteLine("Число");
    Console.WriteLine(numberB);
    Console.WriteLine("Больше");
}


