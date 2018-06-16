using System;
using System.Linq;

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

    unsafe public static double Sum(double* x, int n)
    {
        double sum = 0;
        for (var i = 0; i < n; i++)
        {
            sum += x[i];
        }
        return sum;
    }

    unsafe public static double Sum2(double* x, int n)
    {
        var span = new Span<double>(x, n);
        return span.ToArray().Sum();
    }
}
