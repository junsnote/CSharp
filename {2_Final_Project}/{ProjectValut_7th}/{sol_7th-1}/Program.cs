// Program 클래스의 객체(ob) 선언
Program ob = new Program();

ThereIsFire FireCall;   
ThereIsFire call = new ThereIsFire(ob.Call119);	// ThereIsFire 델리게이트의 인스턴스 call 생성
ThereIsFire shout = new ThereIsFire(ob.ShoutOut);		// ThereIsFire 델리게이트의 인스턴스 shout 생성
ThereIsFire escape = new ThereIsFire(ob.Escape);    // ThereIsFire 델리게이트의 인스턴스 escape 생성

// call, shout, escape 인스턴스가 동시에 참조될 수 있도록
// FireCall 인스턴스에 + 연산자를 이용하여 결합한다.
FireCall = call + shout + escape;
FireCall("우리 집");

// FireCall 인스턴스에 - 연산자를 이용하여 shout 인스턴스를 뺀다.
FireCall -= shout;

FireCall("옆집");

delegate void ThereIsFire(string location);
partial class Program
{
	void Call119(string location)
	{
		Console.WriteLine($"소방서죠? 불났어요! 주소는 {location}");
	}
	void ShoutOut(string location)
	{
		Console.WriteLine($"피하세요!  {location}에 불이 났어요!");
	}
	void Escape(string location)
	{
		Console.WriteLine($"{location}에서 빨리 나갑시다!");
	}
}
