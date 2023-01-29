// Print the maximum of two numbers

Console.WriteLine("Enter the first number:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number:");
int b = int.Parse(Console.ReadLine());

int max = 0;

if (a == b)
    Console.WriteLine("Numbers are equal: " + a + " and " + b);
else
{
    if (a > b) max = a;
    else max = b;
    Console.WriteLine("The maximum number is " + max);
}