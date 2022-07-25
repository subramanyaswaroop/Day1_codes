// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter Principal amount");
double principal=double.Parse(Console.ReadLine());
Console.WriteLine("Enter rate of interest ");
double rate=double.Parse(Console.ReadLine());
Console.WriteLine("Enter Time in days ");
double time = double.Parse(Console.ReadLine());
double Simple_interest = principal * time * rate / 100;
Console.WriteLine($"Simple Interest is {Simple_interest} Rs");



