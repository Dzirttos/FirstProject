// используем генератор случайных чисел и методы
Console.Clear();
void FillArray(int[] collection) // FillArray - название метода, collection - название аргумента
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); // обратиться к аргументу collection на позицию indexи положить туда новое целое число от 1 до 10
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // "-1" принятый программистами прием, когда выводится "-1" когда элемента нет

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // создать новый массив в котором будет 10 элементов

FillArray(array);
PrintArray(array);
array[4] = 4;
array[6] = 4;
Console.WriteLine();

int pos = IndexOf(array, 43);
Console.WriteLine(pos);