using System;
using System.Collections.Generic;
using System.Text;

namespace Etc.grammar2
{
	class Monster2
	{

	}

	class Monster3 
	{ 
		public int Id { get; set; }
	}

	class Program4
	{
		static int Find()
		{

			return 0;
		}

		static void Main(string[] args)
		{
			// Nullable -> Null + able
			// ?를 붙이면 Null도 들어갈 수 있다
			// DB에서 가끔씩 사용하고 자주 사용되진 않는다
			int? number = null;

			int b = number ?? 0;    // null이 아니면 number, null이면 0을 넣는다
			Console.WriteLine(b);

			Monster3 monster = null;

			if (monster != null)
			{
				int monsterId = monster.Id;
			}
			int? id = monster?.Id;

			// ref 참조 -> 원본 값을 변경하고 싶을떄
			// ref값에 값을 안 넘겨줘도 경고메시지가 뜨지 않음
			// out 도 참조를 함
			// 값을 여러개 반환하고싶음, 반드시 반환해야하는 값 앞에 out 명시 
		}
	}
}
