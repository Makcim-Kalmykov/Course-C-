//------------------------------------------------------------------------------------------------------------------------------------
//----Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.-----
//------------------------------------------------------------------------------------------------------------------------------------
/*

int TooNumbers (int numbers)
{
    int a;
    a = (numbers % 100)/10;
    return a;
}

Console.Write ("Input three-digit numbers: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = TooNumbers(num);

if(result > 0 ) Console.WriteLine ($"The second digit numbers {num} its {result}");
else Console.WriteLine($"Numbers {num} does not have a second digit");

*/


//-------------------------------------------------------------------------------------------------------------------------
//----Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.-----
//-------------------------------------------------------------------------------------------------------------------------
/*

int ThreeNumbers (int numbers)
{
    int a;
    a = (numbers /100) % 10;
    return a;
}

Console.Write ("Input three-digit numbers: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = ThreeNumbers(num);

if(result > 0 ) Console.WriteLine ($"The third digit numbers {num} its {result}");
else Console.WriteLine($"Numbers {num} does not have a third digit");

*/

//------------------------------------------------------------------------------------------------------------------------------------------
//--Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.--
//------------------------------------------------------------------------------------------------------------------------------------------

int Weekend (int numbers)
{
    int res = 0;
    if (numbers == 6) res = numbers;
    else if (numbers == 7) res = numbers;
    return res; 
}

Console.Write ("Enter a number indicating the day of the week: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 7) Console.WriteLine ("The entered number does not indicate the day of the week");
else 
{
    if (num <= 0) Console.WriteLine ("The entered number does not indicate the day of the week");
    else
    {
    int result = Weekend(num);
    if (result > 0) Console.WriteLine ($"The entered number {num} is the output");
    else Console.WriteLine($"The entered number {num} is not an output");
    }
}
