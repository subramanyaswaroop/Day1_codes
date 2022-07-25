// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a Number");
int a= int.Parse(Console.ReadLine());
if (a % 2 == 0)
{
    Console.WriteLine($"{a}  is even");
}
else {
    Console.WriteLine($"{a}  is odd");
}
