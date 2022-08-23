void FillArray(int[] collection)
{
    int length = collection.Length;  //получаем длинну массива
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;

    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOff(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
        while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;   //после того как нашли первое совпадение прерываем цикл
        }
        index++;

    }
    return position;
}

int[] array = new int[10]; //создай новый массив, в котором будет 10 элементов


FillArray(array); // вызвали метод FillArray, который заполнил массив
PrintArray(array); // вызвали метод PrintArray, который вывел в консоль массив
Console.WriteLine();

int pos = IndexOff(array, 5); //в качестве аргуента массив, ищем 4
Console.WriteLine(pos);