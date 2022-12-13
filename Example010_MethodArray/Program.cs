int[] array = {1, 45, 78, 34, 98, 45, 27, 96};

int n = array.Length;
int find = 98;
int index = 0;

while (index < n){
    if(array[index] == find){
        Console.WriteLine(index);
        break;
    }
    index++;
}