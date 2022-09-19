int[,] CreatArray() //двумерный массив рандом с аргументами через пользователя
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

void ShowArray(int[,] array) // показ двумерного интового массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] SortAaary(int[,] array) //пузырьковая сортирвка 
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = j + 1, temp; k < array.GetLength(1); k++)
                if (array[i, j] < array[i, k])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
    return array;
}

void MaxSumRows(int[,] array) //поиск с наименьшей суммой
{
    int sumMin = 0;
    int rows = 0;


    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            sumMin += array[i, j];

        rows = i;
    }

    for (int i = 1, sum1 = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            sum1 += array[i, j];

        if (sumMin > sum1)
        {
            sumMin = sum1;
            rows = i;
        }

        sum1 = 0;
    }
    Console.WriteLine($"Min summ = {sumMin} (rows {rows})");
}

void MatrixMultiplication(int[,] array1, int[,] array2, int[,] multiplicationArray) // умножение матриц через рекурсию
{
    int i = 0, j = 0, k = 0;

    if (i >= array1.GetLength(0))
        return;

    if (j < array2.GetLength(1))
    {
        if (k < array1.GetLength(1))
        {
            multiplicationArray[i, j] += array1[i, k] * array2[k, j];
            k++;

            MatrixMultiplication(array1, array2, multiplicationArray);
        }

        k = 0;
        j++;

        MatrixMultiplication(array1, array2, multiplicationArray);
    }

    j = 0;
    i++;
    MatrixMultiplication(array1, array2, multiplicationArray);
}


int[,] MultiplicationMatrix(int[,] array1, int[,] array2) // умножение матриц через цикл
{

    int aRows = array1.GetLength(0); int aCols = array1.GetLength(1);
    int bRows = array2.GetLength(0); int bCols = array2.GetLength(1);

    if (aCols != bRows)
        throw new Exception("Can't do multiplication. The size of the matrices does not match");

    int[,] result = new int[aRows, bCols];

    for (int i = 0; i < aRows; ++i) // каждая строка A
        for (int j = 0; j < bCols; ++j) // каждый столбец B
            for (int k = 0; k < aCols; ++k)
                result[i, j] += array1[i, k] * array2[k, j];

    return result;

}


int[,,] CreatArray3d() //трехмерный массив рандом с аргументами через пользователя. Числа без повторений
{

    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of layers: ");
    int layers = Convert.ToInt32(Console.ReadLine());

    int[] tempArray = new int[layers * rows * colums];
    tempArray[0] = new Random().Next(minValue, maxValue + 1);

    for (int i = 1, temp; i < tempArray.Length; i++)
    {
    again:
        temp = new Random().Next(minValue, maxValue + 1);
        for (int j = 0; j < i; j++)
        {
            if (temp == tempArray[j])
                goto again;
        }
        tempArray[i] = temp;
    }

    int[,,] newArray = new int[layers, rows, colums];
    int count = 0;
    for (int z = 0; z < newArray.GetLength(0); z++)
        for (int y = 0; y < newArray.GetLength(1); y++)
            for (int x = 0; x < newArray.GetLength(2); x++)
            {
                newArray[z, y, x] = tempArray[count];
                count++;
            }
    return newArray;
}

void ShowArray3d(int[,,] array) // показ трехмерного интового массива
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = 0; n < array.GetLength(2); n++)
                //Console.Write($"{array[i, j, n]}{(i, j, n)} ");
                Console.Write($"{array[i, j, n]} ");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}


int[,] ArraySnake()
{
    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, colums];

    int i = 0; int j = 0;
    int temp = 0; int count = 0;
    int tempRows = rows; int tempColums = colums;

    while (tempRows > rows / 2 & tempColums > colums / 2)
    {
        for (; j < tempColums; j++)
        {
            newArray[i, j] = count;
            count++;
        }

        j--;
        i++;

        for (; i < tempRows; i++)
        {
            newArray[i, j] = count;
            count++;
        }

        i--;
        j--;

        for (; j >= 0 + temp; j--)
        {
            newArray[i, j] = count;
            count++;
        }

        j++;
        i--;

        for (; i > 0 + temp; i--)
        {
            newArray[i, j] = count;
            count++;
        }

        i++; j++; temp++;
        tempRows--; tempColums--;
    }
    return newArray;
}

void ShowArrayNew(int[,] array) // показ двумерного интового массива РОВНО
{
    string format = " ";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1);)
        {
            format = " ";
            if (j != 0)
                format = array[i, j] >= 0 ? "\t " : "\t";
            Console.Write(format + array[i, j]);
            j++;
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
// %%% Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой %%%
// %%%            строки двумерного массива сортировка пузырьковая, каждую строку отдельно                     %%%
// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
/*

int[,] arrayTask54 = CreatArray();
ShowArray(arrayTask54);
ShowArray(SortAaary(arrayTask54));

*/


// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
// %%% Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. %%%
// %%%            вывести номер строки (!!!не индекс!!!) + сумму + массив                                                                  %%%
// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
/*

int[,] arrayTask56 = CreatArray();
ShowArray(arrayTask56);
MaxSumRows(arrayTask56);

*/


// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
// %%% Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. %%%
// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

//%%%% Вариант 1: через рекурсию %%%
/*
int[,] matrix1 = CreatArray();
ShowArray(matrix1);
int[,] matrix2 = CreatArray();
ShowArray(matrix2);
int[,] multiplicArray = new int[matrix1.GetLength(1), matrix2.GetLength(0)];

MatrixMultiplication(matrix1, matrix2, multiplicArray);

*/

//%%%% Вариант 2: через цикл %%%
/*

int[,] matrix1 = CreatArray();
ShowArray(matrix1);
int[,] matrix2 = CreatArray();
ShowArray(matrix2);

int[,] multiplay = MultiplicationMatrix(matrix1, matrix2);
ShowArray(multiplay);

*/



// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
// %%% Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно %%%
// %%%              выводить массив, добавляя индексы каждого элемента. Массив размером 2 x 2 x 2                                %%%
// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

/*
int[,,] arrayTask60 = CreatArray3d();
ShowArray3d(arrayTask60);
*/

// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
// %%% Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4 к центру (произdольный размер массива) %%%
// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

int[,] arrayTask62 = ArraySnake();
ShowArrayNew(arrayTask62);

