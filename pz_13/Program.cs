namespace pz_13
{
    internal class Program
    {
        static int Factorial(int a)
        {
            int result = 1;
            if (a == 0)
            {
                result = 1;
            }
            if (a < 0)
            {
                result = -1;
            }
            else
            {
                for (int i = 1; i <= a; i++)
                {
                    result = result * i;
                }

            }
            return result;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(a));
        }
    }
}