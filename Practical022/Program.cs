/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Write("Сколько числе вы хотите ввести: ");
int quantity = int.Parse(Console.ReadLine());
int result = 0;

for(int i = 0; i < quantity; i++){
    Console.Write("Введите число: ");
    int num = int.Parse(Console.ReadLine());
    if(num > 0){
        result += 1;
    }
}
Console.WriteLine($"Вы ввели {result} числа(ел) больше чем 0");