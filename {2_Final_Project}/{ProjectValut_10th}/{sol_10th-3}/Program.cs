#define GOOGLE
using System;
using System.Diagnostics;	// 애트리뷰트를 사용할 수 있는 네임 스페이스

MyClass obj = new MyClass();

// OldMethod() 메서드 호출
obj.OldMethod();

// NewMethod() 메서드 호출
obj.NewMethod();

// GoogleMethod() 메서드 호출
Program.GoogleMethod();

// MicrosoftMethod() 메서드 호출
Program.MicrosoftMethod();

class MyClass
{
	// OldMethod를 사용하면 경고 메시지를 출력하는 애트리뷰트
	[Obsolete("Old MethodNew는 폐기되었습니다. Method를 이용하십시오.")]
	public void OldMethod()
	{
		Console.WriteLine("Old Method");
	}
	public void NewMethod()
	{
		Console.WriteLine("New Method");
	}
}

partial class Program
{
	// GOOGLE이 define되어 있으면 GoogleMethod() 실행
	[Conditional("GOOGLE")]
	public static void GoogleMethod()
	{
		Console.WriteLine("Conditional Attribute - Google Method");
	}

	// MICROSOFT 이 define 되어 있으면, MicrosoftMethod()를 실행
	[Conditional("MICROSOFT")]
	public static void MicrosoftMethod()
	{
		Console.WriteLine("Conditional Attribute - Microsoft Method");
	}
}