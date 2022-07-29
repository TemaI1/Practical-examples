/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

int[] array = new int[5] {3, 7, 22, 2, 78};
int max = array[0];
int min = array[0];

for(int i = 0; i < 5; i++){
    if(array[i] >= max){
        max = array[i];
    }
    if(array[i] <= min){
        min = array[i];
    }
}

Console.WriteLine($"Max = {max} Min = {min}");
Console.WriteLine($"Разница между максимальным и минимальным: {max - min}");
