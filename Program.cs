string s = Console.ReadLine();
void Print(string[] arr)    
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

string[] a = s.Split(',');