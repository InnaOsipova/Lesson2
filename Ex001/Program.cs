﻿int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 >result) result = arg2;
    if(arg3 >result) result = arg3;
    return result;
}

int a1 = 5;
int b1 = 10;
int c1 = 130;
int a2 = 8;
int b2 = 88;
int c2 = 444;
int a3 = 5;
int b3 = 1000;
int c3 = 17;

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));


Console.Write(" максимум :");
Console.Write(max);