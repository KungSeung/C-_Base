using System;
using System.Collections.Generic;
using System.Text;

namespace Etc.grammar
{
	abstract class Monster2	// 추상클래스
	{
		public abstract void Shout();
		// 추상함수는 본문이 존재하면 안됨
		// 추상클래스를 상속받은 애는 무조건 추상함수를 구현해야함(특정 시그니처) 
		// abstract -> override
		// 여러개의 클래스를  상속불가 -> 그래서 인터페이스 사용, 다른 클래스와 함꼐 상속가능
		// C#은 다중상속 x -> 죽음의 다이아몬드 문제가 발생
		// 이름이 같은 함수들이 겹쳐 어디에 접근해야될지 모름
	}
	interface iFlyable	
	{
		void Fly();	// Fly 함수를 반드시 구현해야하나 어떻게 구현할지는 마음대로
	}


	class Orc : Monster2
	{
		public override void Shout()
		{
			Console.WriteLine("록타르 오가르!");
		}
	}

	class FlyableOrc : Orc, iFlyable	// 인터페이스를 지니고 있으면 해당함수를 무조건 구현해줘야함
	{
		public void Fly()
		{
			throw new NotImplementedException();
		}
	}



	class Skeleton : Monster2
	{
		public override void Shout()
		{
			Console.WriteLine("꾸에에엑");
		}
	}

	class Program2
	{
		static void DoFly(iFlyable flyable)
		{
			flyable.Fly();
		}

		/*static void Main(string[] args)
		{
			//Monster2 monster = new Monster2(); // 추상클래스는 객체생성 불가능
			iFlyable orc = new FlyableOrc();
			DoFly(orc);
		}*/
	}
}
