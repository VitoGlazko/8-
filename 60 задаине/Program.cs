//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.Clear();

int[,,] GetArray(int rows, int colomns, int height)
{
    int[,,] result = new int[rows, colomns, height];
    int count = 10;
    for (int i = 0; i < rows; i++)
    {
        for (int j =0; j < colomns; j++)
        {
            for (int b = 0; b < height; b++)
            {
                result[i, j, b] = count++;
            }    
        }
    }
    return result;
}
void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int b = 0; b < inArray.GetLength(2); b++)
            {
                Console.Write($"{inArray[i, j, b]} ({i}, {j}, {b}) \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
Console.Write("Введите кол-во строк: ");
int r = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int c = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во высота: ");
int b = int.Parse(Console.ReadLine()!);
if (r*c*b <= 89)
{
    int[,,] array = GetArray(r,c,b);
    PrintArray(array);
}
else
{
    Console.WriteLine("условие: целых неповторяющихся двух значных чисел не возможно");
}