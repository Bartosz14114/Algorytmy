public static (int, int) WskażPowtórkę(double[] liczby)
{
    for (int i = 0; i <= liczby.Length - 3; i++)
    {
        for (int j = i + 1; j <= liczby.Length - 3; j++)
        {
            if (liczby[i] + liczby[i + 1] + liczby[i + 2] == liczby[j] + liczby[j + 1] + liczby[j + 2])
            {
                return (i, j);
            }
        }
    }
    return (-1, -1);
}