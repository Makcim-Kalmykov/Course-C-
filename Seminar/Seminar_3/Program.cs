/*
//------------------------------------------------------------------------------
//---Задача 1. Принимает на вход координаты точки "А" и вернет номер четверти--- 
//------------------------------------------------------------------------------

int FindQuadrant(double x, double y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x > 0 && y < 0) return 3;
    if(x < 0 && y < 0) return 4;

    return 0;
}

Console.WriteLine("Input X coordinate: ");
double xA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input Y coordinate: ");
double yA = Convert.ToDouble(Console.ReadLine());

int quadrant = FindQuadrant(xA, yA);
Console.WriteLine("Number of quadrant is " + quadrant);

*/


/*
//----------------------------------------------------------------------------------------------------------------------------
//---Задача 2. По заданному номеру четверти покажет диапазон точек этой четверти. Вывод в строку (x > 0, y > 0; метод void)---
//----------------------------------------------------------------------------------------------------------------------------

void Quarter(int num)
{   
    if(num <= 0) Console.WriteLine ("The entered number does not correspond to the number of the quarter of the coordinate system");
    if(num > 4) Console.WriteLine ("The entered number does not correspond to the number of the quarter of the coordinate system");
    if(num == 1) Console.WriteLine ("The range of values lies from x > 0 and y > 0");
    if(num == 2) Console.WriteLine ("The range of values lies from x < 0 and y > 0");
    if(num == 3) Console.WriteLine ("The range of values lies from x > 0 and y < 0");
    if(num == 4) Console.WriteLine ("The range of values lies from x < 0 and y < 0");
}

Console.Write("Enter the number of the quarter of the coordinate system:");
int number = Convert.ToInt32(Console.ReadLine());

Quarter(number);

*/


/*
//-------------------------------------------------------------------------------------------------------------------------------------------
//---Задача 3. Принимает на вход число N и выдает квабраты чисел от 1 до числа N (число 4; 1, 2, 4, 9, 16) метод void; вывод через консоль---
//-------------------------------------------------------------------------------------------------------------------------------------------

void SquareNumbers(int number)
{
    int i = 1;
    int result = i * i;
    if (number > 0)
    {
        while(i-1 < number)
        {
            result = i * i;
            i++;
            Console.WriteLine(result); 
        }
        
    }
    else Console.WriteLine($"Entered number {number} <1");
}

Console.Write("Enter the integer number >= 1: ");
int number = Convert.ToInt32(Console.ReadLine());

SquareNumbers (number);

*/


//------------------------------------------------------------------------------------------------------
//---Задача 4. Принимает на вход координаты двух точек и находит расстояние между ними. (4 аргумента)---
//------------------------------------------------------------------------------------------------------


double Distance(int xA, int yA, int xB, int yB)
{
    int squareHypotenuse = (xB - xA)*(xB - xA) + (yB - yA)*(yB - yA);
    double result = Math.Sqrt(squareHypotenuse); 
    return result;
}

Console.Write("Enter the coordinates xA points A: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the coordinates yA points A: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the coordinates xB points B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the coordinates yB points B: ");
int yB = Convert.ToInt32(Console.ReadLine());

double result = Distance(xA, yA, xB, yB);
Console.WriteLine(result);

