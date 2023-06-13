/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FinalQ2
{
	class MainApp
	{
		static void Main(string[] args)
		{
			// 매개변수가 하나인 Func 버전을 구현. 10을 반환함
			Func<int> func1 = () => 10;
			// 매개변수가 하나인 무명 메서드 출력
			Console.WriteLine(func1());

			// 매개변수가 두 개인 Func 버전을 구현. 입력 변수 * 입력 변수를 반환함
			Func<int, int> func2 = (x) => x * x;
			// 매개변수가  두 개인 무명 서드 출력 (입력 변수는 5)
			Console.WriteLine(func2(5));

			// 매개변수가 세 개인 Func 버전을 구현. 입력변수1 / 입력변수2를 반환함
			Func<int, int, int> func3 = (x, y) => x / y;
			// 매개변수가  세 개인 무명 서드 출력 (입력 변수는 15, 4)
			Console.WriteLine(func3(15, 4));

			// 매개변수가 없는 Action 버전을 구현. 10을 출력함
			Action act1 = () => Console.WriteLine(10);
			// 매개변수가 없는 무명 메서드 실행
			act1();

			int result1 = 0;
			// 매개변수가 하나인 Action 버전을 구현. 입력 변수 * 입력변수를
			// result1에 저장
			Action<int> act2 = (x) => result1 = x * x;
			// 매개변수가 하나인 무명 메서드 실행 (입력 변수는 5)
			act2(5);
			Console.WriteLine(result1);

			double result2 = 0.0;
			// 매개변수가 두 개인 Action 버전을 구현. 입력 변수1 / 입력 변수 2를
			// result2 변수에 저장
			Action<double, double> act3 = (x, y) => result2 = x / y;
			// 매개변수가 하나인 무명 메서드 실행
			// (입력 변수는 15.0, 4.0)
			act3(15.0, 4.0);
			Console.WriteLine(result2);

		}
	}
}
*/