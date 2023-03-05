// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateMatrix (int m, int n)
{
    double number1 = 0.0;
    double number2 = 0.0;
    double number3 = 0.0;
    double[,] matrix = new double[m,n];
    for (int i=0; i<m; i++)
    {
        for (int j=0; j<n; j++)
        {
            number1 = new Random().Next(0,100);
            number2 = new Random().Next(0,100);
            number3 = Math.Round(number1/number2, 2);
            matrix[i,j] = number3;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i,j]+" ");
        }
        System.Console.WriteLine();
    }
}

System.Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix  = CreateMatrix(m,n);
PrintMatrix(matrix);