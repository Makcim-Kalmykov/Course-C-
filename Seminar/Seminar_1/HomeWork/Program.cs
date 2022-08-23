/*
//Задача Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
    Console.WriteLine($"Namber {num1} > {num2}");
else
    Console.WriteLine($"Namber {num1} < {num2}");

*/

/*
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//Вариант 1:
Console.Write("Input first integer namber: ");
int namber1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer namber: ");
int namber2 = Convert.ToInt32(Console.ReadLine());
Console.Write("input theid integer namber: ");
int namber3 = Convert.ToInt32(Console.ReadLine());

int max = namber1;

if(namber2 > max)
    max = namber2;

if(namber3 > max)
    max = namber3;

Console.WriteLine($"Maximum namber: {max}");


//Вариант 2:
int syze = 3;
int[] numbers = new int[syze];
        for (int i = 0; i < syze; i++)
       {
        Console.Write($"Input {syze} integer namber: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
       } 
int current = 0;
int num = 0;
int max = numbers[num];

while(current <= syze-1)
{
    if(numbers[num] > max)
    {
        max = numbers[num];
    }
    current++;
    num++;
}

Console.WriteLine($"Maximum numbers: {max}");

*/


/*

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Input integer namber: ");
int namb = Convert.ToInt32(Console.ReadLine());

if(namb % 2 == 0)
{
    Console.WriteLine($"Число {namb} чётное");
}
else
    Console.WriteLine($"Число {namb} нечётное");

*/


//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input positive integer number: ");
int num33 = Convert.ToInt32(Console.ReadLine());

int nam44 = 0;
Console.Write($"The number has {num33} even numbers: ");
while(nam44 < num33 - 1)
    {
        nam44 = nam44 + 2;
        Console.Write($"{nam44} ");
    }