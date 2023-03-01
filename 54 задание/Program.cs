//Задайте двумерный массив.
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void truArray(int[,] inArray)
{
    int temp;
    for (int i=0; i<inArray.GetLength(0); i++)
    {
        for (int j=0; j<inArray.GetLength(1); j++)
        {
            for (int k =1; k < inArray.GetLength(1); k++ )
            {
                if (inArray[i,k]> inArray[i,k-1])
                {
                    temp = inArray[i,k-1];
                    inArray[i,k -1]= inArray[i,k];
                    inArray[i,k]=temp;
                }
            }
        }
    }
}
void falsArray(int[,] inArray)
{
    int temp;
    for (int i=0; i<inArray.GetLength(0); i++)
    {
        for (int j=0; j<inArray.GetLength(1); j++)
        {
            for (int k = 1; k < inArray.GetLength(1); k++ )
            {
                if (inArray[i,k] < inArray[i,k-1])
                {
                    temp = inArray[i,k-1];
                    inArray[i,k -1]= inArray[i,k];
                    inArray[i,k]=temp;
                }
            }
        }
    }
}

Console.Write("Введите кол-во строк: ");
int str = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int num = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(str,num,0,100);
PrintArray(array);
truArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
falsArray(array);
PrintArray(array);
