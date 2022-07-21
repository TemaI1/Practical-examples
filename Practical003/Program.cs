int number = 0;
int number2 = 0;
int number3 = 0;

Console.Write("Введите первое число: ");
number = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
number2 = int.Parse(Console.ReadLine());

number3 = number * number;

if(number3 == number2)
{
    Console.Write("Yes");
}
else
{
    Console.Write("No");
}