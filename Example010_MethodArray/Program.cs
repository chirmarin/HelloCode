int[] array = {1,2,3,4,5,66,7,8,119,66};

int n = array.Length;
int find = 66;

int index = 0;

while(index < n) {
    if(array[index] == find){
        Console.WriteLine(index);
        break;
    }
    index++;
}