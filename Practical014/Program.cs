/*Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

int GetCountNums (int a){
    int count = 0;
    for (int i = 1; a != 0; i++){
        a = a/10;
        count++;
    }
    return count;
}

int b = int.Parse(Console.ReadLine());
Console.WriteLine($"Количество цифр в числе {GetCountNums(b)}");