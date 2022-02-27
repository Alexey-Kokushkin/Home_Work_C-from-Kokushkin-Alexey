// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число N: ");
String inputnumber = Console.ReadLine();
int N = int.Parse(inputnumber);
int A = 1;
while (A <= N)
{
    int evennumbber = A % 2;
    if (evennumbber == 0)
    {
        Console.Write(A + " ");
    }
    A = A + 1;
}
Console.WriteLine(" - Все четные числа в промежутке от 1 до введенного числа N");