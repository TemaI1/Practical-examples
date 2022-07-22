int a = 0;
int b = 0;

Console.Write("Введите первое число: ");
a = int.Parse(Console.ReadLine());

Console.Write("Введите первое число: ");
b = int.Parse(Console.ReadLine());

if (a > b){
    Console.WriteLine($"Max {a}");
    Console.WriteLine($"Min {b}");
}else{
    Console.WriteLine($"Max {b}");
    Console.WriteLine($"Min {a}");
}
