string s = Console.ReadLine(); **Ввод строки**


void Print(string[] arr)     **Метод печати  массива**
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}



string[] a = s.Split(','); **Создание основного массива**




int m = 4;**Переменная ограничения количества символов в массиве**
int n = 0;**Переменная размера массива**




for (int i = 0; i < a.Count(); i++)**Узнаем размер нового массива**
{
    if (a[i].Length < m)
    {
        n++;
    }
}

string[] b = new string[n];**Создание итогового массива с нужными элементами**

int j = 0;

for (int i = 0; i < a.Count(); i++)
{
    if (a[i].Length < m)
    {
        b[j] = a[i];

        j++;
    }
}




Print(a);**Вывод массивов**
Print(b);
