Console.WriteLine("Enter a number of array");
int number0 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter a two random numbers");
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());

void RandArray()
{
    int[] arr = new int [number0];

    for (int i=0; i<arr.Length; i++)
    {
        arr[i] = new Random{}.Next(number1,number2);
    }

    Console.WriteLine($"[{String.Join(", ", arr)}]");
}

RandArray();