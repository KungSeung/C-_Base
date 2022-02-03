using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Etc.grammar2
{
	class Important : System.Attribute
	{
		string message;

		public Important(string message) { this.message = message; }
	}

	class Monster
	{
		// hp입니다. 중요한 정보입니다.
		// 주석으로 넘긴걸 런타임에서 체크하는 기능 : Attribute
		[Important("Very Important")]
		public int hp;

		protected int attack;
		private float speed;

		void Attack()
		{

		}
	}
	class program3
	{
		/*static void Main(string[] args)
		{
			// Reflection : (Class)의 X-Ray를 찍는다고 생각
			// Reflection과 Attribute는 tool을 만들때 유용하다
			Monster monster = new Monster();
			// 필드에 있는 정보들을 가져올 수 있다
			Type type = monster.GetType();

			var fields = type.GetFields(System.Reflection.BindingFlags.Public
				| System.Reflection.BindingFlags.NonPublic
				| System.Reflection.BindingFlags.Static
				| System.Reflection.BindingFlags.Instance);

			foreach (FieldInfo field in fields)
			{
				string access = "protected";
				if (field.IsPublic)
					access = "public";
				else if (field.IsPrivate)
					access = "private";

				var attributes = field.GetCustomAttributes();

				Console.WriteLine($"{access} {field.FieldType.Name} {field.Name}");
			}

		}*/
	}
}
