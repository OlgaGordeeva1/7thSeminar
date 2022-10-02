// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет


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

void Position(int[,] array, int k, int l)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    if (k <= rows && l <= columns) { Console.WriteLine(array[k, l]); }
    else { Console.WriteLine("Такого числа в массиве нет"); }
}

int[,] matrix = CreateArray(4, 4);
Fill(matrix, 1, 15);
Print(matrix);
int m = Input("rows:");
int n = Input("columns:");
Position(matrix, m, n);

