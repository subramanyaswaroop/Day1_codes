Console.WriteLine("enter a number");
int n= int.Parse(Console.ReadLine());
int rev=0;
int rem;
int i = 0;
while (n!=0)
{
    rem = n % 10;
    rev = rev * 10 + rem;
    n = n / 10;

}
Console.WriteLine("Reverse ->" + rev);
