/*
Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int m = 3;
int n = 4;
int[,] array = new int[m,n];

//Начальный массив
for(int i = 0; i < m; i++){
    for(int j = 0; j < n; j++){
        array[i, j] = new Random().Next(0, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.Write($"\n");
}
Console.Write($"\n");

//Перебор массива
for(int k = 0; k < n; k++){
    for (int i = 0; i < n - 1; i++){
        for (int j = 0; j < m; j++){
        int c = 0;
        c = array[j,i];
        if(array[j,i] <= array[j,i + 1]){
            array[j,i] = array[j,i + 1];
            array[j,i + 1] = c;
            }
        }
    }
}

//Итоговый массив
for(int i = 0; i < m; i++){
    for(int j = 0; j < n; j++){
        Console.Write($"{array[i, j]} ");
    }
    Console.Write($"\n");
}