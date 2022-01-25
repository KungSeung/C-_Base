using System;
using System.Collections.Generic;
using System.Text;

namespace DataSturcture
{
	class Map
	{
		int[,] tiles =
		{
			{1,1,1,1,1 },
			{1,0,0,0,1 },
			{1,0,0,0,1 },
			{1,0,0,0,1 },
			{1,1,1,1,1 },
		};

		public void Render()
		{
			var defaultColor = Console.ForegroundColor;		// var를 ConsoleColor로 바꿔줘도 상관없음

			for(int y = 0; y < tiles.GetLength(1); y++)
			{
				for (int x = 0; x < tiles.GetLength(0); x++)
				{
					if (tiles[y, x] == 1)
						Console.ForegroundColor = ConsoleColor.Red;
					else
						Console.ForegroundColor = ConsoleColor.Green;

					Console.Write('\u25cf');
				}
				Console.WriteLine();
			}

			Console.ForegroundColor = defaultColor;
		}
	}
	class Program3
	{
		/*static void Main(string[] args)
		{
			int[,] arr = { { 1, 2, 3 }, { 1, 2, 3 } };              // 2차원 배열

			Map map = new Map();
			map.Render();

			int[][] a = new int[3][];       // 가변배열 - 많이 쓰진 않는다
			a[0] = new int[3];
			a[1] = new int[6];
			a[2] = new int[2];
		}*/
	}
}
