int a = 0;
int b = 0;
int c = 0;
int max = 0;

Console.Write("Введите первое число: ");
a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
b = int.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");
c = int.Parse(Console.ReadLine());

if(max > a){
    max = max;
}else{
    max = a;
}

if(max > b){
    max = max;
}else{
    max = b;
}

if(max > c){
    max = max;
}else{
    max = c;
}


Console.WriteLine($"Max {max}");

