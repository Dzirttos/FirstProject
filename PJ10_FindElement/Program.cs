﻿// Поиск элемента в массиве
Console.Clear();

int[] array = { 1, 2, 3, 4, 7, 5, 6, 7, 8, 9 };

int n = array.Length;
int find = 7;

int index = 0;
while (index < n)
{
    if(array[index] == find) 
    {
        Console.WriteLine(index); 
        break;    
    }
    index++;
}