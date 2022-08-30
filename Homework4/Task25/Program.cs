//Напишите цикл, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B.

//метод возводит число А в натуральную степень В
int Exponentiation(int A, int B)
{
    int result = A;

    for (int i = 1; i < B; i++)
    {
        result = result * A;
    }

    return result;
}


Console.Write("Введите число А - ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B - ");
int numberB = Convert.ToInt32(Console.ReadLine());

int res = Exponentiation(numberA,numberB);
Console.WriteLine(res);