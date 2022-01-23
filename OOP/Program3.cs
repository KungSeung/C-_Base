using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
	// OOP를 대표하는 3대 속성 : 상속성, 은닉성, 다형성
	// 다형성 - virtual / override
	// 언제 사용? 똑같이 많이 사용하는데 조금씩 기능이 다를경우

	// 오버로딩 vs 오버라이딩
	// 오버로딩 : 함수 이름의 재사용
	// 오버라이딩 : 다형성 사용

	class Player3
	{
		protected int hp;
		protected int attack;

		public virtual void Move()
		{
			Console.WriteLine("Player3 이동!");
		}
	}

	class Knight3 : Player3
	{
		/*public new void Move()	// new를 사용해서 이런식으로도 사용할 수 있다
		{
			Console.WriteLine("Knight 이동!");
		}*/

		public override void Move()
		{
			base.Move();    // 부모님의 Move호출

			Console.WriteLine("Knight3 이동!");
		}
	}

	class SuperKnight3 : Knight3    // 이중상속
	{
		public sealed override void Move()      // C#에만 있는 문법 : sealed -> 상속받는 애들은 이 함수 사용불가
		{
			Console.WriteLine("SuperKnight3 이동!");
		}
	}

	class Mage3 : Player3
	{
		public int mp;

		public override void Move()
		{
			Console.WriteLine("Mage3 이동!");
		}
	}


	class Program3
	{
		static void EnterGame(Player3 player)   // player(부모) 타입으로 입력받을 수 있음
		{
			// 다형성 사용전 : player의 move 호출
			// 다형성 사용후 : mage의 move 호출
			player.Move();

			// as가 깔끔해서 사용하길 추천
			// null -> 아무것도 가르키는게 '없음'
			Mage3 mage = player as Mage3;   // as : casting가능하냐 못하냐
			if (mage != null)
			{
				mage.mp = 10;
			}
		}

		/*static void Main(string[] args)
		{
			Knight3 knight = new Knight3();
			Mage3 mage = new Mage3();


			knight.Move();
			mage.Move();

			EnterGame(mage);
		}*/

	}
}
