// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter value of n");
int n = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 1; i < n; i=i+2)
{
    sum += i;
}
Console.WriteLine($"sum is {sum}");
