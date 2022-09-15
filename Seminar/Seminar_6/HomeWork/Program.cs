// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
// %%% Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. %%%
// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
/*

int temp = 0;
int quality = 0;
bool i = false;

while (i == false)
{
    Console.Write("Enter any integers in turn: ");
    int number = Convert.ToInt32(Console.ReadLine());
    quality++;

    if (number == 0)
        temp++;

    Console.Write("If you want to continue typing, enter 'yes', finish - enter 'no': ");
    string ending = Convert.ToString(Console.ReadLine());

    if (ending == "no")
        i = true;
}

Console.WriteLine($"Entered {quality} numbers of which '0' - {temp} pieces");

*/

// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
// %%% Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями %%%
// %%%            y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.     %%%
// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

void IntersectionStraightLines(double b1, double k1, double b2, double k2)
{

    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * (b2 - b1) / (k1 - k2) + b1;
    
    Console.Write("[");
    Console.Write(Math.Round(x, 1));
    Console.Write(Math.Round(y, 1));
    Console.Write("]");
}

Console.Write("Enter point 'b1': ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter point 'k1': ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter point 'b2': ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter point 'k2': ");
double k2 = Convert.ToDouble(Console.ReadLine());

IntersectionStraightLines(b1, k1, b2, k2);