Console.WriteLine("Enter a first number");
int number0 = int.Parse(Console.ReadLine());
int number1 = 0;


while (number0 > 0)
{
int number2 = number0 % 10;
number0 = number0 / 10;
number1 = number1 + number2;
}


Console.WriteLine(number1);