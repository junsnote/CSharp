// 스레드 인스턴스를 생성한다. ThreadStart 델리게이트의 인자인 스레드 메서드
// 이름은 DoSomething 이다.

Thread t1 = new Thread(new ThreadStart(DoSomething));
Console.WriteLine("Starting thread ...");
t1.Start();

for (int i = 0; i < 5; i++)
{
	Console.WriteLine($"Main : {i}");
	Thread.Sleep(50);
}
Console.WriteLine("Waiting until thread stops...");
t1.Join();

Console.WriteLine("Finished");

partial class Program
{
	static void DoSomething()
	{
		for (int i = 0; i < 5; i++)
		{
			Console.WriteLine($"DoSomething : {i}");
			Thread.Sleep(50);
		}
	}
}