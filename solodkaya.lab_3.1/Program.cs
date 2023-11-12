try
{
    Console.Write("Введите k:");
    int k = int.Parse(Console.ReadLine());
    double W = 1;

    for (int i = 1; i <= k; i++)
    {
        double fact = 1;
        for (int j = 1; j <= i; j++)
        {
            fact *= j;
        }

        W += Math.Pow(-1, i) * Math.Pow(i - 3, 2) / fact;
    }

    Console.WriteLine($"W={W:F2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
