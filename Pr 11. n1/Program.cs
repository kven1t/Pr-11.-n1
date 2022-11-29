using System.Numerics;

namespace Pr_11._n1
{
    internal class Program
    {
        static int fact(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * fact(n - 1);
        }
        static void Main(string[] args)
        {
            double s = 0, x = 0.7;
            int n = 1;
            do
            {
                x = (Math.Pow(x , 2 * n)) /fact(2 * n);
                s += x;
                n++;
            }
            while (Math.Abs(x) > 0.0001);
            Console.WriteLine("Сумма: " + s);
        }
    }
}