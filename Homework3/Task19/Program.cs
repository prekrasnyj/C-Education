//Напишите программу, которая принимает на вход
//пятизначное число и проверяет, является ли оно палиндромом.

//метод проверяет: пять ли цифр в числе
bool CheckFiveDigitNumber(int number)
{
    bool result = false;
    int point = 1;
    while (number / 10 != 0)
    {
        if (point > 5) break;
        number = number / 10;
        point++;

    }

    if (point == 5) result = true;
    return result;

}

//метод перевода числа в массив
int[] NumberInMassive(int number)
{
    int[] array = { 0, 0, 0, 0, 0 };
    int point = 4;
    int digit = 0;
    while (point >= 0)
    {
        digit = number % 10;
        number = number / 10;
        array[point] = digit;
        point--;
    }
    return array;
}

//метод вывода массива в консоль
void ShowMassive(int[] massive)
{
    for (int i = 0; i < 5; i++)
    {
        Console.Write(massive[i]);
    }
}

//метод проверяет: является ли число палиндромом 
void PalindromCheck(int[] massive)
{
    if ((massive[0] == massive[4]) & (massive[1] == massive[3])) 
    {
        Console.WriteLine("Число - палиндром");

    }
    else
    {
        Console.WriteLine("Число -  не палиндром");
    }
    
}

Console.Write("Введите число - ");
int newNumber = Convert.ToInt32(Console.ReadLine());

CheckFiveDigitNumber(newNumber);

if (CheckFiveDigitNumber(newNumber) == false)
{
    Console.WriteLine("Число не пятизначное!");
}
else
{
    int[] newMassive = NumberInMassive(newNumber);
    ShowMassive(newMassive);
    Console.WriteLine();
    PalindromCheck(newMassive);
}
