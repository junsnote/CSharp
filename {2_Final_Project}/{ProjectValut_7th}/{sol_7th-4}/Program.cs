using System.Drawing;

Console.WriteLine("*** Object 클래스 멤버 함수를 재정의하지 않은 경우 ***");
Point1 pt1 = new Point1(100, 200);
Console.WriteLine($"ToString : {pt1.ToString()}");  // pt1 객체를 문자열로 표현

Point1 pt2 = new Point1(100, 200);
Point1 pt3 = pt2;
// Equals 함수를 이용하여 객체 pt2와 pt3을 비교
Console.WriteLine($"참조 Equals : {pt2.Equals(pt3)}");

Point1 pt4 = new Point1(100, 200);
// Equals 함수를 이용하여 pt2와 pt4를 비교
Console.WriteLine($"값 Equals : {pt2.Equals(pt4)}");

// GetHashCode 함수를 이용하여 객체 pt2의 해시코드를 출력
// + 연산자를 사용하여 해시 코드를 출력
Console.WriteLine("객체 pt2의 해시 코드 : " + pt2.GetHashCode());
Console.WriteLine();

Console.WriteLine("*** Object 클래스 멤버 함수를 재정의 한 경우 ***");
Point2 ptt1 = new Point2(100, 200);
Console.WriteLine($"ToString : {ptt1.ToString()}"); // ptt1 객체를 문자열로 표현

Point2 ptt2 = new Point2(100, 200);
Point2 ptt3 = ptt2;
// Equals 함수를 이용하여 객체 ptt2와 ptt3을 비교
Console.WriteLine($"참조 Equals : {ptt2.Equals(ptt3)}");

Point2 ptt4 = new Point2(100, 200);
// Equals 함수를 이용하여 객체 ptt2와 ptt4를 비교
Console.WriteLine($"값 Equals : {ptt2.Equals(ptt4)}");

// GetHashCode 함수를 이용하여 객체 ptt2의 해시 코드를 출력
// + 연산자를 사용하여 해시 코드를 출력
Console.WriteLine("객체 ptt2의 해시 코드 : " + ptt2.GetHashCode());

class Point1
{
	int x; int y;

	public Point1(int x, int y)
	{
		this.x = x;
		this.y = y;
	}
}

class Point2
{
	int x; int y;
	public Point2(int x, int y)
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
		if (!(o is Point2)) return false;
		return (x == ((Point2)o).x && y == ((Point2)o).y);
	}
	public override int GetHashCode()
	{
		return x * y;
	}
}