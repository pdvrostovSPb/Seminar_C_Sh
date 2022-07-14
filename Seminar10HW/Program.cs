/* Задача 72: Заданы 2 массива: info и data. В массиве info хранятся двоичные
представления нескольких чисел (без разделителя). В массиве data хранится
информация о количестве бит, которые занимают числа из массива info.
Напишите программу, которая составит массив десятичных представлений чисел
массива data с учётом информации из массива info.
25 мин
входные данные:
- data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
- info = {2, 3, 3, 1 }
выходные данные:
- 1, 7, 0, 1
 */

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "    ");
    }
    Console.WriteLine();
}

int Degree(int number, int degree)
{
    if (degree == 0) return 1;
    int result = number * Degree(number, degree - 1);
    return result;
}

int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };
int pointer = 0;
int[] decim = new int[info.Length];

for (int i = 0; i < info.Length; i++)
{
    int[] binar = new int[info[i]];
    int k = 0;
    for (int j = pointer; j < pointer + info[i]; j++)
    {
        binar[k] = data[j];
        k++;
    }
    pointer += info[i];

    PrintArray(binar);
    
    int sum = 0;
    for (int m = 0; m < binar.Length; m++)
    {
        sum = sum + binar[m] * Degree(2, binar.Length - m - 1);
    }
    decim[i] = sum;
}

PrintArray(decim);


/////////////////////////////////////////////////////////////////////////


/* Задача 73: Есть число N. Сколько групп M, можно получить при разбиении всех
чисел на группы, так чтобы в одной группе все числа были взаимно просты (все
числа в группе друг на друга не делятся)? Найдите M при заданном N и получите
одно из разбиений на группы N ≤ 10²⁰.
25 мин
Например, для N = 50, M получается 6
- Группа 1: 1
- Группа 2: 2 3 11 13 17 19 23 29 31 37 41 43 47
- Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
- Группа 4: 8 12 18 20 27 28 30 42 44 45 50
- Группа 5: 7 16 24 36 40
- Группа 6: 5 32 48
*/
