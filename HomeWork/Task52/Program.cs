// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill(int[,] array, int min, int max)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int row = 0; row < rows; row++)
    {
        for (int column = 0; column < columns; column++)
        {
            array[row, column] = new Random().Next(min, max);
        }
    }
}

void Print(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int row = 0; row < rows; row++)
    {
        for (int column = 0; column < columns; column++)
        {
            Console.Write($"{array[row, column],3}");
        }
        Console.WriteLine();
    }
}

void Average(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    double result = 0;
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        { result += array[i, j]; }
        Console.Write($"{result / columns ,5} ;");
    }
}

int[,] matrix = CreateArray(5, 5);
Fill(matrix, 1, 5);
Print(matrix);
Average(matrix);