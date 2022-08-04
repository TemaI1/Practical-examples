/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int m = 4;
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

//Находим сумму строк
int sum1Line = 0;
int sum2Line = 0;
int sum3Line = 0;
int sum4Line = 0;
for(int j = 0; j < n; j++){
    sum1Line = sum1Line + array[0,j];
    sum2Line = sum2Line + array[1,j];
    sum3Line = sum3Line + array[2,j];
    sum4Line = sum4Line + array[3,j];
}

//Находим минимальное значение из всех строк
int minSumLine = sum1Line;
if(minSumLine > sum2Line) minSumLine = sum2Line;
if(minSumLine > sum3Line) minSumLine = sum3Line;
if(minSumLine > sum4Line) minSumLine = sum4Line;

//Находим номер строки с наименьшей суммой элементов
int minLine = 1;
if(minSumLine >= sum2Line) minLine = 2;
if(minSumLine >= sum3Line) minLine = 3;
if(minSumLine >= sum4Line) minLine = 4;

Console.Write($"Номер строки с наименьшей суммой элементов: {minLine} строка \nСумма элементов: {minSumLine}");


