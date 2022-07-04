/* Задача 54: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива. */

//////////////////////////////////////////////////////////////////

/* Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов. */

/* void PrintArray(int[,] arr)
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

int[,] mass = new int[4, 5];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 10);
    }
}
PrintArray(mass);
Console.WriteLine();

int[] sumLines = new int[mass.GetLength(0)];
for (int i = 0; i < sumLines.Length; i++)
{
    for (int k = i; k < (i + 1); k++)
    {

        for (int l = 0; l < mass.GetLength(1); l++)
        {
            sumLines[i] = sumLines[i] + mass[k, l];
        }
        Console.Write(sumLines[i] + "   ");
    }
}
int minSumLine = sumLines[0];
int pointerSumLine = 0;
int n = 0;
while(n < sumLines.Length)
{
    if (minSumLine > sumLines[n])
    {
        pointerSumLine = n;
    }
    n++;
}
Console.WriteLine();
Console.WriteLine("Минимальная сумма элементов у строки номер "
                    + (pointerSumLine + 1)); */

//////////////////////////////////////////////////////////////////

/* Задача 58: Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц. */

/////////////////////////////////////////////////////////////////

/* Задача 60: Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая будет построчно выводить
массив, добавляя индексы каждого элемента. */

/////////////////////////////////////////////////////////////////
/* Задача 62: Заполните спирально массив 4 на 4. */
