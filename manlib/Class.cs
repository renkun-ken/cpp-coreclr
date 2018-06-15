using System;

public class ManLib
{
    public static string Bootstrap()
    {
        return "Bootstrap!";
    }

    public static double Plus(double x, double y)
    {
        return x + y;
    }

    public unsafe static double Sum(double* x, int n)
    {
        double sum = 0;
        for (var i = 0; i < n; i++)
        {
            sum += x[i];
        }
        return sum;
    }
}
