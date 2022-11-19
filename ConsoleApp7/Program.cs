namespace ConsoleApp7
{
    internal class Program
    {
        static double Heron(double a)
        {
            if (a < 0) throw new ArgumentException("Liczba powinna być większa od zera");

            double x0;
            double x1 = 1.0;
            const double eps = 1e-6;

            do
            {
                x0 = x1;
                x1 = 0.5 * (x0 + a / x0);
            } while (Math.Abs(x1 -x0) > eps);

            return x1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę rzeczywistą");
            double a;

            if (double.TryParse(Console.ReadLine(), out a))
            {
                try
                {
                    double x = Heron(a);
                    Console.WriteLine("Pierwiastek z {0} wynosi {1}", a, x);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Złapałem wyjątek"); 
                }
            }
            else
            {
                Console.WriteLine("Zły format");
            }
        }
    }
}