// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
String inputnumberOne = Console.ReadLine();
int numberOne = int.Parse(inputnumberOne);
Console.WriteLine("Введите второе число: ");
String inputnumberTwo = Console.ReadLine();
int numberTwo = int.Parse(inputnumberTwo);
Console.WriteLine("Введите третье число: ");
String inputnumberThree = Console.ReadLine();
int numberThree = int.Parse(inputnumberThree);
int max = numberOne;
if (numberTwo > numberOne)
{
    if (numberTwo > numberThree)
    {
        max = numberTwo;
        Console.WriteLine("Это максимальное число: " + max);
    }
    else
    {
        max = numberThree;
        Console.WriteLine("Это максимальное число: " + max);
    }
    

}
else
{
    if (numberTwo > numberThree)
    {
        max = numberOne;
        Console.WriteLine("Это максимальное число: " + max);
    }
    else
    {
        if (numberOne > numberThree)
        {
            max = numberOne;
            Console.WriteLine("Это максимальное число: " + max);
        }
        else
        {
            max = numberThree;
            Console.WriteLine("Это максимальное число: " + max);
        }
    }
}