/* Задача 34: Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве.
[345, 897, 568, 234] -> 2 */

/* int[] arr = new int[10];
int chch = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(100, 1000);
    Console.Write(arr[i] + "  ");

    if (arr[i] % 2 == 0)
    {
        chch = chch + 1;
    }
}

Console.WriteLine();
Console.WriteLine("Четных чисел в массиве  " + chch); */

//////////////////////////////////////////////////////

/* Задача 36: Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов, стоящих
на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

/* double[] arr = new double[10];
double sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0, 31) + new Random().NextDouble();
    arr[i] = Math.Round(arr[i], 2);
    Console.Write(arr[i] + "  ");

    if (i % 2 != 0) sum = sum + arr[i];
}
Console.WriteLine();
Console.WriteLine("Сумма элементов на нечетных позициях = " + Math.Round(sum, 2)); */

///////////////////////////////////////////////////////

/* Задача 38: Задайте массив вещественных чисел. Найдите
разницу между максимальным и минимальным
элементов массива. */

/* void PrintArr(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "  ");
    }
    Console.WriteLine();
}

double[] coll = new double[8];
for (int i = 0; i < coll.Length; i++)
{
    coll[i] = new Random().Next(0, 100) + new Random().NextDouble();
    coll[i] = Math.Round(coll[i], 2);
}
PrintArr(coll);

double max = coll[0];
double min = coll[0];
for (int i = 0; i < coll.Length; i++)
{
    if (coll[i] > max) max = coll[i];
    if (coll[i] < min) min = coll[i];
}
Console.WriteLine("max = " + max);
Console.WriteLine("min = " + min);
Console.WriteLine("Разность между max и min = " + Math.Round((max - min), 2)); */
