internal class Program
{
    private static void Main(string[] args)
    {
        double x = 0.1;

        int n = 10;
        double h = 0.5;
        if (h < 0 || n <= 0)
        {
            Console.WriteLine("Недостаточно данных для выполнения задания.");
            return;
        }

        while (x <= 1 + h)
        {

            double y = Math.Sin(x);
            double s = 0; 
            int sign = -1;

            for (int i = 1; i <= n; i+=2)
            {
                double slag = Math.Pow(x, i) / Factorial(i);
                s += slag * sign;
                sign *= -1;
            }

            Console.WriteLine("| {0}\t| {1}\t| {2}\t|\n", Math.Round(x, 4), Math.Round(y, 4), Math.Round(s, 4));
            x += h;
        }
    }

    static double Factorial(int number)
    {
        if (number == 0)
            return 1;
        double result = 1;
        for (int i = 2; i <= number; i++)
            result *= i;
        return result;
    }
}
