// Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого 
// элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет
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
            if (j < arr.GetLength(1)- 1) Console.Write($"{arr[i,j],5}, ");
            else Console.WriteLine($"{arr[i,j],5}]");
        }
    }
}
void GetMatrixCell(int[,] matrix)
{
    System.Console.WriteLine("Введите строку искомой ячейки (не индекс)");
    int row = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите столбец искомой ячейки (не индекс)");
    int column = Convert.ToInt32(Console.ReadLine());
    if (row < matrix.GetLength(0) && column < matrix.GetLength(1)) System.Console.WriteLine(matrix[row-1,column-1]);
    else System.Console.WriteLine("такого элемента в массиве нет");


}
int[,] rndmatrix = RandomMatrix(-10,10);
PrintMatrix(rndmatrix);
GetMatrixCell(rndmatrix);
