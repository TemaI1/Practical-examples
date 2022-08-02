/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

Console.Write($"Введите число: ");
int num = int.Parse(Console.ReadLine());
int counter = 0;
int[,] array = new int[3,4];

for(int i = 0; i < 3; i++){
    for(int j = 0; j < 4; j++){
        array[i, j] = new Random().Next(0, 10);
        Console.Write($"{array[i, j]} ");
        if(array[i, j] == num){
            counter += 1;
        }else{
            counter = counter;
        }
    }
    Console.Write($"\n");
}

if(counter > 0){
    Console.WriteLine($"{num} -> число {num} существует в этом массиве");
}else{
    Console.WriteLine($"{num} -> такого числа в массиве нет");
}