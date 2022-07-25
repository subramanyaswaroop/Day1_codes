// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter value of a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter value of b");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"value of a is{a} value of b is {b}");
int temp;
temp = a;
a = b;
b = temp;
Console.WriteLine($"value of a is{a} value of b is {b}");


