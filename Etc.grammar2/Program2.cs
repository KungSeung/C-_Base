using System;
using System.Collections.Generic;
using System.Text;

namespace Etc.grammar2
{
	class TestException : Exception
	{

	}

	class Program2
	{
		/*static void Main(string[] args)
		{
			// 예외처리 -> 게임 쪽에서는 잘 안쓰는 경향이 있다
			// 네트워크 연결실패 같은 덜 중요한 상황에서 쓸 수 있음

			int a = 10;
			int b = 0;
			int result = a / b;

			try
			{
				// 1. 0으로 나눌 때
				// 2. 잘못된 메모리를 참조(null)
				// 3. 오버플로우

				throw new TestException();
			}
			catch (DivideByZeroException e)         // Exception은 최상위 조상, 얘를 거치면 다음 오류발견을 못함
			{

			}
			catch (Exception e)
			{

			}
			finally	// 무조건 실행되어야하는 부분 / DB, 파일 정리 등등
			{

			}
		}*/
	}
}
