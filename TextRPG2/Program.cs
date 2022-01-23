using System;

namespace TextRPG2
{
	class Program
	{
		static void Main(string[] args)
		{
			Game game = new Game();

			while (true)
			{
				game.Process();
			}

			// namespace가 같다면 class를 다른 선언없이 부를 수 있다
			// 다르다면 Using을 사용해서 namespace를 호출해야됨
			/*Player player = new Knight();
			Player player2 = new Archer();
			Monster monster = new Orc();

			int damage = player.GetAttack();
			player2.OnDamaged(damage);*/
		}
	}
}
