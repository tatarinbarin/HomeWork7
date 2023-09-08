// Задача 47: Задайте двухмерный массив размером m*n, заполненный случайными вещественными числами.

int RowsMatrix(string rows)
{
    Console.Write("Укажите кол-во рядов: -> ");
    return Convert.ToInt32(Console.ReadLine());
}

int ColumnsMatrix(string columns)
{
    Console.Write("Укажите кол-во столбцов: -> ");
    return Convert.ToInt32(Console.ReadLine());
}

int MinNumMatrix(string min)
{
    Console.Write("Введите минимальное число массива: -> ");
    return Convert.ToInt32(Console.ReadLine());
}

int MaxNumMatrix(string max)
{
    Console.Write("Введите максимальное число массива: -> ");
    return Convert.ToInt32(Console.ReadLine());
}

double[,] CreateMatrixRndDouble(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.NextDouble() * (max - min) + min;
        }

    }
    return matrix;
}

void PrintMatrixDouble(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5:F1}");
        }
        Console.WriteLine();
    }
}

int rowsMatrix = RowsMatrix(" ");
int colMatrix = ColumnsMatrix(" ");
int minNum = MinNumMatrix (" ");
int maxNum = MaxNumMatrix (" ");

double[,] array2d = CreateMatrixRndDouble(rowsMatrix, colMatrix, minNum, maxNum);
PrintMatrixDouble(array2d);