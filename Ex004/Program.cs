//Напишите программу, которая будет принимать на вход два
//числа и выводить, является ли второе число кратным первому. 
//Если второе число не кратно числу первому, то программа выводит
//остаток от деления.

Console.WriteLine("введите 1 число");
double first = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите 2 число");
double second = Convert.ToInt32(Console.ReadLine());

string Function (double num1, double num2)
{
    if(num2%num1 == 0)
    {
        return " второе число кратно первому";
    }
    else
    {
        return "остаток ="+ num2%num1;
    }
}

Console.WriteLine(Function(first, second));
