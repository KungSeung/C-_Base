using System;
using System.Collections.Generic;
using System.Text;

namespace Etc.grammar
{
	// 콜백함수
	// 1. 다른 함수의 인자로써 이용되는 함수
	// 2. 어떤 이벤트에 의해 호출되어지는 함수

	class Program4
	{
		// delegate(대리자) - 콜백 방식
		delegate int OnClicked();	
		// Onclicked는 void, int 같은 하나의 형식이 된다
		// delegate -> 형식은 형식인데, 함수 자체를 인자로 넘겨주는 그런 형식
		// 반환 : int 입력 : void 
		// OnClicked이 delegate 형식의 이름이다!
		// 메소드를 매개변수로 넘길 수 있다

		static void ButtonPressed(OnClicked clickedFunction)
		{
			// 함수를 호출();
			clickedFunction();
		}

		static int TestDelegate()
		{
			Console.WriteLine("Hello Delegate");
			return 0;
		}

		static int TestDelegate2()
		{
			Console.WriteLine("Hello Delegate 2");
			return 0;
		}

		static void OnInputTest()
		{
			Console.WriteLine("Input Received!");
		}

		static void Main(string[] args)
		{
			OnClicked clicked = new OnClicked(TestDelegate);
			clicked += TestDelegate2;               // 일어나야 할 일들을 쭉 체이닝을 할 수 있다

			ButtonPressed(clicked);
			// delegate의 치명적인 단점
			// ButtonPressed안에 있는 clickedFunction이 매우 중요해서 ButtonPressed가 호출됐을때만 호출되어야함
			// 근데 clicked를 만들었기 때문에 마음대로 호출이 가능해짐
			// 이걸 보완하기 위해서 delegate를 래핑하기 위한 Event라는 문법이 있음

			Program5 inputManager = new Program5();
			inputManager.InputKey += OnInputTest;

			while (true)
			{
				inputManager.Update();
			}

			// InputKey는 Event로 래핑해줘서 단독으로 선언못함
			// inputManager.InputKey();

		}
	}
}
