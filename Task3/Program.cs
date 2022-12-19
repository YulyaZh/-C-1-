// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
Console.Write("Введите число:"); 
int number1 = int.Parse(Console.ReadLine());

 if (number1 % 2 == 0)
{
Console.Write("четное число");
}
else 
{
Console.Write("нечетное число");
}
