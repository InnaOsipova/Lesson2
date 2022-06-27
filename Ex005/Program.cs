//Напишите программу, которая принимает на вход число 
//и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("Введите число");
double num = Convert.ToDouble(Console.ReadLine());

void Function (double str)
{
    if ((str % 7 == 0) && ( str % 23 == 0))
    {
        Console.WriteLine("Является кратным");
    }
    else
    {
        Console.WriteLine(" НЕ является кратным");
    }
}

Function(num);
