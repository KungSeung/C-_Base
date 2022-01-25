using System;
using System.Collections.Generic;
using System.Text;

namespace DataSturcture
{
	class Player
	{

	}
	class Monster
	{

	}

	class Program2
	{
		static int GetHighestScore(int[] scores)
		{
			int max = scores[0];
			foreach (int score in scores) {
				if (max < score)
					max = score;
			}
			return max;
		}

		static int GetAverageScore(int[] scores)
		{
			int Average = 0;
			foreach(int score in scores){ Average += score; }
			if (scores.Length == 0)
				return 0;
			return Average / scores.Length;
		}

		static int GetIndexOf(int[] scores, int value)
		{
			int index = 0;
			foreach(int score in scores){
				if (value == score){ return index; }
				index++;
			}
			return -1;
		}

		static void Sort(int[] scores)
		{
			// 정렬 : 오름차순
			int temp = 0;
			for(int i=0; i < scores.Length-1; i++)		// i : 0 1 2 3 / j : 1 2 3 4 
			{
				int min = scores[i];
				for(int j = i + 1; j < scores.Length; j++)		
				{
					if (min > scores[j])      
					{
						temp = scores[j];
						scores[j] = min;
						scores[i] = temp;
					}
				}
			}

			for(int i=0; i<scores.Length; i++)
			{
				// [i ~ scores.Length - 1] 제일 작은 숫자가 있는 index찾기
				int minIndex = i;
				for(int j = i; j < scores.Length; j++)
				{
					if (scores[j] < scores[minIndex])
						minIndex = j;
				}

				// swap
				int tmp = scores[i];
				scores[i] = scores[minIndex];
				scores[minIndex] = tmp;
			}

		}

		/*static void Main(string[] args)
		{
			int[] scores = new int[5] { 10, 30, 40, 20, 50 };
			Sort(scores);
			foreach(int score in scores)
			{
				Console.Write(score);
			}
		}*/
	}
}
