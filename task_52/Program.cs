// Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int[,] RandomMatrix(int min, int max)
{
    Console.WriteLine("Введите количество строк");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов");
    int columns = Convert.ToInt32(Console.ReadLine());
    Random rnd = new Random();
    int[,] matrix = new int[rows,columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(min,max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        System.Console.Write("[");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j < arr.GetLength(1)- 1) Console.Write($"{arr[i,j],2}, ");
            else Console.WriteLine($"{arr[i,j],2}]");
        }
    }
}
void GetAverageOfRows(int[,]matrix)
{
    System.Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double summ = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summ += matrix[i,j];
        }
        System.Console.Write( (i < matrix.GetLength(0)-1) ? $"{summ / matrix.GetLength(1)}; ":$"{summ / matrix.GetLength(1)}.");
    }
    System.Console.WriteLine();
}
int[,] rndmatrix = RandomMatrix(1,100);
PrintMatrix(rndmatrix);
GetAverageOfRows(rndmatrix);