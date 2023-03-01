//Задача 62. 
//Напишите программу, которая заполнит спирально массив 4 на 4.

Console.Clear();

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

int[,] ArrayFiledSpirally(int row, int col)
{
    int[,] result = new int[row, col];
    int round;
    if(row > col)
    {
        round = row / 2;
    }
    else
    {
        round = col / 2;
    }

    int count = 0;
    for (int i = 0; i < round; i++)
    {
        for (int j = 0 + i; j < col - i; j++)
        {
            result[i, j] = count++;
        }
        if(count >= col * row)
        {
            break;
        }
        for (int k = 1 + i; k < row - i; k++)
        {
            result[k, col - 1 - i] = count++;
        }
        if(count >= col * row)
        {
            break;
        }
        for (int l = col -2 - i; l >= 0 + i; l--)
        {
            result[row - 1-i,l]=count++;
        }
         if(count >= col * row)
        {
            break;
        }
        for (int m = col -2 - i; m > 0 + i; m--)
        {
            result[m,i] = count++;
        }
    }
    if (row == col && row  % 2 == 1)
    {
        result[row/2, col / 2]= count++;
    }
    return result;
}

Console.Write("Введите кол-во строк: ");
int str = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int num = int.Parse(Console.ReadLine()!);
int[,] array = ArrayFiledSpirally(str,num);
PrintArray(array);