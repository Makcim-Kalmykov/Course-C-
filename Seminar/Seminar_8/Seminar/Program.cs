

// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
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


int[,] ChangeRows(int[,] array, int rows1, int rows2)
{
    if (rows1 >= 0 && rows1 < array.GetLength(0) && rows2 >= 0 && rows2 < array.GetLength(0) && rows1 != rows2)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[rows1, j];
            array[rows1, j] = array[rows2, j];
            array[rows2, j] = temp;
        }
    return array;
}


int[,] myArray = CreatRandom2dArray();
ShowArray2d(myArray);

ShowArray2d(ChangeRows(myArray, 2, 5));
*/

// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
// %%% Задача 1: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, %%%
// %%%            программа должна вывести сообщение для пользователя. //квадратная матрица должна быть, разворот по диагонали;   %%%
// %%%            в цикле пройти по одной половине(справа сверху индекс 1, 2 меняется на 2, 1)                                    %%%
// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

/*

int[,] CreateArray()
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

int[,] FlippingArray(int[,] array) // разворот массива (меняем строки и столбцы местами) 
{
    int[,] flipArray = new int[array.GetLength(1), array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            flipArray[j, i] = array[i, j];

    return flipArray;
}

void TranspSquaer(double[,] arraysub) //реверс квадратного массива по главной оси 
{
    double temp;
    for (int i = 0; i < arraysub.GetLength(0); i++)
        for (int j = i + 1; j < arraysub.GetLength(1); j++)
        {
            temp = arraysub[i, j];
            arraysub[i, j] = arraysub[j, i];
            arraysub[j,i] = temp;
        }
}

int[,] myArray = CreateArray();
ShowArray(myArray);
int[,] flipingArray = FlippingArray(myArray);
ShowArray(flipingArray);

*/

// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
// %%% Задача 2:  Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент. %%%
// %%%            найти индекс наимен элемент. упрщ - удалить знасение "0" занулить строку и столбец. 2 вариант - новый массив на 1 %%%
// %%%            сроку и 1 столбец меньше, игнор. миним считаем первый попавшийся минимальный                                      %%%
// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

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

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] DeleteArrayRowsColums(int[,] array)
{
    Console.Write("Input rows elements: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input colums elements: ");
    int colum = Convert.ToInt32(Console.ReadLine());

    int[,] arrayDelete = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    for (int i = 0, k = 0; i < array.GetLength(0); i++)
    {
        if (i != row)
        {
            for (int j = 0, m = 0; j < array.GetLength(1); j++)
                if (j != colum)
                {
                    arrayDelete[k, m] = array[i, j];
                    m++;
                }
            k++;
        }


    }
    return arrayDelete;
}

int[,] arrayTask2 = CreatArray();
ShowArray(arrayTask2);
int[,] deletArray = DeleteArrayRowsColums(arrayTask2);
ShowArray(deletArray);
