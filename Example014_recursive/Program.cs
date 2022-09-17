// See https://aka.ms/new-console-template for more information

int[] Recursive(int a, int b)
{
    int[] list = new int[b - a + 1];
    int count = 0;
    if (a <= b)
    {
        list[count] = a;
        Console.WriteLine(a);
        count++;
        Recursive(++a, b);
    }
    return list;
}

int[] res = Recursive(1,10);
for (int i = 0; i < res.Length; i++)
{
    Console.Write($"{res[i]}, ");
}