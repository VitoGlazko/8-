//Задача 58: Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j =0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

int[,] MatrixMul(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] result = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            int value = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                value += firstMatrix[i, k] * secondMatrix[k, j];
            }
            result[i, j] = value;
        }
    }
    return result;
}

Console.Write(" 1 матрица Введите кол-во строк: ");
int str = int.Parse(Console.ReadLine()!);
Console.Write(" 1 матрица Введите кол-во столбцов: ");
int num = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(str,num,0,100);
Console.Write("2 матрица Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("2 матрица Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);
int[,] yarra = GetArray(row,col,0,100);
PrintArray(array);
Console.WriteLine("-----------");
PrintArray(yarra);
Console.WriteLine("-----------");
int [,]rog = MatrixMul(array, yarra);
PrintArray(rog);

