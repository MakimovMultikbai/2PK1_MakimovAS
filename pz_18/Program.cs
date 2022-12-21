namespace pz_18
{
    internal class Program
    {
        public enum Seasons
        {
            winter = 1,
            spring = 2,
            summer = 3,
            autumn = 4
        }
        static void Main(string[] args)
        {
            string summ = "12.06 - день России\n 07.07 - Иван Купала\n 02.08 - Ильин день";
            string win = "09.12 - день героев Отечества\n 12.12 - день Конституции\n 23.02 - день защитников Отечества";
            string spr = "01.05 - день труда\n09.05 - день Победы\n28.05 - день пограничника";
            string aut = "01.09 - день знаний\n08.09 - день памяти жертв блокады\n04.11 - день народного единства";
            Console.WriteLine("Напишите номер времени года. Зима считается первым");
            try
            {
                int str = int.Parse(Console.ReadLine());
                switch (str)
                {
                    case (int)Seasons.winter:
                        {
                            Console.WriteLine(win);
                            break;
                        }
                    case (int)Seasons.spring:
                        {
                            Console.WriteLine(spr);
                            break;
                        }
                    case (int)Seasons.summer:
                        {
                            Console.WriteLine(summ);
                            break;
                        }
                    case (int)Seasons.autumn:
                        {
                            Console.WriteLine(aut);
                            break;
                        }
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Ошибка");
            }
        }
    }
}