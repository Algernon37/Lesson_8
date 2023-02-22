// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Сколько столбцов в массиве?");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сколько строчек в массиве?");
int n = Convert.ToInt32(Console.ReadLine());
int [,] table = new int  [n,m];
int [,] array = new int [n,m];

void FillArray(int [,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            matrix[rows,columns] = new Random().Next(0,10);
            Console.Write($"{matrix[rows,columns]} ");
        }
        Console.WriteLine();
    } 
}

void ChangeArray(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            for (int columns2 = 0; columns2 < matrix.GetLength(1) - 1; columns2++)
            {
                if(matrix[rows,columns2] > array[rows,columns2+1])
                {
                    int temp = matrix[rows, columns2 + 1];
                    matrix[rows, columns2 + 1] = matrix[rows, columns2];
                    matrix[rows, columns2] = temp;
                }
            }
        }
        Console.WriteLine();
    }
}

void ShowArray(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            Console.Write($"{matrix[rows,columns]} ");
        }
        Console.WriteLine();
    } 
}

FillArray(table);
ChangeArray(table);
ShowArray(table);