int[] array= new int[3];
for (int i = 0; i < 3; i++)
{
   Console.WriteLine($"enter {i} number"); 
    array[i] = int.Parse(Console.ReadLine());


}
Console.WriteLine(array);
Array.Sort(array);
Array.Reverse(array);
Console.WriteLine($"Largest number is {array[0]} ");
Console.WriteLine($"Second Largest number is {array[1]} ");