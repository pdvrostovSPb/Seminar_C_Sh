/* Задача 2: Напишите программу, которая на вход
принимает два числа и выдаёт, какое число большее, а
какое меньшее. */

/* Console.WriteLine("Введите число а ");
Console.WriteLine("Введите число b ");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("max = " + a);
    Console.WriteLine("min = " + b);
}
else
{
    Console.WriteLine("max = " + b);
    Console.WriteLine("min = " + a);
}  */

//////////////////////////////////////

/* Задача 4: Напишите программу, которая принимает на
вход три числа и выдаёт максимальное из этих чисел. */

/* Console.WriteLine("Введите число а ");
Console.WriteLine("Введите число b ");
Console.WriteLine("Введите число c ");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if (a > b)
    if (a > c)
        Console.WriteLine(a);
    else
        Console.WriteLine(c);
else
    if (b > c)
        Console.WriteLine(b);
    else
        Console.WriteLine(c); */

/////////////////////////////////////

/* Задача 6: Напишите программу, которая на вход
принимает число и выдаёт, является ли число чётным  */

/* Console.WriteLine("Введите число");

int n = int.Parse(Console.ReadLine());

if(n % 2 == 0)
  Console.WriteLine("Число четное");
else
  Console.WriteLine("Число нечетное"); */

/////////////////////////////////////

/* Задача 8: Напишите программу, которая на вход
принимает число (N), а на выходе показывает все чётные
числа от 1 до N. */

/* Console.WriteLine("Введите число");

int n = int.Parse(Console.ReadLine());

if(n == 1)
  Console.WriteLine("Четных чисел нет");

int i = 2;

while(i <= n)
{
    Console.WriteLine(i);
    i += 2;
}
 */
 