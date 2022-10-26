// Методы
// Вид 1 - которые ничего не принимают и не возвращают. Перед ними ставится void 

// void Method1() // точка с запятой не ставится, как в цикле
// {
//     Console.WriteLine("Автор Дима");
// }

// Method1(); // ОБЯЗАТЕЛЬНО нужно ставить после скобки!! 



// Вид 2 - которые не возвращают, но могут принимать какие-то аргументы. Перед ними ставится void 

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }

// Method2(msg: "Text"); // Или можно записать: Method2("Text");
// // Console.WriteLine("Hello, World!");

// void Method21(string msg, int count)
// {
//     int i=0;
//     while (i<count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }    
// }
// Method21(count: 4, msg: "NEW TWXT"); // или 
// Method21("NEW TWXT", 4); // но в данном случае порядок ввода должен сохраниться

// Вид 3 - которые что-то возвращают, но ничего не принимают.

// int Method3() // обязательно указываем тип данных, которые возвращаются.
// {
//     return DateTime.Now.Year;  // вот в таких методах обязательно должен быть return   
// }

// int year = Method3();
// Console.WriteLine(year);

// Вид 4 - которые что-то принимают и что-то возвращают

// string Method4(int count, string text)
// {

//     string result = ""; // или string result = String.Empty;

//     // while (i<count)
//     // {
//     //     result = result + text;
//     //     i++;
//     // }
//     // return result;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;

// }

// string res = Method4(10, "X");
// Console.WriteLine(res);

for (int i = 2; i <=10; i++)
{
    for (int j = 2; j <= 10 ; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}