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
int m = 3, n = 4;
int[,] mass = new int[m, n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 10);
    }
}

Print(mass);
Console.WriteLine();
int element = 0;
  
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            element = mass[0, j];
            mass[0, j] = mass[mass.GetLength(0)-1, j];
            mass[mass.GetLength(0)-1, j] = element;
            //Console.Write(mass[0, j] + " ");
            //Console.Write(mass[mass.GetLength(0)-1, j] + " ");
        }
        Console.WriteLine();
   
Print(mass);
 */

 //////////////////////////////////////////////////////////////////////////

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
int m = 4, n = 4;
int[,] mass = new int[m, n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 10);
    }
}

Print(mass);
int element = 0;
if ( mass.GetLength(0) == mass.GetLength(1))
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j=0; j<=i ;j++)

        {
            element = mass[i, j];
            mass[i, j] = mass[j, i];
            mass[j, i] = element;
            //Console.Write(mass[0, j] + " ");
            //Console.Write(mass[mass.GetLength(0)-1, j] + " ");
        }
    
        }    Console.WriteLine();
}
else Console.WriteLine("НЕТ");
Print(mass);
Console.WriteLine();
*/

// код Ванеча

void Print(int[,] arr)
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
int m = 4, n = 4;
int[,] mass = new int[m, n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 10);
    }
}

Print(mass);
int counterrr = 0;
Console.WriteLine("ВВеди число для поиска ");
int A = int.Parse(Console.ReadLine());
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        if (mass[i,j] == A)
        {
            counterrr++;
        }
    }
}
Console.WriteLine("Совпадений: " + counterrr);

///////////////////////////////////////////////

void Print(int[,] arr)
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
int m = 4, n = 4;
int[,] mass = new int[m, n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 10);
    }
}

Print(mass);

int count = 0;
int a = 0;
int[] uniq = new int[mass.Length];
int k = 0;
bool finded = false;
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {


        finded = false;
        for (int l = 0; l < k; l++)
        {
            if (mass[i, j] == uniq[l])
                finded = true;
        }
        if (!finded)
        {
            uniq[k] = mass[i, j];
            k++;
        }
    }
}

for (int j = 0; j < k; j++)
{
    Console.Write(uniq[j] + " ");
}
Console.WriteLine();

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        if (mass[i, j] == a)
        {
            count++;
        };
    }
}

Console.WriteLine(count);
for (int z = 0; z < k; z++)
{
    count = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            if (mass[i, j] == uniq[z])
            {
                count++;
            };
        }
    }

    Console.WriteLine(uniq[z] + " встречается " + count);
}


