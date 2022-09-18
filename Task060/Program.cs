// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void PrintMatrix(int[,,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            for (int k = 0; k < table.GetLength(2); k++)
            {
                Console.Write($"{table[i, j, k]}{(i, j, k)} \t");
            }
            Console.WriteLine();
        }
        
    }
}

int[,,] FillMatrix(int m, int n, int l)
{
    int[,,] matrix = new int[m, n, l];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
            {
            matrix[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
    return matrix;
} 

try
{
    Console.Write("Введите число: \t");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число: \t");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число: \t");
    int l = Convert.ToInt32(Console.ReadLine());
    int[,,] matrix = FillMatrix(m, n, l);
    Console.WriteLine("Заданный массив с индексами каждого элемента:");
    PrintMatrix(matrix);
}
catch
{
    Console.WriteLine("Надо было вводить целые положительные числа цифрами");
}
