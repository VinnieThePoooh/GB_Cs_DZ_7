// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[,] CreateMatrix()
{
    double[,] matrix = new double[5, 5];
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {

            matrix[i, j] = new Random().Next(1, 101);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

double[] FindAver(double[,] matrix)
{
    double[] array = new double[5];
    double sum = 0;
    int c = 0;
    while (c < 5)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, j];
            }
            array[c] = sum / matrix.GetLength(0);
            sum = 0;
            c++;
        }

    }
    return array;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

double[,] matrix = CreateMatrix();
PrintMatrix(matrix);
double[] array = FindAver(matrix);
PrintArray(array);

// Была еще идея сделать в матрице дополнительную строку внизу
//  и складывать внее среднее арифметическое вышестоящих членов,
// потом записать содержимое этой строки в массив и вывести, но я устал.