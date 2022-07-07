/* Задача 54: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива. */

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

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < (mass.GetLength(1)); j++)
    {
        for (int k = 0; k < mass.GetLength(1) - 1; k++)
        {
            if(mass[i, k] > mass[i, k + 1])
            {
                int temp = mass[i, k];
                mass[i, k] = mass[i, k + 1];
                mass[i, k + 1] = temp;
            }
        }
    }
}

PrintArray(mass); */

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
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        sumLines[i] = sumLines[i] + mass[i, j];
    }
    Console.Write(sumLines[i] + "   ");
}
int pointerSumLine = 0;
int n = 0;
while (n < sumLines.Length)
{
    if (sumLines[pointerSumLine] > sumLines[n])
    {
        pointerSumLine = n;
    }
    n++;
}
Console.WriteLine();
Console.WriteLine("Минимальная сумма элементов у строки номер "
                 + (pointerSumLine + 1)); */

/////////////////////////////////////////////////////////////////

/* Задача 58: Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц. */

/* void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "     ");
        }
        Console.WriteLine();
    }
}

int[,] mass1 = new int[4, 5];
int[,] mass2 = new int[5, 6];
if (mass1.GetLength(1) != mass2.GetLength(0))
{
    Console.WriteLine("Умножение невозможно");
}
else
{
    for (int i = 0; i < mass1.GetLength(0); i++)
    {
        for (int j = 0; j < mass1.GetLength(1); j++)
        {
            mass1[i, j] = new Random().Next(0, 10);
        }
    }
    for (int i = 0; i < mass2.GetLength(0); i++)
    {
        for (int j = 0; j < mass2.GetLength(1); j++)
        {
            mass2[i, j] = new Random().Next(0, 10);
        }
    }
    PrintArray(mass1);
    Console.WriteLine();
    PrintArray(mass2);
    Console.WriteLine();
    int[,] mass3 = new int[mass1.GetLength(0), mass2.GetLength(1)];

    for (int i = 0; i < mass3.GetLength(0); i++)
    {
        for (int j = 0; j < mass3.GetLength(1); j++)
        {
            for (int k = 0; k < mass1.GetLength(1); k++)
            {
                 mass3[i, j] += mass1[i,k] * mass2[k,j];
            }
           
        }
    }
    PrintArray(mass3);
} */

/* Задача 60: Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая будет построчно выводить
массив, добавляя индексы каждого элемента. */

/* void PrintArray3(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write(arr[i, j, k] + " (" + i + "," + j + "," + k + ")    ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] arr3 = new int[2, 3, 5];

for (int i = 0; i < arr3.GetLength(0); i++)
{
    for (int j = 0; j < arr3.GetLength(1); j++)
    {
        for (int k = 0; k < arr3.GetLength(2); k++)
        {
            arr3[i, j, k] = new Random().Next(10, 100);
        }
    }
}
PrintArray3(arr3);

for (int i = 0; i < arr3.GetLength(0) - 1; i++)
{
    for (int j = 0; j < arr3.GetLength(1) - 1; j++)
    {
        for (int k = 0; k < arr3.GetLength(2) - 1; k++)
        {
            for (int l = 0; l < arr3.GetLength(2) - 1; l++)
            {
                int count = 0;
                if (arr3[i, j, l] == arr3[i, j, l + 1])
                {
                    arr3[i, j, l] = new Random().Next(10, 100);
                    count++;
                }
            }
        }
    }
}
PrintArray3(arr3); */

/////////////////////////////////////////////////////////////////

/* Задача 62: Заполните спирально массив 4 на 4. */

/* void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "     ");
        }
        Console.WriteLine();
    }
}

int[,] mass = new int[4, 4];
int i = 0;
int j = 0;
int a = 1;
int p = 4;
while (p > 0)
{
    int k = 0;
    do
    {
        mass[i, j++] = a++;
    } while (++k < p - 1);
    for (k = 0; k < p - 1; k++)
    {
        mass[i++, j] = a++;
    }
    for (k = 0; k < p - 1; k++)
    {
        mass[i, j--] = a++;
    }
    for (k = 0; k < p - 1; k++)
    {
        mass[i--, j] = a++;
    }
    i++;
    j++;
    p = p < 2 ? 0 : p - 2;
}

PrintArray(mass);
Console.WriteLine(); */
