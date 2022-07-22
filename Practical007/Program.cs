int n = 0;

Console.Write("Введите число: ");
n = int.Parse(Console.ReadLine());

int index = 1;

while (index <= n){
    if(index % 2 == 0){
        Console.Write($"{index},");
    }
    index++;
}