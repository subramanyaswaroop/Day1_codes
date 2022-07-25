
for (int i =  0; i <3; i++)
{
    Console.WriteLine("Enter name of student");
    string name = Console.ReadLine();
    Console.WriteLine("enter subject 1 score");
    int sub1=int.Parse(Console.ReadLine());
    Console.WriteLine("enter subject 2 score");
    int sub2=int.Parse(Console.ReadLine());
    Console.WriteLine("enter subject 3 score");
    int sub3=int.Parse(Console.ReadLine());
    int total= sub1 + sub2 +sub3;
    float avg = total / 3;
    if (sub1>=35 && sub2>=35 &sub3>=35 && avg>=60)
    {
        Console.WriteLine($"{name} has obtained first class");
    }
    else if (sub1 >= 35 && sub2 >= 35 & sub3 >= 35 && avg >= 50 &&avg<60)
    {
        Console.WriteLine($"{name} has obtained second class");
    }
    else if (sub1 >= 35 && sub2 >= 35 & sub3 >= 35 && avg >= 35 &&avg<50)
    {
        Console.WriteLine($"{name} has obtained third class");
    }
    else
    {
        Console.WriteLine($"{name} has failed");
    }



}
