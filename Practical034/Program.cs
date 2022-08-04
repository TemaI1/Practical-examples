/*
Задача 65: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 5, 6, 7, 8"
*/

int M = int.Parse(Console.ReadLine());
int N = int.Parse(Console.ReadLine());

string NumbersRec(int start, int end)
{
 if (start <= end) return $"{start} " + NumbersRec(start + 1, end);
 else return String.Empty;
}

Console.WriteLine(NumbersRec(M, N));