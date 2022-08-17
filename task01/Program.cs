Console.WriteLine("Enter a first number");
int number0 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter a second number");
int number1 = int.Parse(Console.ReadLine());

int A = number0;
int B = number1;

for (int i = 1; i < number1; i++)
{
number0 = number0 * A;
}
Console.WriteLine(number0);