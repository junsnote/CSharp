/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalQ2
{
	class MainApp
	{
		public static void Move(int x, int y)
		{
			Console.WriteLine($"Move ({x}, {y})");
		}
		public static void Resize(int x, int y)
		{
			Console.WriteLine($"Resize ({x}, {y})");
		}

		// 위의 두 메서드를 사용할 수 있는 델리게이트 선언 (델리게이트 이름 : Action)
		public delegate void Action(int x, int y);

		static void Main()
		{
			Action action;
			// Move 메소드를 사용할 수 있는 델리게이트 인스턴스 action1 생성
			Action action1 = new Action(Move);
			// Resize 메소드를 사용할 수 있는 델리게이트 인스턴스 action2 생성
			Action action2 = new Action(Resize);

			// action1, action2 인스턴스가 동시에 참조될 수 있도록 인스턴스에
			// + 연산자를 이용하여 결합한다.
			action = action1 + action2;

			// action 델리게이트 인스턴스를 이용하여 두 메서드를 호출
			// (인자는 200, 300을 사용한다)
			action(200, 300);

		}
	}
}
*/