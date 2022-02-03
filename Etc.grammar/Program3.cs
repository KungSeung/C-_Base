using System;
using System.Collections.Generic;
using System.Text;

namespace Etc.grammar
{
	// 객체지향 -> 은닉성
	// 은닉성의 특징
	// 멤버변수 protected, 멤버함수에서 get, set
	class Knight
	{
		protected int hp;

		// 프로퍼티 - get, set
		// 편함, 은닉성도 가지고 있음
		public int Hp	
		{
			get { return hp; }
			set { hp = value;  }	// private을 앞에 붙이면 외부에서 수정불가
		}

		public int _Hp { get; set; }
		// 자동완성 프로퍼티
		// 위에 구현한 Hp 프로퍼티와 똑같은 의미를 가짐
		// 심지어 hp를 선언안해도되는 장점이있음
		// 컴파일러가 겹치치않는 변수를 하나 만들어서 알아서 get, set해줌


	}
	class Program3
	{
		/*static void Main(string[] args)
		{
			// 프로퍼티	
			Knight knight = new Knight();
			knight.Hp = 100;
			int hp = knight.Hp;
		}*/
	}
}
