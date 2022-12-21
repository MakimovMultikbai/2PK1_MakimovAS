namespace pz_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 1;
            double y = double.Parse(Console.ReadLine());
            double z = 0.0;
            while (x <= y)
            {
                z = z + (1 / x);
                x++;
            Console.WriteLine(z);
            }
        }
    }
}