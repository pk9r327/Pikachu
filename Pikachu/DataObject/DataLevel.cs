﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pikachu
{
	/// <summary>Đối tượng thể hiện dữ liệu cấp độ trò chơi.</summary>
	internal class DataLevel
	{
		public int level;
		public int totalTime;

		public static List<DataLevel> levelGames = new()
		{
			new() { level = 1, totalTime = 600 },
			new() { level = 2, totalTime = 550 },
			new() { level = 3, totalTime = 500 },
			new() { level = 4, totalTime = 450 },
		};

		public static DataLevel GetLevelGame(int index)
		{
			return levelGames[index];
		}
	}
}