/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6;
*/

/*
int m = 3;
int n = 4;
double sum1column = 0;
double[,] array = new double[m,n];
string result = "";

for(int i = 0; i < m; i++){
    sum1column = 0;
    for(int j = 0; j < n; j++){
        array[i, j] = new Random().Next(0, 10);
        Console.Write($"{array[i, j]} ");
        sum1column = sum1column + array[i, j];
    }
    result += string.Format("{0:f1} ", sum1column/m);
    Console.Write($"\n");
}

Console.WriteLine($"Среднее арифметическое каждого столбца: {result}");
*/

int m = 3;
int n = 4;
double sum1column = 0;
double sum2column = 0;
double sum3column = 0;
double sum4column = 0;
double[,] array = new double[m,n];

for(int i = 0; i < m; i++){
    for(int j = 0; j < n; j++){
        array[i, j] = new Random().Next(0, 10);
        Console.Write($"{array[i, j]} ");
        if(j == 0) sum1column = sum1column + array[i, j];
        if(j == 1) sum2column = sum2column + array[i, j];
        if(j == 2) sum3column = sum3column + array[i, j];
        if(j == 3) sum4column = sum4column + array[i, j];
    }
    Console.Write($"\n");
}

string result1 = string.Format("{0:f1}", sum1column/m);
string result2 = string.Format("{0:f1}", sum2column/m);
string result3 = string.Format("{0:f1}", sum3column/m);
string result4 = string.Format("{0:f1}", sum4column/m);
Console.WriteLine($"Среднее арифметическое каждого столбца: {result1} {result2} {result3} {result4}");
