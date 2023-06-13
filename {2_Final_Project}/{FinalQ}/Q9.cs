/*#define GOOGLE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace FinalQ2
{
	class MyClass
	{
		// OldMethod를 사용하면 경고 메시지를 출력하는 애트리뷰트
		[Obsolete("OldMethod는 폐기되었습니다. New Method를 이용하십시오.")]
		public void OldMethod()
		{
			Console.WriteLine("Old Method");
		}
		public void NewMethod()
		{
			Console.WriteLine("New Method");
		}
	}

	class MainApp
	{
		// GOOGLE이 define 되어 있으면 GoogleMethod()를 실행
		[Conditional("GOOGLE")]
		public static void GoogleMethod()
		{
			Console.WriteLine("Google Method");
		}
		// MICROSOFT이 define 되어 있으면 MicrosoftMethod()를 실행
		[Conditional("MICROSOFT")]
		public static void MicrosoftMethod()
		{
			Console.WriteLine("Microsoft Method");
		}

		static void Main(string[] strings)
		{
			MyClass obj = new MyClass();
			obj.OldMethod();
			obj.NewMethod();
			//MainApp.GoogleMethod();
			//MainApp.MicrosoftMethod();
			GoogleMethod();
			MicrosoftMethod();
		}
	}
}
*/