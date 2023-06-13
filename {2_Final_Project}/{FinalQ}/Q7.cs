/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalQ2
{
	class Point
	{
		int x; int y;
		public Point(int x, int y)
		{
			this.x = x;
			this.y = y;	
		}

		public override string ToString()
		{
			return string.Format($"Point의 좌표 : ({x}, {y})");
		}

		public override bool Equals(object o)
		{
			if(!(o is Point)) return false;
			return (x == ((Point)o).x && y == ((Point)o).y);
		}

		public override int GetHashCode()
		{
			return x * y;
		}
	}

	class MainApp
	{
		static void Main(string[] args)
		{
			Point pt1 = new Point(100, 200);
			Console.WriteLine($"ToString : {pt1.ToString()}");

			Point pt2 = new Point(100, 200);
			// Equals 함수를 이용하여 객체 pt1와 pt2를 비교
			Console.WriteLine($"값 Equals : {pt1.Equals(pt2)}");

			// GetHashCode 함수를 이용하여 객체 pt2의 해시 코드를 출력
			// + 연산자를 사용하여 해시 코드를 출력
			Console.WriteLine("객체 pt2의 해시 코드 : " + pt2.GetHashCode());
			Console.WriteLine();
		
		
		
		}
	}
}
*/