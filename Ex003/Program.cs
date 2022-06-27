//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int Number ()
{
    int num = new Random().Next(100,1000);
    int first = num/100;
    int third = num%10;
    int num1 = first*10 + third;
    Console.WriteLine(num+"->");

    return(num1);
}

Console.WriteLine(Number());