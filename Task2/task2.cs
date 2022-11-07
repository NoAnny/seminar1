// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
Console.WriteLine("Enterin 1st number");
double number1 = double.Parse(Console.ReadLine ()!);
Console.WriteLine("Enterin 2nd number");
double number2 = double.Parse(Console.ReadLine ()!);
Console.WriteLine("Enterin 3d number");
double number3 = double.Parse(Console.ReadLine ()!);
double max = number1;
if(number2 > max)
{
    max = number2;
}
if(number3 > max)
{
    max = number3;
}
Console.WriteLine($"The biggest is {max}");
