// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int [,] table = new int  [4,3];


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

void SumArray(int [,] matrix)
{
    int row = 0;
    int MinSum = 0;
    int Sum = 0;

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        row = row + matrix[0, i];
    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Sum += Sum + matrix[i, j];
        }

        if (Sum < row)
        {
            row = Sum;
            MinSum = i;
        }
        Sum = 0;
    }
    Console.Write($"{MinSum + 1} строка");
}

FillArray(table);
SumArray(table);