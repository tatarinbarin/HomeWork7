// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например массив: 
// 1 2 4 7
// 5 2 6 9
// 3 1 0 7
// 4 2 3 1
// 1, 7 -> такого числа в массиве нет

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
    Console.Write("Введите кол-во рядов массива: ");
    return Convert.ToInt32(Console.ReadLine());
}

int ColumnsMatrix(string columns)
{
    Console.Write("Введите кол-во столбцов массива: ");
    return Convert.ToInt32(Console.ReadLine());
}

int rowsMatrix = RowsMatrix(" ");
int columnsMatrix = ColumnsMatrix(" ");
Console.Write("Введите позицию элемента в ряд: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию элемента в столбец: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int[,] array2d = CreateMatrixRndInt(rowsMatrix, columnsMatrix, 1, 20);
PrintMatrix(array2d);

int elemMatrix = ElemMatrix(array2d);

int ElemMatrix(int[,] array2d)
{
    int numMatrix = 0;
    for (int i = 0; i <= array2d.GetLength(0); i++)
    {
        for (int j = 0; j <= array2d.GetLength(1); j++)
        {
            if (num1 <= array2d.GetLength(0) - 1 && num2 <= array2d.GetLength(1) - 1)
            {
                numMatrix = array2d[num1, num2];
            }
        }
    }
    return numMatrix;
}

bool ExaminationAvailabilityElem(int[,] matrix)
{
    return num1 <= rowsMatrix - 1 && num2 <= columnsMatrix - 1;
}

bool examinationAvailabilityElem = ExaminationAvailabilityElem(array2d);
Console.WriteLine(examinationAvailabilityElem
? $"Число с данной позицией: {num1},{num2} присутствует, это число {elemMatrix}"
: $"Число с данной позицией: {num1},{num2} отсутствует, т.к. такой позиции не существует");