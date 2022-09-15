// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
// %%% Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.) %%%
// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

/*
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


int[] ReversArray(int[] array)  //переворот массива
{
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    return array;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value:: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);

ShowArray(ReversArray(newArray));

*/


// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
// %%% Задача 1: Напишите программу, которая будет преобразовывать десятичное число в двоичное. %%%
// %%%           (число поэтапно делить на 2 и записать в обр порядке остатки от деления.       %%%
// %%%           Итог как int[] или через !string. ) %%%                                        %%%
// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

/*
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine("\b]");
}

int[] NumberBinarySystem(int number) //переводим число в двоиную систему и записываем результат в массив
{
    string binary = String.Empty;
    int temp = number;

    for (int i = number; i > 0; i /= 2)
    {
        temp = i % 2;
        binary += temp;
    }

    int[] array = new int[binary.Length];
    for (int i = 0; i < array.Length; i++) //записываем каждую цифру в массив
        array[i] = Convert.ToInt32(binary.Substring(i, 1));

    int[] reversArray = new int[array.Length];
    for (int i = 0, j = array.Length-1; i < array.Length; i++, j--)
        reversArray[j] = array[i];

    return reversArray;
}

Console.Write("Enter a number in decimal: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] newArray = NumberBinarySystem(number);
Console.Write($"Number {number} in binary system:");
PrintArray(newArray);
*/

// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
// %%% Задача 2: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b. %%%
// %%%           (сгенерировать ряд и вывести его. Фибоначи - 1123581321 F(i) = F(i - 1) + F(i - 2);          %%%
// %%%           элемент а, б, кол-во элементов; вывод через массив                                           %%%
// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

/*

int[] Fibonaci(int size, int numA, int numB) // Ряд фибоначи через цикл
{
    int[] FibonaciArr = new int[size];
    FibonaciArr[0] = numA;
    FibonaciArr[1] = numB;
    for (int i = 0, j = i + 2; i < size - 2; i++, j++)
        FibonaciArr[j] = FibonaciArr[j - 1] + FibonaciArr[j - 2];

    return FibonaciArr;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine("\b]");
}


Console.Write("Input size of the Fibonacci sequence: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int[] FibonaciArr = Fibonaci(size, numberA, numberB);

Console.WriteLine($"Fibonacci series with initial values A({numberA}) and B({numberB}):");
PrintArray(FibonaciArr);

*/


// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
// %%% Задача 3. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник сo сторонами %%%
// %%%           такой длины. Каждая сторна треуг должна быть строго меньше суммы двух других сторон. Результат bool                 %%%
// %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

bool CheckingTriangle(int numA, int numB, int numC) //проверка существования треугольника
{
    if (numA + numB > numC)
        if (numA + numC > numB)
            if (numB + numC > numA) return true;
            else return false;
        return false;
}

Console.Write("Input lenght sides 'A' of the traingel: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input lenght sides 'B' of the traingel: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Input lenght sides 'C' of the traingel: ");
int numberC = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Trainel of sides {numberA};{numberB};{numberC} is {CheckingTriangle(numberA, numberB, numberC)}");

