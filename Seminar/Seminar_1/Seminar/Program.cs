/*
// Задача 1. Текст задачи.

Console.Write("Input integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

int kvadrat = number * number;

Console.WriteLine($"Quad of {number} is {kvadrat}");

*/

/*
// Задача 2. Напишите программу, которая на входе принимает два числа и проверяет, является ли первое число квадратом второго.

Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 * num2)
{
    Console.WriteLine($"{num1} is a quad of {num2}");
}
else
    Console.WriteLine($"{num1} is not a quad of {num2}");

*/

/*
//Задача 3. Напишите программу, которрая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от (-N до N)

Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = num * (-1); //current = -num

while (current <= num)
{
    Console.Write(current + " ");
    current++;
}

*/



//Задача 4. Напсать программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа.

Console.Write("Input three-digit integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = num % 10;

Console.WriteLine($"Last digit of {num} is {result}");