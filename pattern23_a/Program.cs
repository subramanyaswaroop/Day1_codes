﻿Console.WriteLine("Enter a number");
int n = int.Parse(Console.ReadLine());
int val = 0;
for (int i = 0; i < n; i++)
{
    Console.WriteLine("");
    for (int j = 0; j < n; j++)
    {
        Console.Write("*");
    }
}
Console.WriteLine("");
Console.WriteLine("");
for (int i = 1; i < n; i++)
{
    Console.WriteLine("");
    for (int j = 0; j < n; j++)
    {
        Console.Write(i);
    }
}
Console.WriteLine("");
Console.WriteLine("");
for (int i = 0; i < n; i++)
{
    Console.WriteLine("");
    for (int j = 0; j < n; j++)
    {
        val += 1;
        Console.Write(val);
    }
    val = 0;
}


for (int i = 0; i < n; i++)
{
    Console.WriteLine("");
    for (int j = 0; j <=i; j++)
    {
        Console.Write("*");
    }

}