// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


double[,] CreateArray(int rows, int columns)
{
    return new double[rows, columns];
}

void Fill(double[,] array, int min, int max)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    Random x = new Random();
    for (int row = 0; row < rows; row++)
    {
        for (int column = 0; column < columns; column++)
        {
            array[row, column] = Convert.ToDouble(x.Next(min, max)/10.0);
        }
    }
}

void Print(double[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int row = 0; row < rows; row++)
    {
        for (int column = 0; column < columns; column++)
        {
            Console.Write($"{array[row, column],6}");
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

int m = Input("rows:");
int n = Input("colmns:");
double[,] matrix = CreateArray(m, n);
Fill(matrix, -100, 100);
Print(matrix);