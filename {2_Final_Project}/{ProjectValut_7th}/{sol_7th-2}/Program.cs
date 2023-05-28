Market market = new Market();   // Market 클래스의 객체 market를 선언한다.

// market 객체의 CustomerEvent 이벤트에 MyHandler() 메서드를
// 이벤트 처리기로 등록한다.
market.CustomerEvent += new MyDelegate(MyHandler);

for (int no = 0; no < 100; no += 10)
{
	market.BuySomething(no);
}

delegate void MyDelegate(int no);
class Market
{
	// MyDelegate 델리게이트의 인스턴스 CustomerEvent를
	// event 한정자로 수식하여 이벤트 선언
	public event MyDelegate CustomerEvent;
	public void BuySomething(int CustomerNo)
	{
		// CustomerNo 가 30 일 때, 이벤트를 발생
		if (CustomerNo == 30)
		{
			CustomerEvent(CustomerNo);
		}
	}
}

partial class Program
{
	// 이벤트 처리기 (MyHandler)를 작성한다. 형식은 선언한 델리게이트와
	// 일치하는 메서드면 된다.
	static public void MyHandler(int CustomerNo)
	{
		Console.Write($"축하합니다. {CustomerNo} 번째 고객 이벤트에 당첨되셨습니다.");
	}
}