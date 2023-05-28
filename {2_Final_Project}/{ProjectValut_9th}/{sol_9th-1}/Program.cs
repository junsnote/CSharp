int[] arr = new int[4] {3,5,7,9};
// 두 개의 int 형식의 매개변수를 받아 두 수를 더해 반환하는
// 익명 메서드를 람다식으로 구현
Calculate calc = (a, b) => a + b;
// 익명 메서드를 호출하여 3+4의 결과를 출력
Console.WriteLine($"{3} + {4} = {calc(3, 4)}");

// 배열을 매개변수로 받아 배열의 요소를 모두 더해 반환하는
// 익명 메서드를 문 형식 람다식으로 구현
Accumulate accum = (arrs) =>
{
	int result = 0;
	foreach (int i in arrs)
		result += i;
	return result;
};

foreach (int i in arr)
	Console.Write($"{i} ");

// 익명 메서드를 호출하여 결과를 출력
Console.WriteLine($"의 합 : {accum(arr)}");

// 익명 메서드에 필요한 델리게이트
delegate int Calculate(int a, int b);
delegate int Accumulate(int[] arrs);