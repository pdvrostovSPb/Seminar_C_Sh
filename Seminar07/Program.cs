/* Задайте двумерный массив размером m×n,
заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1 */

/* void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }

}
int m = 3, n = 4;
int[,] mass = new int[m, n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 10);
    }
}

Print(mass);
Console.WriteLine();
Print(mass);
 */

/* Задача 48.
Задайте двумерный массив, каждый элемент которого равен сумме собственных индексов. */

/* void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "  ");

        }
        Console.WriteLine();
    }
}
int m = 7, n = 5;
int[,] mass = new int[m, n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = i + j;
    }
}
PrintArray(mass); */

/* Задача 49: Задайте двумерный массив. Найдите элементы, у
которых оба индекса чётные, и замените эти элементы на их
квадраты. */

/* Задача 51: Задайте двумерный массив. Найдите сумму
элементов, находящихся на главной диагонали (с индексами
(0,0); (1;1) и т.д. */

//////////////////////////////////////////////////////////////



// В случайных точках консоли вывести случайные числа


/* Random r = new Random();
Console.CursorVisible = false;
while(true)
{
    Console.SetCursorPosition(
        left: r.Next(Console.WindowWidth),
        top: r.Next(Console.WindowHeight)
    );
    Console.Write(r.Next(10));
    Thread.Sleep(1000);
} */