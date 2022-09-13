//2. сум элементов на нечетных позициях- индекс, 
//3. массив веществ цифр nextdooble() - от 0 до 1 рандомн нехт + некст дабл. Искать макс и мин через циклы

int[] Array(int size, int minValue, int maxValue) // заполняем массив случайными числами c параметрами пользователя
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(minValue, maxValue);
    return array;
}

int FindEvenNumbers(int[] array)  // поиск кол-ва четных элементов в массиве
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) count++;

    return count;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine("\b]");
}

int[] ArrayRandom()
{
    int size = new Random().Next(1, 20);
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 1000);
    return array;
}

int SummElements(int[] array) // поиск суммы элементов, стоящих на нечётных позициях
{
    int count = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (i % 2 == 0)
            count = count + array[i];
    }
    return count;
}

double[] ArrayDouble(int size, int minValue, int maxValue) //массив с вещественными числами рандомно
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(minValue, maxValue) + new Random().NextDouble();
    return array;
}

double DifferenceMinMax(double[] array) // поиск разницы между максимальным и минимальным элементом массива
{
    double min = array[0];
    double max = array[0];
    double count = 0;

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];

        count = max - min;
    }
    return count;
}

void PrintArrayDouble(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine("\b]");
}


// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
// %%% Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. %%%
// %%%            Напишите программу, которая покажет количество чётных чисел в массиве.     %%%
// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

/*
Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value a three-digit number: ");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value a three-digit number: ");
int maximum = Convert.ToInt32(Console.ReadLine());

if (size > 0 & minimum > 99 & maximum < 1000)
    {
        int[] arrayThreeDigit = Array(size, minimum, maximum);
        PrintArray(arrayThreeDigit);
        Console.WriteLine($"Number of even elements equal: {FindEvenNumbers(arrayThreeDigit)}");
    }
else
        Console.WriteLine(" ERROR: The entered number does not match the specified parameters");
*/


// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
// %%% Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. %%%
// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

/*
int[] newArray = ArrayRandom();
PrintArray(newArray);
Console.WriteLine($"Sum element equal: {SummElements(newArray)}");
*/



// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. %%%
// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

Console.Write("Input size of array > 1: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value a three-digit number: ");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value a three-digit number: ");
int maximum = Convert.ToInt32(Console.ReadLine());

if (size > 1)
{
    double[] array = ArrayDouble(size, minimum, maximum);
    PrintArrayDouble(array);
    Console.WriteLine($"The difference between the minimum and maximum values of the array is: {DifferenceMinMax(array)}");
}
else
    Console.WriteLine(" ERROR: The entered array size does not match the specified parameters");


