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

////////////////////////////////////////////////////////////

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
