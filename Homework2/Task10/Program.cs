//Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа.

//Метод, который показывает вторую цифру трехзначного числа
int findSecondDigit(int threeDigitNumber)
{
    int secondDigit = (threeDigitNumber/10)%10;
    return secondDigit;
}

Console.Write("Введите 3-значное число - ");
int newThreeDigitNumber = Convert.ToInt32(Console.ReadLine());
int result = findSecondDigit(newThreeDigitNumber);

Console.WriteLine(result);