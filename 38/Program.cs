int[] a = {3, 7, 22, 2, 78};
int min = a[0];
int max = a[0];
int b = 0;
for (int i = 1; i < 5; i++)
{
    if (a[i-1] < a[i])
    {
        max = a[i];
    }
    if (a[i-1] > a[i])
    {
        min = a[i];
    }
}
b = max - min;
Console.WriteLine(b);