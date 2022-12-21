using System.Text.RegularExpressions;
namespace pz_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream("C:/Users/Алдияр/Desktop/text.txt", FileMode.Open, FileAccess.Read);
            StreamReader read = new StreamReader(file);

            string str  = read.ReadToEnd();
            file.Close();
            string Pattern = @"([А-Я][а-я]+\s?[А-Я][а-я]+)\s[+7]";
            Regex regex = new Regex(Pattern);
            foreach (Match match in regex.Matches(str))
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}