namespace pz_12
{
    internal class Program
    {
        static void Invert(int a, out int b)
        {
            string a1 = a.ToString();
            char[] chars = a1.ToCharArray();
            char[] chars1 = new char[chars.Length];
            for (int i = 0; i < a1.Length; i++)
            {
                chars1[i] = chars[a1.Length - 1 - i];
            }
            b = Convert.ToInt32(new String(chars1));
        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 1;
            Invert(a, out b);
            Console.WriteLine(b);           
        }
    }
}