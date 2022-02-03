using System;
using System.Collections.Generic;
using System.Text;

namespace Etc.grammar
{
	
	class Program5
	{
		// event
		// 접근 지시 제어자를 맞춰줘야함
		public delegate void OnInputKey();
		public event OnInputKey InputKey;

		public void Update()
		{
			if (Console.KeyAvailable == false)	// 입력이 없음
				return;

			ConsoleKeyInfo info = Console.ReadKey();
			if(info.Key == ConsoleKey.A)
			{
				// 모두한테 A를 입력했다는걸 알려준다!
				InputKey();
			}
		}
		static void Main(string[] args)
		{
			
		}
	}
}
