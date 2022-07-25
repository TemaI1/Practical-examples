Console.Write("Введите число: ");
string a = Console.ReadLine();
char[] number = new char[a.Length]; 

for(int i = 0; i < a.Length; i++){
    number[i] = a[i];
    }

int b = int.Parse(a);

if(b <= 99){
    Console.WriteLine("Третьей цифры нет ");
}else{
    Console.WriteLine(number[2]);
}