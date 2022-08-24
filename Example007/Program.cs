int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 2;
int a2 = 5;
int a3 = 15;
int b1 = 1;
int b2 = 25;
int b3 = 23;
int c1 = 12;
int c2 = 6;
int c3 = 9;

int max1 = Max(a1, a2, a3);
int max2 = Max(b1, b2, b3);
int max3 = Max(c1, c2, c3);
int max = Max(max1, max2, max3);

Console.WriteLine(max);