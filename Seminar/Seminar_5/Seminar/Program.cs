//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
//%%% 1. Необходимо задать массив из 12 элементов заполненных случайными числами из промежутка -9 до 9 %%%
//%%% 2. Найти сумму отрицателеьных элементов  массива                                                 %%%
//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%


int[] CreateRandomArray(int size, int minValue, int maxValue) //Создание массива и заполнение его случайными числами
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++) newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

void ShowArray(int[] array) //Показ массива
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");
    Console.WriteLine("\b]");
}

int FindNegativeSum(int[] array) //Сумма негативных чисел массива
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] < 0) sum += array[i];

    return sum;
}

int[] ReplacingArray(int[] array) //меняем положительные на отрицательные и наоборот
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < newArray.Length; i++) newArray[i] = array[i] * -1;
    return newArray;
}

bool FindNumberOffArray(int[] array, int currentNumber) //определяет присутствует ли заданное число в массиве
{
    for (int i = 0; i < array.Length; i++) if (array[i] == currentNumber) return true;
    return false;
}

int FindNumbersArray(int[] array, int minValue, int maxValue) //кол-во элемнтов массива, которые лежат в отрезке от minValue до maxValue
{
    int current = 0;
    for (int i = 0; i < array.Length; i++) if (array[i] > minValue & array[i] < maxValue) current++;
    return current;
}

int[] MultiplicationParsArray(int[] array)  //находим произведение пар числе в одномерн массиве
{
    int current = 0;
    if (array.Length % 2 == 0) current = array.Length / 2;
    else current = array.Length / 2 + 1;

    int[] newArray = new int[current];

    if (array.Length % 2 == 0)
    {
        for (int i = 0, j = array.Length - 1; i < array.Length / 2; i++, j--)
            newArray[i] = array[i] * array[j];
    }

    else
    {
        int n = array.Length  / 2;
        for (int i = 0, j = array.Length - 1; i <= array.Length / 2; i++, j--)
            newArray[i] = array[i] * array[j];
        newArray[n] = array[n];
    }

    return newArray;
}

/*
Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value:: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);

Console.Write($"Sum of negative elemints is {FindNegativeSum(newArray)}");
*/



// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
// %%% Задача 1. Программа для замены элементов массива. Положительные элементы заменить на отриц и наоборот. %%%
// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

/*
Console.Write("Input size of array: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value:: ");
int maximum = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(sizeArray, minimum, maximum);
ShowArray(newArray);
int[] newArrayReplacing = ReplacingArray(newArray);

Console.WriteLine("An array with replaced element signs has the form: ");
ShowArray(newArrayReplacing);
*/


// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
// %%% Задача 2. Необх задать массив и написать программу, которая определяет присутствует ли заданное число в массиве. %%%    Возвращаем логику
// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

/*
Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value:: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Input element to search in the array: ");
int current = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);
bool result = FindNumberOffArray(newArray, current);
Console.WriteLine(result);
*/


// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
// %%% Задача 3. Задать одномерный массив из 15 случайных чисел и найти кол-во элемнтов массива, которые лежат в отрезке от 10 до 99. %%%
// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

/*
Console.Write("Input size of array: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value:: ");
int maximum = Convert.ToInt32(Console.ReadLine());

int[] RandomArray(int size) //Создание массива и заполнение его случайными числами от 0 до 150
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++) newArray[i] = new Random().Next(0, 150);
    return newArray;
}

int[] newArray = RandomArray(sizeArray);
ShowArray(newArray);

Console.WriteLine($"The number of numbers in the range from {minimum} to {maximum} equal: {FindNumbersArray(newArray, minimum, maximum)}");
*/

// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
// %%% Задача 4. Необходимо найти произведение пар числе в одномерн массиве. Пары считаем первый и последний, предпоследн и второй и т.д. %%%
// %%%           Результат записать в новый массив.                                                                                       %%%
// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value:: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);

int[] multiplicationArray = MultiplicationParsArray(newArray);
ShowArray(multiplicationArray);

