//--------------------------------------------------------------------------------------------------------------------------
//---Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.---
//--------------------------------------------------------------------------------------------------------------------------

// Вариант 1 - только числа
/*

bool CheckPalindrome1 (int num)
{
    string number = num.ToString(); //переводим число в строку

    int [] arr = new int [number.Length];
    for(int a = 0; a < number.Length; a++) arr[a] = Convert.ToInt32(number.Substring(a, 1)); //записываем число в массив
    
    //Console.WriteLine(string.Join(", ", arr)); //проверка записи цифр в массив

    int [] revers = new int [arr.Length]; 
    for(int i = 0, j = arr.Length-1; i < arr.Length; i++, j--) revers[j] = arr[i]; //записываем перевернутый массив
    
    //Console.WriteLine(string.Join(", ", revers)); //проверка записи цифр в перевернутый массив
    

    bool result = true;
    for(int i = 0, j = 0; i < arr.Length; i++, j++) //сравниваем массивы
    {
        if (revers[i] == arr[i]) result = true;
        else
        {
            result = false;
            break;
        }
    }

    //Console.WriteLine(result); // проверяем результат
    return result;  
}

Console.Write("Enter a number is palindrome: ");
int text = Convert.ToInt32(Console.ReadLine());

bool result = CheckPalindrome1(text);

if (result == true) Console.Write ($"The number {text} is palindrome.");
else Console.Write ($"The number {text} is not palindrome.");

*/

//Вариант 2 - любые символы
/*
string CheckPalindrome (string num)
{
    string number = num.ToString(); //переводим число в строку

    string [] arr = new string [number.Length];
    for(int a = 0; a < number.Length; a++) arr[a] = Convert.ToString(number.Substring(a, 1)); //записываем число в массив
    
    //Console.WriteLine(string.Join(", ", arr)); //проверка записи цифр в массив

    string [] revers = new string [arr.Length]; 
    for(int i = 0, j = arr.Length-1; i < arr.Length; i++, j--) revers[j] = arr[i]; //записываем перевернутый массив
    
    //Console.WriteLine(string.Join(", ", revers)); //проверка записи цифр в перевернутый массив
    

    string result = "yes";
    for(int i = 0, j = 0; i < arr.Length; i++, j++) //сравниваем массивы
    {
        if (revers[i] == arr[i]) result = "yes";
        else
        {
            result = "no";
            break;
        }
    }

    //Console.WriteLine(result); // проверяем результат
    return result;  
}


Console.Write("Enter a number, letter combination, word, or text that reads equally in both directions: ");
string text = Console.ReadLine();

string result = CheckPalindrome(text);

if (result == "yes") Console.Write ($"The number {text} is palindrome.");
else Console.Write ($"The number {text} is not palindrome.");
*/

//---------------------------------------------------------------------------------------------------------------------------------------
//---Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.---
//---------------------------------------------------------------------------------------------------------------------------------------

/*
double Distance(int xA, int yA, int zA, int xB, int yB, int zB)
{
    int temp = (xB - xA)*(xB - xA) + (yB - yA)*(yB - yA) + (zB - zA)*(zB - zA);
    double result = Math.Sqrt(temp); 
    return result;
}

Console.Write("Enter the coordinates xA points A: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the coordinates yA points A: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the coordinates zA points A: ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the coordinates xB points B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the coordinates yB points B: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the coordinates zA points A: ");
int zB = Convert.ToInt32(Console.ReadLine());


double result = Distance(xA, yA, zA, xB, yB, zB);
Console.WriteLine(result);

*/

//-----------------------------------------------------------------------------------------------------------------
//---Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N..---
//-----------------------------------------------------------------------------------------------------------------

void CubeNumbers(int number)
{
    int i = 1;
    int result = i * i * i;
    if (number > 0)
    {
        while(i-1 < number)
        {
            result = i * i * i;
            i++;
            Console.Write($"{result}, "); 
        }
        
    }
    else Console.WriteLine($"Entered number {number} <1");
}

Console.Write("Enter the integer number >= 1: ");
int number = Convert.ToInt32(Console.ReadLine());

CubeNumbers (number);

