Console.Write("Введите цифру от 1 до 7: ");
int a = int.Parse(Console.ReadLine());

if(a <= 5){
    Console.WriteLine("No");
}else if(a <= 7){
    Console.WriteLine("Yes");
}else{
    Console.WriteLine("Введенное число больше 7, прошу выполнить условия!");
}