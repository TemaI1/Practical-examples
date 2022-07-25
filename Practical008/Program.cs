Console.Write("Введите трех значное число: ");
string a = Console.ReadLine();
char[] number = new char[a.Length]; 

for(int i = 0; i < a.Length; i++){
    number[i] = a[i];
    }

Console.WriteLine(number[1]);