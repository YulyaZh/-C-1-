// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.Write("Введите число:"); 
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите еще одно число:");
int number2 = int.Parse(Console.ReadLine());
 if (number1 > number2)
{
Console.WriteLine("{0} наибольшее число", number1);
}
else
{
Console.WriteLine("{0} наибольшее число", number2);
}
