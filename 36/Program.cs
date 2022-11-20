int[] a = {3, 7, 23, 112};
int b = 0;
for (int i = 0; i < 3; i++)
{
    if (i % 2 == 0)
    {
        b = a[i] + b;
    }
}
Console.WriteLine(b);