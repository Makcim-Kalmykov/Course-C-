// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
// %%% Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. %%%
// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
/*

void ShowNumber(int numA, int numB)
{
    Console.Write(numA + " ");
    if (numA < numB)
        ShowNumber(numA + 1, numB);

}

Console.Write ("Input numbre 'A': ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input numbre 'B': ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Natural numbers in berween from {a} to {b}:");

ShowNumber(a, b);

*/


// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
// %%% Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. %%%
// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
/*

int SumNumber(int numC, int numD)
{
    if (numC <= numD)
        return SumNumber(numC + 1, numD) + numC;
    return 0;
}

Console.Write("Input numbre 'M': ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbre 'N': ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumNumber(m, n));

*/


// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
// %%% Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. %%%
// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%


int AckermannRec(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return AckermannRec(m - 1, 1);
    else
        return AckermannRec(m - 1, AckermannRec(m, n - 1));
}

Console.WriteLine(AckermannRec(3, 2));



