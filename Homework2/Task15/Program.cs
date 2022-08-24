//Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

//модуль проверяет выходной день или нет
bool checkingTheWeekend(int dayOfWeek)
{
    bool weekend = false;
    if(dayOfWeek > 5) weekend = true;
    else weekend = false;
    return weekend;
}

Console.Write("Введите день недели - ");
int newDay = Convert.ToInt32(Console.ReadLine());
if ((newDay < 0) ^ (newDay > 7))
{
    Console.WriteLine("Такого дня недели нет");
}
else
{
    bool result = checkingTheWeekend(newDay);
    Console.WriteLine(result);
}

