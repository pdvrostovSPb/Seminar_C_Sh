/* Напишите программу, которая на вход принимает два числа и выдаёт
первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
3 и 4, N = 5 -> 3 4 7 11 18
6 и 10, N = 4 -> 6 10 16 26 */

/* int Rec(int n, int m, int N)
{
   if (N == 1) return n;
   if (N == 2) return m;
   return Rec (n, m, N - 1) + Rec(n, m, N-2);
}

for (int i = 1; i <= 10; i++)
{
Console.Write (Rec (3,4,i) + "   ");
} */

/* В некотором машинном алфавите имеются четыре буквы «а», «и», «с»
и «в». Покажите все слова, состоящие из n букв, которые можно построить из
букв этого алфавита.
n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са,
ав, ва, ви, ив, св, вс */



string[] Words(string[] abc, int n)
{
    string[] res;
    if (n == 0)
    {
        res = new string[1];
        res[0] = "";
        return res;
    }
    string[] prev = Words(abc, n - 1);

    res = new string[abc.Length * prev.Length];
    int k = 0;
    for (int i = 0; i < prev.Length; i++)
    {
        for (int j = 0; j < abc.Length; j++)
        {
            res[k] = prev[i] + abc[j];
            k++;
        }
    }

    return res;
}

string[] alf = { "a", "и", "c", "в", "т" };
string[] result = Words(alf, 3);
for (int i = 0; i < result.Length; i++)
{
    Console.Write(i + " " + result[i] + " ");
}
