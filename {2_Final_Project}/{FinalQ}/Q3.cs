/*using FinalQ2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalQ2
{
	class Dogs
	{
		private int age;
		public Dogs()
		{
			age = 0;
		}
		public Dogs(int _age)
		{
			age = _age;
		}
		public int Age
		{
			get { return age; }
			set { age = value; }
		}

		// 나이를 출력하는 함수
		public void Print_Age()
		{
			Console.WriteLine($"나이 : {age}");
		}
	}
}

class MainApp
{
	static void Main(string[] args)
	{
		Dogs toto = new Dogs(5);
		Dogs chi = new Dogs();

		// 프로퍼티를 이용하여 chi의 age 필드에 5를 할당한다.
		chi.Age = 5;

		// 프로퍼티를 이용하여 객체 toto의 나이를 출력한다.
		Console.WriteLine($"나이 : {toto.Age}");

		// 객체 chi의 나이를 Print_Age() 메서드를 이용하여 출력한다.
		chi.Print_Age();
	}
}*/