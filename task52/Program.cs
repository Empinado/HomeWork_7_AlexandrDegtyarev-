// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите размерность думерного массива m x n: ");
Console.WriteLine("Введите m: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите n: ");
int m = Convert.ToInt32(Console.ReadLine());



int[,] FillArray(int n, int m)
{
    int[,] outArray = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            outArray[i, j] = new Random().Next(1, 10);
            Console.Write(outArray[i, j] + " ");
        }
        Console.WriteLine();
    }
    return outArray;
}
Console.WriteLine();
int[,] Matrix = FillArray(n, m);
Console.WriteLine();

int[] sum = new int[m];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        sum[j] += Matrix[i, j];
    }
}

Console.WriteLine();

Console.WriteLine(string.Join(",",sum));

Console.WriteLine();

foreach (double elem in sum)
{
    Console.Write(Math.Round(elem / n, 1) + ";" + " ");
}
