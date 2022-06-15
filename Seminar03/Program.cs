/* Задача 19: Напишите программу, которая принимает на
вход пятизначное число и проверяет, является ли оно
палиндромом. */

/* Console.WriteLine("Введите пятизначное число");
int NumberN = int.Parse(Console.ReadLine());

if (NumberN < 10000 || NumberN > 99999)
{
    Console.WriteLine("Вы ввели не пятизначное число");
}
else if (NumberN / 10000 == NumberN % 10 && NumberN / 1000 % 10 == NumberN % 100 / 10)
{
    Console.WriteLine("Это палиндром");
}
else
{
    Console.WriteLine("Это не палиндром");
}  */
////////////////////////////////////////////////////////////

/* Задача 21: Напишите программу, которая принимает на
вход координаты двух точек и находит расстояние между
ними в 3D пространстве. */

/* Console.Write("Введите координату X1 = ");
double X1 = double.Parse(Console.ReadLine());

Console.Write("Введите координату Y1 = ");
double Y1 = double.Parse(Console.ReadLine());

Console.Write("Введите координату Z1 = ");
double Z1 = double.Parse(Console.ReadLine());

Console.Write("Введите координату X2 = ");
double X2 = double.Parse(Console.ReadLine());

Console.Write("Введите координату Y2 = ");
double Y2 = double.Parse(Console.ReadLine());

Console.Write("Введите координату Z2 = ");
double Z2 = double.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(X1-X2,2) + Math.Pow(Y1-Y2,2) + Math.Pow(Z1-Z2,2));

Console.WriteLine(result); */

////////////////////////////////////////////////////////////////

/* Задача 23: Напишите программу, которая принимает на
вход число (N) и выдаёт таблицу кубов чисел от 1 до N. */

/* Console.Write("Введите число ");
int NumberN = int.Parse(Console.ReadLine());

for (int Count = 1; Count <= NumberN; Count++)
{
    Console.Write(Count);
    Console.Write(" в кубе = ");
    Console.WriteLine(Math.Pow(Count, 3));
} */