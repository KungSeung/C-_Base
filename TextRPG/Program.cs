using System;

namespace TextRPG
{
	class Program
	{
		// 메소드 호출 -> Inception
		// 현실 -> 1차 꿈 -> 2차 꿈
		// 디버깅해서 호출스택 확인가능
		// 중단점 드래그해서 움직일 수 있음
		static void Print(int value)
		{
			Console.WriteLine(value);
		}
		static int AddAndPrint(int a, int b)
		{
			int ret = a + b;
			Print(ret);
			return ret;
		}

		/*static void Main(string[] args)
		{
			// 디버깅 단축키 F9
			int ret = AddAndPrint(10, 20);
			
		}*/
	}
}
