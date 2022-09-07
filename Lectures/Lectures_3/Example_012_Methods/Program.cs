/*
void Method1()
{
    Console.WriteLine("Автор...");
}

Method1;
*/

/*
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");
*/

/*
void Method21(string msg, int count)
{
    int i = 0;
    while(i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

Method21("Текст", 4); //получить вывод "текст" 4 раза
//Method21(msg: "Текст", count: 4); //тоже самое что выше
*/






/*

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);
*/



/*
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;//будет пустая строка

    while(i < count)
    {
        result += text;
        i++;
    }

    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);
*/



/*
string Method4(int count, string text)
{
    string result = String.Empty;//будет пустая строка

    for(int i = 0; i < count; i++)
    {
        result += text;
    }

    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);
*/


//цикл в цикле:
/*
for(int i = 2; i <= 10; i++)
{
    for(int j = 2; j<=10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}"); //интерполяция
    }
    Console.WriteLine();
}
*/




//Задача по замене букв и символов

string text = "- Я думаю, сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие просского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

//string s = "qwerty"
//            012345
// s[3] // r

/*
String Replace(string text, char old, char newVal) //метод замены старого на новое
{
    string result = String.Empty; // инциализация пустой строки
    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if(text[i] == old) result += $"{newVal}";
        else result += $"{text[i]}";
    }


    return result;
}


string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
*/


//Сортируем массив
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array) //метод вывода массива в консоль
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();

}    


void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)   //сортировка
    {
        int min = i;

        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[min]) min = j;
        }

        int temp = array[i];   //замена минимальной с тем что нашли
        array[i] = array[min];
        array[min] = temp;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);