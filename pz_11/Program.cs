namespace pz_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "пРИВЕТ. КАК               делА";
            string[] Array = text.Split(". ");
            string stroka1 = "";
            string[] mass = new string[Array.Length];
            string result = "";
            for (int i = 0; i < Array.Length; i++)
            {
                string stroka = Array[i].ToLower();
                char[] chars = stroka.ToCharArray();
                stroka1 = Convert.ToString(char.ToUpper(chars[0]));
                for (int j = 1; j < chars.Length; j++)
                {
                    stroka1 += chars[j];
                }
                stroka1 = stroka1.Replace("  ", "");
                result += stroka1.Trim() + ". ";
            }
            Console.WriteLine(result);
        }
    }
}