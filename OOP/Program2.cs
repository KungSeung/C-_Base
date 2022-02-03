using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
	// OOP를 대표하는 3대 속성 : 상속성, 은닉성, 다형성

	// 은닉성
	// 은닉성 -> 보안레벨에 대해 다룸 -> 협업과 관련이 있다
	// 은닉 o -> 얘는 기능 유추도 될 뿐더러 편하게 어느정도 사용가능
	// 은닉 x -> 얘는 신중히 써야하는 기능

	class Player2
	{
		// 접근지시 제어자
		// public protected private
		// public : 누구나 공유가능
		// protected : 상속받은 애만 사용가능
		// private : 클래스 내부에서만 사용가능, class경우 기본적으로 private으로 선언된다

		private int hp;

		// 왜 굳이 함수를 만들어서 hp값을 집어넣는지 
		// 나중에 코드가 비대해지면 public으로 했을 경우 hp값을 설정할 때마다 어디서 수정했는지 찾기 어려움
		// 근데 함수로 Set을 해주면 this.hp = hp; 에 중단점을 걸어놓고 어디서 값을 설정해줬는지 쉽게 알 수 있다
		public void SetUp(int hp)
		{
			this.hp = hp;
		}

		public void SecretFunction()
		{

		}
	}

	class Knight2 : Player2
	{

	}

	class Mage2 : Player2
	{
		public int mp;
	}

	class Program2
	{
		static void EnterGame(Player2 player)   // player(부모) 타입으로 입력받을 수 있음
		{
			// is 
			bool isMage = (player is Mage2);  // is : true / false 값 반환
			if (isMage)
			{
				Mage2 mage = (Mage2)player;
				mage.mp = 10;
			}

			// as가 깔끔해서 사용하길 추천
			// null -> 아무것도 가르키는게 '없음'
			/*	Mage mage = player as Mage;   // as : 하향casting -> 실패하면 null이 들어감
				if (mage != null)
				{
					mage.mp = 10;
				}*/
		}

		/*static void Main(string[] args)
		{
			Knight2 knight = new Knight2(); // knight라는 변수는 stack, 참조하는 것은 Heap의 Knight Class
			knight.SetUp(100);

			Mage2 mage = new Mage2();

			// Mage 타입 -> Player 타입 변환 가능[자식 -> 부모]
			Player2 magePlayer = mage;
			// Player -> Mage 타입 변환 불가능[부모 -> 자식]
			// 1. Mage만이 갖고있는 멤버변수나 함수를 가지고 있지 않음
			// 2. Player가 Knight나 다른 class에서 변환된 것일 수도 있음
			Mage2 mage2 = (Mage2)magePlayer;    // 정 변환하고 싶으면 명시적 변환 필요
			// 만약 타입이 안 맞아도 문법적으로 맞기 때문에 멤버변수나 함수에 접근가능
			// 실행해보지 않으면 오류를 알 수 없다 -> 상당히 위험한 코드가 된다
			// if문으로 검사필요

			EnterGame(knight);

		}*/
	}
}
