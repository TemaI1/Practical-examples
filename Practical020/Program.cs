/*
Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] array = new int[4];
int sum = 0;


for(int i = 0; i < 4; i++){
    array[i] = new Random().Next(-99, 100);
    Console.Write($"{array[i]} ");

    if(array[i] == array[1]){
        sum += array[i];
    }

    if(array[i] == array[3]){
        sum += array[i];
    }
}

Console.WriteLine($"-> {sum}");