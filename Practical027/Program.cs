/*
**Задача 53:** Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
8 4 2 4
5 9 2 3
1 4 7 2
*/

int m = 3;
int n = 4;

int[,] array = new int[m,n];

for(int i = 0; i < m; i++){
    for(int j = 0; j < n; j++){
        array[i, j] = new Random().Next(0, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.Write($"\n");
}

Console.Write($"\n");

for(int i = 0; i < n; i++){
    int c = array[0, i];
    array[0, i] = array[m-1, i];
    array[m-1, i] = c;
}

for(int i = 0; i < m; i++){
    for(int j = 0; j < n; j++){
        Console.Write($"{array[i, j]} ");
    }
    Console.Write($"\n");
}