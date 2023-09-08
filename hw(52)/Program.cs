// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифмитическое элементов в каждом столбце.
//   i   (0)(1)(2)(3) = j
//  (0)   1  4  7  2
//  (1)   5  9  2  3
//  (2)   8  4  2  4 

// AVG (каждого столбца)= 4,6; 5,6; 3,6; 3.

int rowsMatrix = RowsMatrix(" ");
int columnsMatrix = ColumnsMatrix(" ");
int minNum = MinNumMatrix(" ");
int maxNum = MaxNumMatrix(" ");
int[,] matrix = CreateMatrixRndInt(rowsMatrix, columnsMatrix, minNum, maxNum);
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
AvgSumElemEachColumns(matrix);

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }
}

int RowsMatrix(string rows)
{
    Console.Write("Введите кол-во рядов в массиве: ");
    return Convert.ToInt32(Console.ReadLine());
}

int ColumnsMatrix(string columns)
{
    Console.Write("Введите кол-во столбцов в массиве: ");
    return Convert.ToInt32(Console.ReadLine());
}

int MinNumMatrix(string min)
{
    Console.Write("Введите минимальное число массива: ");
    return Convert.ToInt32(Console.ReadLine());
}

int MaxNumMatrix(string max)
{
    Console.Write("Введите максимальное число массива: ");
    return Convert.ToInt32(Console.ReadLine());
}

void AvgSumElemEachColumns(int[,] matrix)
{
    Console.WriteLine("<- Среднее аримфитическое каждого столбца ->");
    Console.WriteLine();
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int countPositionColumns = 1;
        countPositionColumns += j;
        double sum = 0;
        double avg = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {

            sum += matrix[i, j];
        }
        avg = sum / rowsMatrix;
        Console.Write($"Столбец №{countPositionColumns} ");
        Console.WriteLine($"{avg:F1}");
    }
}