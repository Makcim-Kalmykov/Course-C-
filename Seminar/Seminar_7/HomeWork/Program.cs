// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
// %%% Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. %%%
// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
/*

double[,] CreateRandomArray()
{
    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input numbers of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input max possible value: ");
    int  maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] newArray = new double[rows, colums];

    for (int i = 0; i < newArray.GetLength(0); i++)
        for (int j = 0; j < newArray.GetLength(1); j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();

    return newArray;
}

void ShowArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(Math.Round(array[i, j],1) + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] myArray = CreateRandomArray();
ShowArray(myArray);

*/

// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
// %%% Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и %%%
// %%%            возвращает значение этого элемента или же указание, что такого элемента нет.          %%%
// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
/*

int[,] CreatRandomArray()
{
    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input numbers of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, colums];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void CheckingElements(int[,] array)
{
    Console.Write("Enter the rows number of the required element to search for (counting rows starts from 0, 1, 2...): ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the column number of the required element for the search (the count of columns starts from 0, 1, 2...): ");
    int column = Convert.ToInt32(Console.ReadLine());

    if (rows <= array.GetLength(0) & column <= array.GetLength(1))
        Console.WriteLine($"The value of the element {rows} rows {column} columns is equal to {array[rows,column]}");
    else Console.WriteLine($"Element {rows} rows {column} columns is missing in the array");

}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }

    Console.WriteLine();
}


int[,] arrayTask50 = CreatRandomArray();
CheckingElements(arrayTask50);

//ShowArray(arrayTask50); //проверка выданного значения

*/


// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
// %%% Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. %%%
// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

int[,] CreatRandomArray()
{
    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, colums];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ShowArrayDouble(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
        Console.Write(Math.Round(array[i], 1) + " ");
    Console.WriteLine("\b]");
}

double[] ArithmeticMean(int[,] array)
{
    double[] newArray = new double[array.GetLength(1)]; //длинна массива исходя из кол-ва столбцов

    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
            newArray[i] = newArray[i] + array[j, i];
        newArray[i] /= array.GetLength(0);
    }
    return newArray;
}

int[,] arrrayTask52 = CreatRandomArray();
ShowArray(arrrayTask52);
double[] arrayDouble = ArithmeticMean(arrrayTask52);
Console.WriteLine("The arithmetic mean of the elements in each column: ");
ShowArrayDouble(arrayDouble);



