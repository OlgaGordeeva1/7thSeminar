// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.

// int m = 3;
// int n = 4;

// int[,] matrix = new int[m, n];
// // new Random().Next(1,10);

// for (int row = 0; row < m; row++)
// {
//     for (int column = 0; column < n; column++)
//     {
//         matrix[row, column] = new Random().Next(1, 10);
//         Console.Write($"{matrix[row, column],3}");
//     }
//     Console.WriteLine();
// }




int[,] CreateArray(int rows, int columns)   //метод для создания нового пустого двумерного массива
{
    return new int[rows, columns];
}

void Fill(int[,] array, int min, int max)                     // метод для заполнения массива случайными числами
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

void Print(int[,] array)    // метод для печати массива
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

int Input(string text)
{
    bool f = false;
    int number = 0;
    while (!f)
    {
        System.Console.Write(text);
        string str = Console.ReadLine();
        f = int.TryParse(str, out number);
    }
    return number;
}

void MultiplyBy(int number, int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int result = new int[rows, columns];
    for (int row = 0; row < rows; row++)
    {
        for (int column = 0; column < columns; column++)
        {
            result[row, column] = number * array[row, column];
        }
        return result;
    }
}

    int m = Input("rows:");
    int n = Input("colmns:");
    int[,] matrix = CreateArray(m, n);
    Fill(matrix, 1, 15);
    Print(matrix);


