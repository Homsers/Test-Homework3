Console.WriteLine("Enter a number of array");
int number0 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter a two random numbers from less to more");
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());


void RandArray()
{
    if (number2<number1)
    {
        Console.WriteLine("Error.Please, enter a number from less to more");
    }
    else
    {
        int[] arr = new int [number0];

    for (int i=0; i<arr.Length; i++)
    {
        arr[i] = new Random{}.Next(number1,number2);
    }

    Console.WriteLine($"[{String.Join(", ", arr)}]");
    }
    
}

RandArray();