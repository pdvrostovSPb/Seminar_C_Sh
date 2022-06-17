/* Задача 25: Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B. */

/* Console.WriteLine("Введите число A");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B");
int B = int.Parse(Console.ReadLine());

int count = 2;
int result = A;
while (count <= B)
{
    result = result * A;
    count++;
}

Console.WriteLine(A + " to degree " + B + " = " + result); */

// Вариант решения Задачи 25 через написание и объявление функции с циклом внутри

/* int Degree(int num1, int num2)
{
    int count = 2;
    int result = num1;
    while (count <= num2)
    {
        result = result * num1;
        count++;
    }
    return result;
}

Console.WriteLine("Введите число A");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B");
int B = int.Parse(Console.ReadLine());

Console.WriteLine(Degree(A, B)); */

//////////////////////////////////////////////////////////

/* Задача 27: Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе.*/

//Решение через написание и объявление функции

/* int SumOfDigits(int num)
{
    int sum = 0;
    if (num < 10 && num > -10)
    {
        sum = num;
    }
    else
    {
        while (Math.Abs(num / 10) > 0)
        {
            sum = sum + num % 10;

            if (num < 100 && num > -100)
            {
                sum = sum + num / 10;
            }
            num = num / 10;
        }

    }
    return Math.Abs(sum);
}
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());

Console.WriteLine("Sum of digites = " + SumOfDigits(N)); */

//////////////////////////////////////////////////////////

/* Задача 29: Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int[] arr = new int[5];

Console.Write(" [");
int i = 0;
for (; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0, 100);

    if (i == arr.Length - 1)
    {
        Console.Write(" " + arr[i]);
    }
    else
    {
        Console.Write(" " + arr[i] + ",");
    }
}
Console.Write(" ] ");

