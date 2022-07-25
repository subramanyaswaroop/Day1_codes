Console.WriteLine("enter a number");
int n=int.Parse(Console.ReadLine());
int val = 0;
int value = 1;

Console.WriteLine("");
Console.WriteLine("");for (int i = 0; i < n; i++)
{
    Console.WriteLine("");
    for (int j = 0; j <=i; j++)
    {
        val += 1;
        Console.Write(val);
    }
    val = 0;
}
for (int i = 1; i < n; i++)
{
    Console.WriteLine("");
    for (int j = 1; j <= i; j++)
    {
        Console.Write(i);
    }
}
Console.WriteLine("");
Console.WriteLine("");
for (int i = 0; i < n; i++)
{
    Console.WriteLine("");
    for (int j = 0; j <= i; j++)
    {
        val += 1;
        Console.Write(val);
    }
    
}
Console.WriteLine("");

