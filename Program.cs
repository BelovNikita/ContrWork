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

int m = 4;
int n = 0;

for (int i = 0; i < a.Count(); i++)
{
    if (a[i].Length < m)
    {
        n++;
    }
}

string[] b = new string[n];

int j = 0;

for (int i = 0; i < a.Count(); i++)
{
    if (a[i].Length < m)
    {
        b[j] = a[i];

        j++;
    }
}