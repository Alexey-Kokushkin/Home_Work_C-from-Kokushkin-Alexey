// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Введите число: ");
String inputnumber = Console.ReadLine();
int number = int.Parse(inputnumber);
int evennumbber = number % 2;
if (evennumbber == 0)
{
    Console.WriteLine("Данное число" + " " + number +  " " + "является четным");
}
else
{
    Console.WriteLine("Данное число" + " " + number + " " + "является нечетным");
}