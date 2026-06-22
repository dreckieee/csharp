public class StatCalculator
{
    public int Calculate (int a, int b)
    {
        return (a + b);
    }
    public double Calculate (double a, double b)
    {
        return (a + b);
    }
    public double Calculate (int[] a)
    {
        double sum = 0D;
        for (int x = 0; x < a.Length; x++)
        {
            sum += a[x];
        }
        sum /= a.Length;
        return sum;
    }
}