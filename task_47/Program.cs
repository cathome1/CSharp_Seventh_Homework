// Задайте двумерный массив размером m×n, заполненный 
// случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
double[,] RandomMatrix(int min, int max)
{
    Console.WriteLine("Введите количество строк");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов");
    int columns = Convert.ToInt32(Console.ReadLine());
    Random rnd = new Random();
    double[,] matrix = new double[rows,columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Math.Round(rnd.Next(min,max) + rnd.NextDouble(),2);
        }
    }
    return matrix;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        System.Console.Write("[");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j < arr.GetLength(1)- 1) Console.Write($"{arr[i,j],5}, ");
            else Console.WriteLine($"{arr[i,j],5}]");
        }
    }
}
double[,] rndmatrix = RandomMatrix(-10,10);
PrintArray(rndmatrix);