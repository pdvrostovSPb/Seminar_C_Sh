/* Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */

/*  void PrintArr (int[] coll)
{
    for (int i = 0; i < coll.Length; i++)
    {
        if(i < coll.Length - 1)
        {
            Console.Write(coll[i] + ", ");
        }
        else
        {
            Console.Write(coll[i]);
        }
    }
    Console.WriteLine(); 
}

Console.WriteLine("Сколько вы хотите ввести чисел для проверки?");
int M = int.Parse(Console.ReadLine());
int[] coll = new int[M];
int curPos = 0;
for (int i = 0; i < coll.Length; i++)
{
    if (i == 0)
    {
        Console.WriteLine("Введите первое число");
        coll[i] = int.Parse(Console.ReadLine());
    }
    else if (i == coll.Length - 1)
    {
        Console.WriteLine("Введите последнее число");
        coll[i] = int.Parse(Console.ReadLine());
    }
    else
    {
        Console.WriteLine("Введите ещё одно число");
        coll[i] = int.Parse(Console.ReadLine());
    }
        if (coll[i] > 0)
    {
        curPos += 1;
    }
}
PrintArr(coll);
Console.WriteLine("Вы ввели " + curPos + " положительных чисел"); */

////////////////////////////////////////////////////////

// Вариант решения через Split

/* string str = Console.ReadLine();

string[] nums = str.Split(' ');

for (int i = 0; i < nums.Length; i++)
{
    //Console.Write(nums[i] + ", ");   
    int num = int.Parse(nums[i]);
    Console.Write((num * num) + ", ");
}
 */

/* Задача 43. Напишите программу, которая найдёт точку
пересечения двух прямых, заданных уравнениями y = k1 *
x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 =
9 -> (-0,5; 5,5) */
Console.WriteLine("Введите число b1 ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число k1 ");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число b2 ");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число k2 ");
double k2 = double.Parse(Console.ReadLine());
if (k1 == k2)
{
    Console.WriteLine("прямые не пересекаются");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine(x + " , " + y);
}


////////////////////////////////////////////////////////

/* Напишите программу, которая перевернёт
одномерный массив (последний элемент будет на первом
месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6] */

/* void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int[] mass = new int[6];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(0, 10);
}
Print(mass);

int save;
for (int i = 0; i < mass.Length / 2; i++)
{
     save = mass[i];
        mass[i] = mass[mass.Length - 1 - i];
        mass[mass.Length - 1 - i] = save; 
    (mass[i], mass[mass.Length - 1 - i]) = (mass[mass.Length - 1 - i], mass[i]);
}

Print(mass); */

//////////////////////////////////////////////////////////////////

/* Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [-9, 9]. Найдите сумму
отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
положительных чисел равна 29, сумма отрицательных равна
-20. */

/* void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int[] mass = new int[12];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(-9, 10);
}
Print(mass);

int sumNeg = 0, sumPos = 0;

for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] > 0)
    {
        sumPos += mass[i];
    }
    else
    {
        sumNeg += mass[i];
    }
}
Console.WriteLine(sumPos);
Console.WriteLine(sumNeg); */

// Найти в заданном двумерном массиве квадрат кадого элемента с четным индексом строки и столбца

/* void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t"); // \t - табуляция, двойной отступ
        }
        Console.WriteLine();
    }

}
int m = 3, n = 4;
int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++) // перебирает каждый элемент массива в строке
{
    for (int j = 0; j < mass.GetLength(1); j++) // перебирает каждый элемент  столбца
    {
        mass[i, j] = new Random().Next(0, 10);
    }
}
Print(mass);
Console.WriteLine();

for (int i = 0; i < mass.GetLength(0); i = i+2) // i = i+2 перебирает каждый четный элемент массива в строке
{
    for (int j = 0; j < mass.GetLength(1); j = j+2) // j = j+2 перебирает каждый четный элемент столбца
    {
         mass[i, j] = mass[i, j] * mass[i, j];
    }
}

Print(mass); */

///////

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
int summ = 0;
int m = 3, n = 4;
int[,] mass = new int[m, n]; //создание и задание размера
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 10);
        if(i==j)
        {
            summ = summ + mass[i, j];
        }
    }
}

Print(mass);
Console.WriteLine();
Print(mass); 
Console.WriteLine("сумма по диагонали " + summ); */
