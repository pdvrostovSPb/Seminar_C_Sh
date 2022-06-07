/* Console.WriteLine("Введите число а ");
Console.WriteLine("Введите число b ");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if (a > b)
  Console.WriteLine("max = a");
else
  Console.WriteLine("max = b");
 */

//////////

/* Console.WriteLine("Введите число а ");
Console.WriteLine("Введите число b ");
Console.WriteLine("Введите число c ");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if (a > b)
  if(a > c)
    Console.WriteLine("max = " + a);
  else
    Console.WriteLine("max = " + c);
else
  if(b > c)
    Console.WriteLine("max = " + b);
  else
    Console.WriteLine("max = " + c); */

    ////////

/* Console.WriteLine("Введите число");

int n = int.Parse(Console.ReadLine());

if(n % 2 == 0)
  Console.WriteLine("Число четное");
else
  Console.WriteLine("Число нечетное"); */

///////////

Console.WriteLine("Введите число");

int n = int.Parse(Console.ReadLine());

int i = 0;

while(i <= n)
{
    Console.WriteLine(i);
    i += 2;
}

  