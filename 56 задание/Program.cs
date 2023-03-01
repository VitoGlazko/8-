//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int RowLowElement(int[,] inArray)
{
    int result = 1;
    int minSumRow = 0;
    int sum = 0;
    for (int m = 0; m < inArray.GetLength(1); m++)
    {
        minSumRow += inArray[0, m];
    }
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j =0; j < inArray.GetLength(1); j++)
        {
            sum += inArray[i,j];
        }
        if (sum < minSumRow)
        {
            minSumRow = sum;
            result = i+1;
        }
        sum = 0;
    }
    return result;

}

Console.Write("Введите кол-во строк: ");
int str = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int num = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(str,num,0,100);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(RowLowElement(array));