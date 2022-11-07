//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
System.Console.WriteLine("Введите первое число");
double number1 = double.Parse(Console.ReadLine ()!);
System.Console.WriteLine("Введите второе число");
double number2 = double.Parse(Console.ReadLine ()!);

if (number1 > number2)
{
    Console.Write($"{number1} > {number2}");
}
else
{
     Console.Write($"{number1} < {number2}");
}