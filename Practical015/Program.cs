/*Напишите программу, которая принимает на вход число N 
и выдаёт произведение чисел от 1 до N.
4  -> 24
5  -> 120
*/

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int b = 1;

for (int i = 1; i <= a; i++){
    b = b * i;
}

Console.WriteLine(b);