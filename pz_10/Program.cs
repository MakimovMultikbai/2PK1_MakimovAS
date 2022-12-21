namespace pz_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            int max = 0;
            string str1 = "";
            Console.WriteLine("бесконечный ввод строки:    Введите слово stop для выхода из цикла. \n");
            while (true)
            {
                str = Console.ReadLine();
                if (str == "stop")
                {
                    break;
                }
                else
                {
                    if (str.Length>max)
                    {
                        max = str.Length;
                        str1 = str;
                    }
                }
            }
            Console.WriteLine("Первая самая длинная строка: " + str1);
        }
    }
}