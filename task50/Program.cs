Console.WriteLine("Введите размерность думерного массива m x n: ");
Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());



int[,] FillArray(int m, int n)
{
    int[,] outArray = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            outArray[i, j] = new Random().Next(-99, 100);
            Console.Write(outArray[i, j] + " ");
        }
        Console.WriteLine();
    }
    return outArray;
}
Console.WriteLine();
int[,] Matrix = FillArray(m, n);
Console.WriteLine();

Console.WriteLine("Введите искомое число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool SearchNum = false;

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (Matrix[i, j] == num)
        {
            SearchNum = true;
            break;    
        }
        
    }
}

Console.WriteLine();

if(SearchNum == true)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Число ({num}) найдено в двумерном массиве. ");
}
else
{   Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Число ({num}) не найдено в двумерном массиве. ");
}
