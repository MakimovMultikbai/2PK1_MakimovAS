namespace pz_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Введите число строк массива:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите минимальное количество элементов в строчке массива:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите максимальное количество элементов в строчке массива:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine();



            Console.WriteLine("Массив: ");
            double[][] mass = new double[a][];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = new double[rnd.Next(x, y)];
            }
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass[i].Length; j++)
                {
                    mass[i][j] = rnd.Next(10, 100) + Math.Round(rnd.NextDouble(), 2);
                    Console.Write(mass[i][j] + "   ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();



            Console.WriteLine("Последний элемент из каждой строки: ");
            double[] end = new double[mass.Length];
            for (int i = 0; i < end.Length; i++)
            {
                end[i] = mass[i][^1];
                Console.Write(end[i] + "   ");
            }
            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("Максимальное значение в каждой строке: ");
            double[] max = new double[a];
            double z;
            for (int i = 0; i < mass.Length; i++)
            {
                z = mass[i][0];
                for (int j = 1; j < mass[i].Length; j++)
                {
                    if (mass[i][j] > z)
                        z = mass[i][j];

                }
                max[i] = z;
                Console.Write(max[i] + "   ");
            }
            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("Массив с изменёнными значениями: ");
            double d;
            for (int i = 0; i < mass.Length; i++)
            {
                d = mass[i][0];

                for (int j = 0; j < mass[i].Length; j++)
                {
                    if (mass[i][j] == max[i])
                    {
                        mass[i][j] = d;
                    }
                }
                mass[i][0] = max[i];
            }
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass[i].Length; j++)
                {
                    Console.Write(mass[i][j] + "   ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("Реверснутый массив: ");
            for (int i = 0; i < a; i++)
            {
                Array.Reverse(mass[i]);
            }
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass[i].Length; j++)
                {
                    Console.Write(mass[i][j] + "   ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("Среднее значение каждой строки: ");
            double e = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass[i].Length; j++)
                {
                    e += mass[i][j];
                }
                Console.Write(e / mass[i].Length + "   ");
                e = 0;
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}