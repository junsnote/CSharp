MyDelegate CallBack;

// 익명 메서드 선언 1 ( 두 개의 매개변수를 더하는 함수 ) 
CallBack = delegate (int a, int b)
{
	return a + b;
};
Console.WriteLine(CallBack(5, 7));

// 익명 메서드 선언 2 ( 두 개의 매개변수를 빼는 함수 )
CallBack = delegate (int a, int b)
{
	return a - b;
};
Console.WriteLine(CallBack(9, 4));

// 익명 메서드에 필요한 델리게이트 선언
delegate int MyDelegate(int a, int b);