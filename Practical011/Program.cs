/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначное число: ");
string a = Console.ReadLine();
char[] number = new char[a.Length]; 

for(int i = 0; i < a.Length; i++){
number[i] = a[i];
}

if(number[0] == a[a.Length - 1] || number[1] == a[a.Length - 2]){
    Console.WriteLine("Yes");
}else{
    Console.WriteLine("No");
}