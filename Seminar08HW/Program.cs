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
PrintArray3(arr3); */

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
 */
void PrintInt3(int[,,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            for (int k = 0; k < array.GetLength(2); k++) 
            { 
                Console.WriteLine($"array[{i}, {j}, {k}] = {array[i, j, k]}"); 
            } 
        } 
    } 
}
 
int[,,] array5 = new int[2, 2, 6]; 
int count = 0; 
while (count <= array5.Length) // пока не заполним весь массив 
{ 
    for (int i = 0; i < array5.GetLength(0); i++)  
    { 
        for (int j = 0; j < array5.GetLength(1); j++) 
        { 
            for (int k = 0; k < array5.GetLength(2); k++) 
            { 
                int rand = new Random().Next(10, 100); 
                bool flag = false; // флаг найденного повторяющегося числа 
                // далее проверка уже заполненных ячеек на идентичность с rand 
                for (int i_new = 0; i_new <= i; i_new++)  
                { 
                    for (int j_new = 0; j_new <= j; j_new++) 
                    { 
                        for (int k_new = 0; k_new <= k; k_new++) 
                        { 
                            if (array5[i_new, j_new, k_new] == rand) // если нашли уже такое число 
                            { 
                                flag = true; // выставляем флаг и выходим из цикла проверки заполненнного массива 
                                break; // выход из цикла for (int k_new = 0; k_new <= k; k_new++) 
                            } 
                        } 
                        if (flag == true)  
                        { 
                            break; // выход из цикла for (int j_new = 0; j_new <= j; j_new++) 
                        } 
                    } 
                    if (flag == true) 
                    { 
                        break; // выход из цикла for (int i_new = 0; i_new <= i; i_new++)  
                    } 
                } 
                if (flag == false) // если rand неповторяющееся число 
                { 
                    array5[i, j, k] = rand; 
                    count++; 
                } 
                else  
                { 
                    k--; // иначе уменьшаем индекс, чтоб новое число записать в эту же ячейку 
                } 
            } 
        } 
    } 
} 
PrintInt3(array5);


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
           
        }
    }
}

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
int i = 0, j = 0;
int a = 1;
int p = 4;
while (p > 0)
{
    int k = 0;
    do { mass[i, j++] = a++; }
    while (++k < p - 1);
    for (k = 0; k < p - 1; k++) mass[i++, j] = a++;
    for (k = 0; k < p - 1; k++) mass[i, j--] = a++;
    for (k = 0; k < p - 1; k++) mass[i--, j] = a++;

    ++i; ++j; p = p < 2 ? 0 : p - 2;
}

PrintArray(mass);
Console.WriteLine(); */


