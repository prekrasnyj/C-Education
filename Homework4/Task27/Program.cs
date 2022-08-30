//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//Метод позволяет узнать кол-во цифр в числе
int QuantityDigits(int num)
{
    int quantity = 1;

    while (num/10 != 0)
    {
        quantity ++;
        num = num/10;
     
    }

    return quantity;
}

//метод выдаёт сумму цифр в числе
int SumDigitsInNumber(int num, int quant)
{
    int sum = 0;

    for (int i = 0; i < quant; i++)
    {
        sum = sum + (num%10);
        num = num/10;
    }

    return sum;
}

Console.Write("Введите число - ");
int number = Convert.ToInt32(Console.ReadLine());

int quantity = QuantityDigits(number);
int result = SumDigitsInNumber(number, quantity);
Console.WriteLine(result);