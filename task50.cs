// Задача 50. Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает значение
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] CreateMatrix()
{
    int[,] matrix = new int[5, 5];
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {

            matrix[i,j] = new Random().Next(1, 101);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
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

void FindNumber (int[,] matrix, int m, int n)
{
   
    if (m-1<matrix.GetLength(0) && n-1<matrix.GetLength(1))
    {
        System.Console.WriteLine(matrix[m-1,n-1]);
    }
    else
    {
        System.Console.WriteLine("Искомого занчения в массиве нет");
    }

}
System.Console.WriteLine("Введите искомую строку");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите искомый столбец");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrix();
PrintMatrix(matrix);
FindNumber(matrix, m, n);