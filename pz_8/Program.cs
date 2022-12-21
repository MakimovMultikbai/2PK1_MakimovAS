namespace pz_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 7;
            double c = 1;
            double[,] mass = new double[a, b];
            Random rnd = new Random();
            double n = 0;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    n = rnd.NextDouble();
                    mass[i, j] = Math.Round(n, 1);
                    Console.Write(mass[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < a; i++)
            {
                c *= mass[i, 4];
            }
            Console.WriteLine(c);
        }
    }
}