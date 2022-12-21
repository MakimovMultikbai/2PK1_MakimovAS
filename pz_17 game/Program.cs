using System.Diagnostics;
namespace pz_17_game
{
	internal class Program
	{
		static int hero_hp = 30;
		static int hero_dmg = 5;
		static int enemy_hp = 15;
		static int enemy_dmg = 5;
		static int steps = 0;
		static int buffstep = 5;
		static int x = 12;
		static int y = 12;
		static string enemy = "E";
		static string aid = "A";
		static string hero = "P";
		static string buff = "B";
		static int kol = 10;
		static string[,] map = new string[25, 25];
		static Array GenerateMap()
		{

			Random rnd = new Random();
			map[x, y] = hero;
			for (int i = 0; i < 10; i++)
			{
				int height = rnd.Next(0, 25);
				int width = rnd.Next(0, 25);
				if (map[height, width] == ".")
				{
					map[height, width] = enemy;
				}
			}
			for (int i = 0; i < 5; i++)
			{
				int height = rnd.Next(0, 25);
				int width = rnd.Next(0, 25);
				if (map[height, width] == ".")
				{
					map[height, width] = aid;
				}
			}//спавн аптечки
			for (int i = 0; i < 3; i++)
			{
				int height = rnd.Next(0, 25);
				int width = rnd.Next(0, 25);
				if (map[height, width] == ".")
				{
					map[height, width] = buff;
				}
			}//спавн бафа
			Console.Clear();
			for (int i = 0; i < 25; i++)
			{
				for (int j = 0; j < 25; j++)
				{
					if (map[i, j] == enemy)
					{
						Console.ForegroundColor = ConsoleColor.Red;
					}
					if (map[i, j] == aid)
					{
						Console.ForegroundColor = ConsoleColor.Green;
					}
					if (map[i, j] == buff)
					{
						Console.ForegroundColor = ConsoleColor.Magenta;
					}
					if (map[i, j] == hero)
					{
						Console.ForegroundColor = ConsoleColor.DarkYellow;
					}
					if (map[i, j] == ".")
					{
						Console.ForegroundColor = ConsoleColor.White;
					}
					Console.Write(map[i, j] + " ");
				}
				Console.WriteLine();
			}//первый вывод в консоль
			return map;
		}
		static Array UpdateMap()
		{
			Console.Clear();
			map[x, y] = hero;
			for (int i = 0; i < 25; i++)
			{
				for (int j = 0; j < 25; j++)
				{
					if (map[i, j] == enemy)
					{
						Console.ForegroundColor = ConsoleColor.Red;
					}
					if (map[i, j] == aid)
					{
						Console.ForegroundColor = ConsoleColor.Green;
					}
					if (map[i, j] == buff)
					{
						Console.ForegroundColor = ConsoleColor.Magenta;
					}
					if (map[i, j] == hero)
					{
						Console.ForegroundColor = ConsoleColor.DarkYellow;
					}
					if (map[i, j] == ".")
					{
						Console.ForegroundColor = ConsoleColor.White;
					}

					Console.Write(map[i, j] + " ");

				}
				Console.WriteLine("");
			}
			return (map);
		}
		static Array MoveDirection()
		{

			ConsoleKeyInfo direction = Console.ReadKey();
			steps = steps + 1;
			buffstep = buffstep + 1;
			if (buffstep >= 5)
			{
				hero_dmg = 5;
			}

			switch (direction.Key)
			{
				case ConsoleKey.D:
					{

						y = y + 1;
						if (y > 24) y = 0;
						break;
					}
				case ConsoleKey.A:
					{
						y = y - 1;
						if (y < 0) y = 24;
						break;
					}
				case ConsoleKey.W:
					{
						x = x - 1;
						if (x < 0) x = 24;
						break;
					}
				case ConsoleKey.S:
					{
						x = x + 1;
						if (x > 24) x = 0;
						break;
					}
				case ConsoleKey.X:
					{
						map[x, y] = hero;
						Save();
						Process.GetCurrentProcess().Kill();
						break;
					}
				case ConsoleKey.L:
					{
						Load();
						break;
					}
			}
			return (map);
		}
		static Array Fight()
		{
			enemy_hp = 15;
			for (int i = 0; hero_hp != 0 & enemy_hp != 0; i++)
			{
				enemy_hp = enemy_hp - hero_dmg;
				if (enemy_hp <= 0)
				{
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("Вы убили врага");
					Console.ReadKey();
					break;
				}
				hero_hp = hero_hp - enemy_dmg;
				if (hero_hp == 0 | hero_hp < 0)
				{
					Console.Clear();
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Вы умерли");
					Console.ReadKey();
				}

			}
			kol = kol - 1;
			return (map);
		}
		static void Healing()
		{
			hero_hp = 30;
		}
		static void Buff()
		{
			buffstep = 0;
			hero_dmg = 10;
		}
		public static void Save()
		{
			using (FileStream stream = File.Open(@"C:\Users\Алдияр\Desktop\save.txt", FileMode.Create))
			{
				using (StreamWriter writer = new StreamWriter(stream))
				{
					writer.Write("hero_hp = " + hero_hp + "\n");
					for (int i = 0; i < 25; i++)
					{
						for (int j = 0; j < 25; j++)
						{
							writer.Write(map[i, j] + " ");
						}
						writer.WriteLine();
					}
				}
			}
		}
		static void Load()
		{
			Console.Clear();
			using (FileStream stream = File.Open(@"C:\Users\Алдияр\Desktop\save.txt", FileMode.Open))
			{
				using (StreamReader reader = new StreamReader(stream))
				{
					for (int j = 0; j < 25; j++)
					{
						String str = reader.ReadLine();
						for (int k = 0; k < 25; k++)
						{
							map[j, k] = Char.ToString(str[k]);
						}
					}
				}
			}
		}
		static void Main(string[] args)
		{

			for (int i = 0; i < 25; i++)
			{
				for (int j = 0; j < 25; j++)
				{
					map[i, j] = ".";
				}
				Console.WriteLine("");
			}
			GenerateMap();

			for (int i = 0; hero_hp > 0; i++)
			{
				if (kol > 0)
				{
					map[x, y] = ".";
					Console.ForegroundColor = ConsoleColor.Black;
					MoveDirection();
					if (map[x, y] == enemy)
					{
						Fight();
					}
					if (map[x, y] == aid)
					{
						Healing();
					}
					if (map[x, y] == buff)
					{
						Buff();
					}
					UpdateMap();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine(hero_hp);

					Console.WriteLine("общее количество шагов: " + steps);
					if (buffstep < 5)
					{
						Console.WriteLine("Осталось " + (5 - buffstep) + " шагов до конца баффа");
					}
				}

				if (kol <= 0)
				{
					Console.Clear();
					Console.WriteLine("Игра окончена за " + steps + " шагов. Вы выиграли");
					break;
				}
			}
		}
	}
}