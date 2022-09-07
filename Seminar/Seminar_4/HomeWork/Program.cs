//**********************************************************************************************************************
//***Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B***
//**********************************************************************************************************************

/*
int Exponentiation (int number1, int number2)
{
    int count = number1;
    for (int i = 1; i < number2; i++) count *= number1;
    return count;
}

Console.Write("Enter number A: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number B: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Number {num1} to the power of {num2} is equal to {Exponentiation(num1, num2)}");

*/

//************************************************************************************************
//***Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе***
//************************************************************************************************

/*

int Sum(string number)
{
    int [] arr = new int [number.Length];
    for(int i = 0; i < number.Length; i++) arr[i] = Convert.ToInt32(number.Substring(i, 1)); //Записываем число в массив
    int count = 0;
    for(int i = 0; i < arr.Length; i++) count += arr[i];
    return count;
}

Console.Write("Enter integer numbers: ");
string sumNumbers = Console.ReadLine();
Console.WriteLine($"The sum of the digist of the number {sumNumbers} = {Sum(sumNumbers)}");

*/

//***********************************************************************************************
//***Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран***
//***********************************************************************************************
/*

int [] Arr (int number) //метод записи массива пользователем через консоль
{
    int [] array = new int [number];
    for(int i = 0; i < number; i++)
    {
        Console.Write($"Enter number №{i+1} of the array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}


void PrintArray (int [] array) //метод печати массива
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++) Console.Write($"{array[i]}, ");
    Console.Write("\b\b]");
}

Console.Write("Enter the required number of array numbers: ");
int quantity = Convert.ToInt32(Console.ReadLine());

PrintArray(Arr(quantity));

*/


