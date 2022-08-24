int[] array = { 14, 22, 64, 55, 26, 55, 38 };

int n =  array.Length;
int find = 55;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index ++;
}