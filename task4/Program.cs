// Print the maximum of three numbers

Console.WriteLine("Enter the first number:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the third number:");
int c = int.Parse(Console.ReadLine());

int max = 0;

if ((a == b) && (a == c))
    Console.WriteLine("Numbers are equal: " + a + ", " + b + " and " + c);
else
{
    max = a;
    if (b > max) max = b;
    if (c > max) max = c;
    Console.WriteLine("The maximum number is " + max);
}
