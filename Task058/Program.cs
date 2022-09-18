// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:                     Результирующая матрица будет:
// 2 4 | 3 4                                     18 20
// 3 2 | 3 3                                     15 18
int[,] FillMatrix(int row, int col)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = new Random().Next(0, 100);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write(table[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
    {
        Console.WriteLine("Произведение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
    }
    int[,] newMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            newMatrix[i, j] = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                newMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }
    return newMatrix;
}

try
{
    Console.Write("Введите количество строк матрицы А: \t");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов матрицы А: \t");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество строк матрицы В: \t");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов матрицы В: \t");
    int col = Convert.ToInt32(Console.ReadLine());
    int[,] firstMatrix = FillMatrix(m, n);
    int[,] secondMatrix = FillMatrix(row, col);
    Console.WriteLine("Первая матрица: ");
    PrintMatrix(firstMatrix);
    Console.WriteLine("Вторая матрица: ");
    PrintMatrix(secondMatrix);
    int[,] newMatrix = MultiplyMatrix(firstMatrix, secondMatrix);
    Console.WriteLine("Произведение матриц: ");
    PrintMatrix(newMatrix);
}
catch 
{
    Console.WriteLine("Надо было вводить целые положительные числа цифрами");
}
