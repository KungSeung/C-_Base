using System;

namespace Etc.grammar
{
	class MyList<T> 
	{
		// Generic 일반화, 타입을 자유자재로 넣을 수 있음
		// 타입을 여러개 추가할 수 있다 <T,K,J ...>
		// MyList<T> where T : class -> 무조건 T는 참조타입으로 받아야한다
		T[] arr = new T[10];

		public T GetItem(int i)
		{
			return arr[i];
		}

		static void Test<T>(int input)
		{
			// Test<int>(3); -> 이런식으로 사용가능
			// Test<float>(3.0f);
		}
	}

	class Monster
	{

	}

	class Program
	{
		/*static void Main(string[] args)
		{
			MyList<int> myIntList = new MyList<int>();
			int item = myIntList.GetItem(0);

			MyList<Monster> myMonsterList = new MyList<Monster>();
			
		}*/
	}
}
