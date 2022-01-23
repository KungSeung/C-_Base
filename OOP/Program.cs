using System;

namespace OOP
{
	// 객체 OOP : Object Oriented Programming

	// 상속 
	class Player    // 부모 또는 기반 클래스
	{
		//필드
		static public int counter = 0;  // 오로지 1개만 존재!, 각 개체들이 공유하는 값
		public int id;
		public int hp;
		public int attack;

		public Player() // 자식이 호출되면 부모가 먼저 호출되는지 확인해보기
		{
			Console.WriteLine("Player 생성자 호출");
		}

		public Player(int hp)
		{
			this.hp = hp;
			Console.WriteLine("Player hp 생성자 호출");
		}

		public void Move()  // 당연히 함수도 상속이 된다
		{
			Console.WriteLine("Knight Move");
		}

		public void Attack()
		{
			Console.WriteLine("Knight Attack");
		}

		class RealMage : Player     // 자식 또는 파생 클래스
		{

		}

		class Archer : Player
		{

		}






		// Knight
		// 속성(멤버변수) : hp, attack ...
		// 기능(멤버함수) : Move, Attack ...

		// Ref 참조
		class Knight : Player
		{


			// static o -> class 자체에 종속적 -> 객체를 생성하지 않아도 바로 사용가능
			// static은 해당 class의 멤버변수나 멤버함수 접근 불가능 
			// Why? -> 공유하는 값인데 어느 객체에서 값에 접근한다? -> 말이 안됨
			// 다만, 접근하고자 한다면 아래 코드와 같이 무조건 인스턴스를 생성해줘야됨
			// static x -> 인스턴스에 종속적 -> 객체를 생성해야만 사용가능
			static public void Test()
			{
				counter++;
			}

			static public Knight CreateKnight()
			{
				Knight knight = new Knight();
				knight.hp = 100;
				knight.attack = 10;
				return knight;
			}

			// 생성자
			// 1. class 이름이랑 무조건 같아야함
			// 2. 반환 타입 입력하면 안됨
			public Knight() : base(100)     // Player hp를 생성하고 싶으면 base 사용
			{
				hp = 100;
				attack = 10;
				base.hp = 100;  // 부모님 변수에 접근
				Console.WriteLine("Knight 생성자 호출!");
			}

			public Knight(int hp) : this()  // this() : Knight(int hp)를 호출할 때, 빈 생성자도 호출 바람
			{
				this.hp = hp;   // this : 내 hp를 전달받은 hp로 입력
				Console.WriteLine("int 생성자 호출");
			}

			public Knight(int hp, int attack)
			{
				this.hp = hp;
				this.attack = attack;
				Console.WriteLine("int int 생성자 호출");
			}

			public Knight Clone()
			{
				Knight knight = new Knight();
				knight.hp = hp;
				knight.attack = attack;
				return knight;
			}


		}

		// 값 복사
		struct Mage
		{
			// struct는 내부에서 이니셜라이즈가 안됨
			public int hp;
			public int attack;
		}


		class Program
		{
			static void KillMage(Mage mage)
			{
				mage.hp = 0;
			}

			static void KillKnight(Knight knight)
			{
				knight.hp = 0;
			}

			static void Main(string[] args)
			{
				Knight knight = new Knight(50, 5);

				Knight knight2 = Knight.CreateKnight(); // static 함수
				knight2.Move(); // 일반 함수


				/*Mage mage;
				mage.hp = 100;
				mage.attack = 50;
				KillMage(mage);

				Knight knight = new Knight();   //class 생성
				knight.hp = 100;
				knight.attack = 10;

				Knight knight2 = knight.Clone();
				knight2.hp = 0;*/

				// 참조할 때 넘겨주는 주소 값의 길이는 OS의 버젼에 따른다 -> 64-bit, 32-bit
				// C#은 Heap에서 할당해주고 해제를 안해줘도 가르키는 애가 사라지면 알아서 사라짐
				// 이 부분이 C++보다 편한 이유

				// 그리고 참조를 한다고 해서 무조건 Heap을 가르키는건 아니다
				// 함수를 참조값으로 넘겨줄 경우 -> stack에 있는 주소를 가르키게 된다


			}
		}

	}
}
