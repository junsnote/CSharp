/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalQ2
{
	delegate void MyDelegate(int no);

	class Market
	{
		// MyDelegate 델리게이트의 인스턴스 CustomerEvent를
		// event 한정자로 수식하여 이벤트 선언
		public event MyDelegate CustomerEvent;
		public void BuySomething(int CustomerNo)
		{
			// CustomerNo 가 30일 때, 이벤트 발생
			if(CustomerNo == 30)
			{
				CustomerEvent(CustomerNo);
			}
		}
	}
	class MainApp
	{
		// 이벤트 처리기 (MyHandler)를 작성한다. 형식은 선언한 델리게이트와
		// 일치하는 메소드면 된다.
		static public void MyHandler(int no)
		{
			Console.WriteLine("축하합니다. {0} 번째 고객 이벤트에 당첨되었습니다.", no);
		}

		static void Main(string[] args)
		{
			// Market 클래스의 객체 market를 선언한다.
			Market market = new Market();
			// market객체의 CustomerEvent 이벤트에 MyHandler() 메소드를
			// 이벤트 처리기로 등록한다.
			market.CustomerEvent += new MyDelegate(MyHandler);

			for (int no = 0; no < 100; no += 10)
			{
				market.BuySomething(no);
			}
		}
	}
}
*/