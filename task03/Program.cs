
void RandArray()
{
    int[] arr = new int [8];

    for (int i=0; i<arr.Length; i++)
    {
        arr[i] = new Random{}.Next(0,20);
    }

    Console.WriteLine($"[{String.Join(", ", arr)}]");
}

RandArray();