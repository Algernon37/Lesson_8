// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Сколько столбцов в матрице?");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сколько строчек в матрице?");
int n = Convert.ToInt32(Console.ReadLine());
int [,] table = new int  [n,m];
int [,] table1 = new int [n,m];
int [,] table2 = new int [n,m];

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

void Multiplication(int [,] matrix, int [,] matrix1, int [,] matrix2)
{
    int result = 0;
  for (int rows  = 0; rows  < matrix2.GetLength(0); rows ++)
  {
    for (int columns = 0; columns < matrix2.GetLength(1); columns++)
    {
      for (int i = 0; i < matrix.GetLength(1); i++)
      {
        result += matrix[rows ,i] * matrix1[i,columns];
      }
      matrix2[rows,columns] = result;
    }
  }
}

void ShowArray(int [,] matrix)
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
Console.WriteLine();
FillArray(table1);
Console.WriteLine();
Multiplication(table,table1,table2);
ShowArray(table2);