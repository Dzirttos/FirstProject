// Задача с масимумумом из 9 чисел
Console.Clear();

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//               0   1   2   3   4    5   6   7   8
int[] array = { 12, 32, 35, 24, 555, 36, 4227, 80, 39 };
// array[0] = 13; // array[] - обращение к элементу массива с индексом, укаазнным в квадратных скобках
//Console.Write(array[0]);

 int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));
Console.WriteLine(max);


