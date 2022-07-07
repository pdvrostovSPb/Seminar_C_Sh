/* Задача 53: Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива. */

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

int[,] mass = new int[4, 4];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 10);
    }
}
PrintArray(mass);

for (int i = 0; i < 1; i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        int[] temp = new int[mass.GetLength(1)];
        temp[j] = mass[i, j];
        mass[i, j] = mass[(mass.GetLength(0) - 1), j];
        mass[(mass.GetLength(0) - 1), j] = temp[j];
    }
}
Console.WriteLine();
PrintArray(mass); */

///////////////////////////////////////////////////////

/* Задача 55: Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя. */

////////////////////////////////////////////////////////////

/* Задача 62: Заполните спирально массив 4 на 4. */

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
////////////////////////////////////////////////////////////////////////////////
