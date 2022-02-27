// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 ->  max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число: ");
String inputnumberOne = Console.ReadLine();
int numberOne = int.Parse(inputnumberOne);
Console.WriteLine("Введите второе число: ");
String inputnumberTwo = Console.ReadLine();
int numberTwo = int.Parse(inputnumberTwo);
int maximum = numberOne;
int minimum = numberTwo;
if (numberTwo > numberOne)
{
    maximum = numberTwo;
    minimum = numberOne;
    Console.WriteLine("Минимальное число: " + minimum);
    Console.WriteLine("Максимальное число: " + maximum);
}
else
{
    maximum = numberOne;
    minimum = numberTwo;
    Console.WriteLine("Минимальное число: " + minimum);
    Console.WriteLine("Максимальное число: " + maximum);
}