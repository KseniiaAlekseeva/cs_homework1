// Print all even numbers in range [1,N]

Console.WriteLine("Enter the number:");
int num = int.Parse(Console.ReadLine());
int currnum = 2;

if (num < 2) Console.WriteLine("Number " + num + " < 2. There are no even numbers in range [1,N].");
else
{
    Console.WriteLine("Even numbers in range [1," + num + "]:");
    while (currnum <= num)
    {
        Console.Write(currnum + ", ");
        currnum += 2;
    }
}