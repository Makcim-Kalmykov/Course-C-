
// Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// обязательно должно быть условие существования или завершения рекурсии
// действия в реаурсии могут происходить либо гна стадии раскрытия, либо на стадии сворачивания


void ShowNums(int n) //вывод 1 2 3 4 5
{
    //if (n>1) ShowNums(n) такое условие никогда не получится
    if (n > 1) ShowNums(n - 1); // метод проверяет сам себя. может ли он раскрыться еще больше, только в качестве аргумента 
                                // отправляет число n- 1, запускается заново и оптять проверка условия
    Console.Write(n + " ");
}


void ShowNums1(int n) //вывод 5 4 3 2 1 
{
    Console.Write(n + " ");
    if (n > 1) ShowNums1(n - 1);
}

void ShowNums2(int n) //вывод 1 2 3 4 5 и 5 4 3 2 1 
{
    Console.Write(n + " ");
    if (n > 1) ShowNums2(n - 1);
    Console.Write(n + " ");
}

/*

ShowNums(5);
Console.WriteLine();
ShowNums1(5);
Console.WriteLine();
ShowNums2(5);

*/


// Задача 2. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

/*

int SumOfDigits(int n)
{
    if (n > 0) return SumOfDigits(n / 10) + n % 10; //забрали из числа 5734 цифру 4 и запустили метод еще раз; 
                                                    //отправляем число 573 на проверку, забираем 3 и т.д...последний запоминает 5 и отдает 0
                                                    // 0>0 - нет возвращаем в предыдущ вызов 0 + 5, возвращаем в предыдущий 5 + 7 и т.д.

    else return 0;
}

Console.WriteLine(SumOfDigits(5374));

*/


// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
// %%% Задача 3: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. %%%
// %%%           предусмотреть вариант, кода m > n                                                                         %%%
// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

/* %%%%% Мой вариант %%%%%%

void ShowNumbers(int m, int n)
{
    if (n > m) ShowNumbers(m, n - 1);
    Console.Write(n + " ");
}

Console.Write("Input number 'm'");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number 'n'");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM > numberN)
{
    int temp = numberM;
    numberM = numberN;
    numberN = temp;
}

ShowNumbers(numberM, numberN);

*/

// %%%%% Вариант из зала %%%%%%

void ShowNumbers(int n, int m) // вывод -5 -4 -3 -2 -1 0
{
    if (Math.Max(n, m) != Math.Min(n, m))
        ShowNumbers(Math.Max(n, m) - 1, Math.Min(n, m));

    Console.WriteLine($"{Math.Max(n, m)} ");
}

void ShowNumbers(int n, int m) // вывод в обратную сторону 0 -1 -2 -3 -4 -5 
{
    if (Math.Max(n, m) != Math.Min(n, m))
        ShowNumbers(Math.Max(n, m) - 1, Math.Min(n, m));

    Console.WriteLine($"{Math.Max(n, m)} ");
}



// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
// %%% Задача 4: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии. %%%
// %%%           не void; 2 может быть возведено не отлько в степень 3, но и "-3" 2 в степени "-3" = 1/2^3                               %%%
// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

/* Вариант 1

double DegreeNumber(double a, double b)
{
    if (b > 1) return DegreeNumber(a, b - 1) * a;
    else return a;
}

Console.Write("Input numbers: ");
double numbers = Convert.ToDouble(Console.ReadLine());
Console.Write("Input degree of the number: ");
double degreeNumbers = Convert.ToDouble(Console.ReadLine());

if (degreeNumbers > 0)
    Console.WriteLine(DegreeNumber(numbers, degreeNumbers));
else 
{
    degreeNumbers = degreeNumbers * -1;
    Console.WriteLine(1/DegreeNumber(numbers, degreeNumbers));
}

*/


// Вариант 2 ???

double DegreeNumber(double a, double b)
{
    if (b < 0)
    {
        b = b * -1;
        Console.WriteLine(b);
        Console.WriteLine(1 / DegreeNumber(a, b));
        return b;
    }

    else
    {
        if (b > 1) return DegreeNumber(a, b - 1) * a;
        else return a;
    }
}

Console.Write("Input numbers: ");
double numbers = Convert.ToDouble(Console.ReadLine());
Console.Write("Input degree of the number: ");
double degreeNumbers = Convert.ToDouble(Console.ReadLine());

/*
if (degreeNumbers > 0)
    Console.WriteLine(DegreeNumber(numbers, degreeNumbers));
else
{
    degreeNumbers = degreeNumbers * -1;
    Console.WriteLine(1 / DegreeNumber(numbers, degreeNumbers));
}
*/

DegreeNumber(numbers, degreeNumbers);


// %%%% Вариант из зала %%%%%

double PowerUp(double x, int pow) //только для положительной степени
{
    if (pow != 0)
        return x * PowerUp(x, pow - 1);
    else return x;
}


double GetPower(int A, int B) //только для положительной степени
{
    if (B >= 1) return GetPower(A, B - 1) * A;
    if (B <= 1) return GetPower(A, B + 1) / A;

    return 1.0;
}
