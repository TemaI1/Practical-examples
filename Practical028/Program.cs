/*
**Задача 55:** Задайте двумерный массив. Напишите программу, 
которая заменяет строки на столбцы. В случае, если это невозможно, 
программа должна вывести сообщение для пользователя.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
В итоге получается вот такой массив:
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
*/

int n = 4;
int m = 4;
int[,] array = new int[n,m];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        array[i,j] = new Random().Next(10);
        Console.Write($"{array[i,j]} ");
    
    }
    Console.WriteLine();
}

for (int i = 0; i < n; i++)
{
    for (int j = 1+i; j < m; j++)
    {
        int tmp = 0;
        tmp = array[i, j];
        array[i,j] = array[j, i];
        array[j,i] = tmp;
    }
}

Console.WriteLine();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{array[i,j]} ");
    
    }
    Console.WriteLine();
}

