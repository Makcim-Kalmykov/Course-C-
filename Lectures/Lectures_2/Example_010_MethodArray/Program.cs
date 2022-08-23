int[] array = {1, 2, 3, 4, 5, 6, 4, 7, 8, 9};

int n = array.Length; //присваиваем переменной "n" значение, которое равно количеству элементов массива

int find = 4;

int index = 0;

while(index < n)
{
    if(array[index] == find)  //если индекс массива совпадает (равен) значению переменной find
    {
        Console.WriteLine(index);
        break; //прервать условие, больше не выполнять цикл
    }
    index++; //index = index + 1;
}
