int[] a = {345, 897, 568, 234};
int b = 0;
for (int i = 0; i < 4; i++)
{
    if (a[i] % 2 == 0)
    {
        b++;
    }
}
Console.WriteLine(b);