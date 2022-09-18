// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

uint AkermanFunction(uint n, uint m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return AkermanFunction(n - 1, 1);
    else
      return AkermanFunction(n - 1, AkermanFunction(n, m - 1));
}

Console.WriteLine("Введите первое число - ");
uint n = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine("Введите второе число - ");
uint m = Convert.ToUInt32(Console.ReadLine());

uint res = AkermanFunction(n,m);
Console.WriteLine(res);