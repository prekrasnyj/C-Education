//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите  число N - ");
int numberN = Convert.ToInt32(Console.ReadLine());

while (numberN > 0)
{
    if (numberN % 2 == 0) 
    {
        Console.WriteLine(numberN);
    }
    numberN--;
}