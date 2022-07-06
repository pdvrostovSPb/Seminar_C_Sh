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

int max = 0;
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < (mass.GetLength(1)); j++)
    {
        if (mass[i, j] > max)
        {
            max = mass[i, j];
        }
        
    }
}

PrintArray(mass);  */

//////////////////////////////////////////////////////////////////

/* Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов. */

void PrintArray(int[,] arr)
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
                    + (pointerSumLine + 1));

// подумать
/* n надо завязать на i
у меня такая же проблема 
int indexSum = 0;
int minSum = 9999999;

for (int i = 0; i < mass.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        sum = sum + mass[i, j];
    }
    if (sum <= minSum)
    {
        minSum = sum;
        indexSum=i+1;
    }
     
     Console.WriteLine( $"Строка: {i+1} Сумма: {sum}");
}
Console.Write("Строка с минимальной суммой: " +(indexSum)); */


//////////////////////////////////////////////////////////////////

/* Задача 58: Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц. */

/////////////////////////////////////////////////////////////////

/* Задача 60: Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая будет построчно выводить
массив, добавляя индексы каждого элемента. */

void PrintArray3(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write(arr[i, j, k] + " (" + i + ","
                                                + j + ","
                                                + k + ")    ");
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

int[] uniq = new int[arr3.Length];
int address = 0;
for (int i = 0; i < arr3.GetLength(0); i++)
{
    for (int j = 0; j < arr3.GetLength(1); j++)
    {
        for (int k = 0; k < arr3.GetLength(2); k++)
        {
            uniq[address] = arr3[i, j, k];

            for (int m = 0; m < address; m++)
            {
                if (uniq[m] == uniq[address])
                {
                    uniq[address] = arr3[i, j, k] + 1;
                }
            }
            Console.Write(uniq[address] + "   ");


            address++;
        }
    }
}
/* int Rec (int[] coll, coll[i])
{
    for (int i = 0; i < coll.Length; i++)
    {
        
    }
}
 */
/////////////////////////////////////////////////////////////////
/* Задача 62: Заполните спирально массив 4 на 4. */

/* void PrintInt2(int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            Console.Write(array[i, j] + "\t"); 
        } 
        Console.WriteLine(); 
    } 
    Console.WriteLine(); 
}
 
Console.Write("Введите количество строк массива: "); 
int n = int.Parse(Console.ReadLine()); 
Console.Write("Введите количество столбцов массива: "); 
int m = int.Parse(Console.ReadLine()); 
int[,] array6 = new int[n, m];  
int number = 1; // элемент массива 
int row = array6.GetLength(0); 
int column = array6.GetLength(1); 
int i = 0; // индекс по строкам 
int j = 0; // индекс по столбцам 
int circle = 0; // номер обхода  
int location = 0; // 0 - right, 1 - down, 2 - left, 3 - up 
while (number <= array6.Length) 
{ 
    array6[i, j] = number; 
    if (location == 0 && i == 0 + circle && j < array6.GetLength(1) - circle) // вправо 
    { 
    j++; // вправо по строке 
    if (j == (array6.GetLength(1) - circle)) // дошли до конца строки 
    { 
        location = 1; // в состояние "вниз" 
        j--; // чтоб не зайти за пределы строки 
        i++; // чтоб начать со следующего элемента 
    } 
} 
else if (location == 1 && j == array6.GetLength(1) - 1 - circle && i < array6.GetLength(0) - circle) // вниз 
{ 
    i++; // вниз по столбцу 
    if (i == (array6.GetLength(0) - circle)) // дошли до конца столбца 
    { 
        location = 2; // в состояние "влево" 
        i--; // чтоб не зайти за пределы столбца 
        j--; // чтоб начать со следующего элемента 
    } 
} 
else if (location == 2 && i == array6.GetLength(0) - 1 - circle && j >= 0 + circle) // влево 
{ 
    j--; // влево по строке 
    if (j < 0 + circle) // дошли до начала строки 
    { 
        location = 3; // в состояние "вверх" 
        j++; // чтоб не зайти за пределы строки 
        i--; // чтоб начать со следующего элемента 
    } 
} 
else if (location == 3 && j == 0 + circle && i >= 0 + circle) // вверх 
    { 
        i--; // вверх по столбцу 
        if (i < 1 + circle) // дошли до верха столбца 
        { 
            location = 0; // в состояние "вправо" 
            i++; // чтоб не зайти за пределы столбца 
            j++; // чтоб начать со следующего элемента 
            circle++; // переходим на следующий оборот спирали 
        } 
    } 
    number++; 
} 
PrintInt2(array6); */


/* void DisplayArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++) Console.Write("{0,3} ", a[i, j]);
        Console.WriteLine();
    }
}

while (true)
{
    Console.Write("Enter a non-negative number (0 - exit): ");
    int n;
    if (!Int32.TryParse(Console.ReadLine(), out n) || n <= 0) break;
    Console.WriteLine();

    int[,] a = new int[n, n];
    int i = 0, j = 0;
    int value = 1;
    while (n != 0)
    {
        int k = 0;
        do { a[i, j++] = value++; } 
            while (++k < n - 1);
                for (k = 0; k < n - 1; k++) a[i++, j] = value++;
                for (k = 0; k < n - 1; k++) a[i, j--] = value++;
                for (k = 0; k < n - 1; k++) a[i--, j] = value++;

        ++i; ++j; n = n < 2 ? 0 : n - 2;
    }

    DisplayArray(a);
    Console.WriteLine();
} */
