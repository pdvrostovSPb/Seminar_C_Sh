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
    arr[i] = new Random().Next();
    Console.Write(arr[i] + "  ");

    if (i % 2 != 0) sum = sum + arr[i];
}

Console.WriteLine();
Console.WriteLine("Сумма элементов на нечетных позициях = " + sum); */

///////////////////////////////////////////////////////

/* Задача 38: Задайте массив вещественных чисел. Найдите
разницу между максимальным и минимальным
элементов массива. */

/* double[] arr = new double[5];

double max = arr[1];
double min = arr[1];
double dif = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(1, 101);
    Console.Write(arr[i] + "  ");

    if (arr[i] > max)  max = arr[i];
    if (arr[i] < min) min = arr[i];
}

dif = max - min;

Console.WriteLine();
Console.WriteLine("Разность между максимальным и минимальным элементами = " + dif); */

void print(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}
Console.WriteLine();
 
double[] arr = new double[10];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0, 10) + new Random().NextDouble();
    arr[i] = Math.Round(arr[i], 2);
}
 
print(arr);
 
double max = arr[0];
double min = arr[0];
double dif = 0;

 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
 
    if (arr[i] < min)
    {
        min = arr[i];
    }
}
 
dif = max - min;
dif = Math.Round(dif, 2); 
Console.WriteLine();
Console.WriteLine("Максимальное число в массиве: " + max);
Console.WriteLine("Минимальное число в массиве: " + min);
Console.WriteLine("Разница между максимальным и минимальным числом: " + dif);