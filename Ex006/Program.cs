

Console.WriteLine("Введите число1");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число2");
double num2 = Convert.ToDouble(Console.ReadLine());

void Function (double str1, double str2)
{
    if ( str1 == str2*str2)
    {
        Console.WriteLine(" первое число является кватратом второго");
    }
    else if (str2 == str1*str1)
    {
        Console.WriteLine("второе число является кватратом перового ");
    }
    else
    {
        Console.WriteLine("квадратов нет ");
    }
}

Function(num1, num2);
