/*

int[,] CreatRandom2dArray()//двумерный массив рандом; аргументы просим в методе
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

void ShowArray2d(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }

    Console.WriteLine();
}


int[,] myArray = CreatRandom2dArray();
ShowArray2d(myArray);
*/


// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
// %%% Задача 1: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. %%%
// %%%           Выведите полученный массив на экран. array[4,6] = 4 + 6                                            %%%
// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

/*         

int[,] CreatRandom2dArray()
{
    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input numbers of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, colums];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            newArray[i, j] = i+j;

    return newArray;
}

void ShowArray2d(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }

    Console.WriteLine();
}

int[,] myArray = CreatRandom2dArray();
ShowArray2d(myArray);

*/


// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
// %%% Задача 2: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените %%%
// %%%           эти элементы на их квадраты. (возвести в квадрат); вернуть и распечатать массив      %%%
// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

/*

int[,] CreatArray()
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

    for (int i = 0; i < newArray.GetLength(0); i++)
        for (int j = 0; j < newArray.GetLength(1); j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void ShowArray2d(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
            
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] QuadroArray(int[,] array)
{
    int temp = array[2,2];
    for (int i = 2; i < array.GetLength(0); i = i + 2)
        for (int j = 2; j < array.GetLength(1); j = j + 2)
        { 
            temp = array[i,j];
            array[i, j] = temp*temp;
        }
    
    return array;
}

int[,] newArray = CreatArray();
ShowArray2d(newArray);
newArray = QuadroArray(newArray);
ShowArray2d(newArray);

*/


// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
// %%% Задача 3: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д. %%%
// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

int[,] CreatArray()
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

    for (int i = 0; i < newArray.GetLength(0); i++)
        for (int j = 0; j < newArray.GetLength(1); j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void SumElements(int[,] array)
{
    int temp = array[0,0];
    for(int i = 1, j = 1; i< array.GetLength(0) & j< array.GetLength(1); i++, j++)
        temp = temp + array[i,j];
    Console.WriteLine($"Summ elements = {temp}");
}

void ShowArray2d(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
            
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] newArray = CreatArray();
ShowArray2d(newArray);
SumElements(newArray);

