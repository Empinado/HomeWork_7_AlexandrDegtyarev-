// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите размерность думерного массива m x n: ");
Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] FillingTwoDemensionalArray(int m, int n)
{
    double[,] outArray = new double[m, n];

    System.Random numberSintezator = new System.Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            outArray[i, j] = numberSintezator.Next(-3, 3) + numberSintezator.NextDouble();
            outArray[i, j] = Math.Round(outArray[i, j], 3);
            Console.Write(outArray[i, j] + " ");
        }
        Console.WriteLine();
    }

    return outArray;
}

double[,] Matrix = FillingTwoDemensionalArray(m, n);



