
//------------------------------------------------------------------------------------------------------------------------
// Задача 1. Напишите программу, которая выводит случайное число из отразка [10, 99] и показывает наибольшую цифру числа
//------------------------------------------------------------------------------------------------------------------------
/*


int FindBiggerDijit(int number)
{
    int ed = number % 10; // оставляем последнее число 
    int dec = number / 10; //оставляем десятки


    //Вариант 1

    int result; //объявляем переменную

    if (ed > dec) result = ed;
    else result = dec;

    return result;

    

   //Вариант 2
   // if (ed > dec) return ed;
   // else return dec;


}

int randNumber = new Random().Next(10, 100); // записываем в переменную рандомное число от 10 до 99
int biggerDigit = FindBiggerDijit (randNumber); // в метод FindBi.. мы положили переменную с рандомным числом 

Console.WriteLine($"Bigger digit of {randNumber} is {biggerDigit}");

*/


//--------------------------------------------------------------------------------------------------------
//Задача 1. Взять трехзначное число, удалить середину, вывести двухзначное число
//--------------------------------------------------------------------------------------------------------
/*

int CuttingMiddle(int number)
{
    int result = (number / 100)*10 + number % 10;

    return result;
    
}

Console.Write("Imput three-digit number ");
int number =  Convert.ToInt32(Console.ReadLine());
int result = CuttingMiddle(number);
Console.WriteLine($"First and tird symbol number {number} its {result}");

*/



//--------------------------------------------------------------------------------------------------------------------------------------
//Задача 2. Принять на вход два чила и вывести: является ли второе число кратное первому. Если не кратное, то вывести остаток от деления.
//--------------------------------------------------------------------------------------------------------------------------------------
/*


void Proverka(int num1, int num2)
{
    if (num2 % num1 == 0) Console.WriteLine($"Number {num2} multiple {num1}");
    else
    {
        int remains = num2 % num1;
        Console.WriteLine($"Remainder of the division {num2} by {num1} equal {remains}");
    } 
}

Console.WriteLine("Input firts naumbers: ");
int numb1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second naumbers: ");
int numb2 = Convert.ToInt32(Console.ReadLine());

Proverka(numb1, numb2);

*/



//-----------------------------------------------------------------------------------------------------------------
//Задача 3. Принять число на вход и проверить кратно ли оно заданному числу1 и числу2. Вернуть логический тип bool.
//-------------------------------------------------------------------------------------------------------------------
/*


void crat(int num1, int num2, int num3)
{
    bool result;
    if(num1 % num3 == 0) 
    {
        result = true; 
        Console.WriteLine(result);
    }

    else if(num2 % num3 == 0) 
    {
        result = true;
        Console.WriteLine(result);
    }
    
    else 
    {
        result = false;
        Console.WriteLine(result);
    }
}

int crat1(int num1, int num2, int num3)
{
    int result;
    if(num1 % num3 == 0) result = 1;
    else if(num2 % num3 == 0) result = 1; 
    else result = 0;
    return result;
}


//Вариант 1

//Console.WriteLine("Input firts naumbers: ");
//int numb1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second naumbers: ");
// int numb2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input the third number, multiple of the first or second number: ");
// int numb3 = Convert.ToInt32(Console.ReadLine());
// crat(numb1, numb2, numb3);

//Вариант 2

Console.WriteLine("Input firts naumbers: ");
int numb1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second naumbers: ");
int numb2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the third number, multiple of the first or second number: ");
int numb3 = Convert.ToInt32(Console.ReadLine());

int res = crat1(numb1, numb2, numb3);
bool result = Convert.ToBoolean(res);

Console.WriteLine(result);

*/
//------------------------------------------------------------------------------------------------------------------
//Задача 4. Принять на вход 2 числа и проверить, является ли одно квадратом другого. Вернуть логический тип bool.
//------------------------------------------------------------------------------------------------------------------
/*


int square(int num1, int num2)
{int result;
    if(num1 == num2 * num2) result = 1;
    else if(num2 == num1 * num1) result = 1; 
    else result = 0;
    return result;
}

Console.WriteLine("input too nambers, one of which is the square of the other");
Console.Write("Input firts naumbers: ");
int numb1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second naumbers: ");
int numb2 = Convert.ToInt32(Console.ReadLine());

int res = square(numb1, numb2);
bool result = Convert.ToBoolean(res);

Console.WriteLine(result);

*/


//-----------------------------------------------------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------------------------------------------------
                                                  // РЕШЕНИЕ ПРЕПОДАВАТЕЛЯ
//-----------------------------------------------------------------------------------------------------------------------------
//-----------------------------------------------------------------------------------------------------------------------------

//--------------------------------------------------------------------------------------------------------
//Задача 1. Взять трехзначное число, удалить середину, вывести двухзначное число
//--------------------------------------------------------------------------------------------------------

