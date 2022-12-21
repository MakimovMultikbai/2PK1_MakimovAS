namespace pz__7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Введите длину массива");
            int x = int.Parse(Console.ReadLine());
            int[] mass1 = new int[x];
            int[] mass2 = new int[x];
            Console.WriteLine("Первый массив:");
            for (int i = 0; i < x; i++)
            {
                mass1[i] = rnd.Next(20, 100);
                Console.Write(mass1[i] + " ");
            }
            Console.WriteLine();
            int j = 0;
            for (int i = 0; i < mass1.Length; i++)
            {

                if (mass1[i] % 10 == 0)
                {
                    int a = mass1[i];

                    mass2[j] = a;
                    j++;
                }

            }
            Console.WriteLine("Второй массив:");
            for (int i = 0; i < mass2.Length; i++)
                if (mass2[i] == 0)
                {

                }
                else
                    Console.Write(mass2[i] + " ");
        }
    }
}