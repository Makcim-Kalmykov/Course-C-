//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
//%%% Задача 1. Принимает число N и выдает сумму чисел от 1 до N %%%
//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
/*

int FindSum(int a)
{
    int sum = 0;
    for(int current = 1; current<=a; current++) sum += current;
    return sum;
}

Console.WriteLine("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"sum of numbers from 1 to {num} is {FindSum(num)}");

*/

//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
//%%% Задача 2. Принимает на вход число и возвращает кол-в оцифр в этом числе (через строку, через деление на 10) %%%
//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

//------------%%% Вариант 1 %%%-------------
/*
int DigitsNumber(int number)
{
    string num = number.ToString(); //переводим число в строку
    int result = num.Length; 
    return result;
}

Console.WriteLine("Inter number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Number of digits of the number {number} = {DigitsNumber(number)}");

*/

//------------%%% Вариант 2 %%%%-------------
/*
int DigitsNumber(int number)
{
    int result = 1;
    for(int current = 1; number > 10; current++)
    {
        number /= 10; 
        result ++;
    } 
    return result;
}

Console.WriteLine("Inter number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Number of digits of the number {number} = {DigitsNumber(number)}");

*/

//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
//%%% Задача 3. Найти факториал %%%
//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
/*

int Factorial (int number)
{
    int result = 1;
    for(int temp = 1; temp <= number; temp++) result = result * temp;
    return result;
}

Console.WriteLine("Inter positive integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Factorial number {number} = {Factorial(number)}");

*/


//***Выводит массив из 8 элементов, заполненных 0 и 1 в случайном порядке (метод Random Next)***

/* мой вариант
void Random (int [] array)
{
    int [] arr = new int [8];
    Random rand = new Random();
    for(int i = 0; i < array.Length; i++) arr[i] = rand.Next(0, 1);
    return arr;
}

int[] array = Random;

Console.WriteLine(arrays);

*/

// из зала

int [] CreateRandomArray(int n, int minVal, int maxVal)
{
    int [] arr = new int [n];
    for(int i = 0; i < n; i++) arr[i] = new Random().Next(minVal,maxVal+1); // новый обьект класса Random, который вызывает метод Next, который возвращает цифру
    return arr;
}


void PrintArray(int [] arr)
{
    Console.Write("[");
    for (int i = 0; i<arr.Length; i++) Console.Write($"{arr[i]}, ");
    Console.WriteLine("\b\b ]");
}

PrintArray(CreateRandomArray(8, 0, 1));

//int [] newArr = CreateRandomArray(8, 0, 1); создали сразу новый массив с результатом работы метода
//PrintArray(newArr);