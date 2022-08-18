Console.WriteLine("Enter a first number");
int number0 = int.Parse(Console.ReadLine());
int number1 = 0;
int number01 = 0;

while (number0 > 0)
{
int number2 = number0 % 10;
number0 = number0 / 10;
number01 = number2 / number2;
number1 = number1 + number01;
}


Console.WriteLine(number1);