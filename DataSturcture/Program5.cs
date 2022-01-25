using System;
using System.Collections.Generic;
using System.Text;

namespace DataSturcture
{
	class Monster2
	{
		public int id;
		public Monster2(int id) { this.id = id; }
	}
	class Program5
	{
		static void Main(string[] args)
		{
			// key -> value : Dictionary
			// key값을 알면 value를 굉장히 빠르게 찾을 수 있다, 반대는 성립x
			// Hashtable 기법이 사용됨
			// 박스를 여러개로 쪼개 놓는다. [ 1~10 ] [ 11~20 ] [ ] ... 1만개의 박스를 1천개로 쪼갬
			// key = 7777라면 777번째 박스에 있다는걸 알 수 있음
			// 메모리의 손해가 크지만, 성능을 취한다
			Dictionary<int, Monster2> dic = new Dictionary<int, Monster2>();
			for (int i = 0; i < 10000; i++)
			{
				dic.Add(i, new Monster2(i));
			}
			Monster2 mon;
			bool found = dic.TryGetValue(20000, out mon);

			dic.Remove(7777);
			dic.Clear();
		}
	}
}
