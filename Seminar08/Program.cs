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


