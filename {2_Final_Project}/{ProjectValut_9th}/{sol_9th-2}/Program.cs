Console.WriteLine("*** Func 델리게이트 사용 ***");

// 매개변수가 하나인 Func 버전을 구현. 10을 반환함
Func<int> func1 = () => 10;
// 매개변수가 하나인 무명 메서드 출력
Console.WriteLine($"func1() : {func1()}");

// 매개변수가 두 개인 Func 버전을 구현. [입력변수 * 입력변수] 를 반환함
Func<int, int> func2 = (x) => x * x;
// 매개변수가 두 개인 무명 메서드 출력 (입력 변수: 5)
Console.WriteLine($"func2(5) : {func2(5)}");

// 매개변수가 세 개인 Func 버전을 구현. [입력 변수1 / 입력 변수 2] 를 반환함
Func<double, double, double> func3 = (x, y) => x / y;
// 매개변수가 세 개인 무명 메서드 출력 (입력변수1: 15, 입력변수2: 4)
Console.WriteLine($"func3(15/4) : {func3(15, 4)}");

Console.WriteLine("*** Action 델리게이트 사용 ***");

// 매개변수가 없는 Action 버전을 구현. 10을 출력함
Action act1 = () => Console.WriteLine($"act1() : {10}");
// 매개변수가 없는 무명 메서드 실행
act1();

int result1 = 0;
// 매개변수가 하나인 Action 버전을 구현. [입력변수 * 입력변수]를 result1 변수에 저장
Action<int> act2 = (x) => result1 = x * x;
// 매개변수가 하나인 무명 메서드 실행 (입력변수: 5)
act2(5);
Console.WriteLine($"act2(5) : {result1}");

double result2 = 0.0;
// 매개변수가 두 개인 Action을 구현. [입력 변수1 / 입력 변수2] 를 result2 변수에 저장
Action<double, double> act3 = (x, y) => result2 = x / y;
// 매개변수가 두 개인 무명 메서드 실행 (입력변수1: 15, 입력변수2: 4)
act3(15, 4);
Console.WriteLine($"act3(15/4) : {result2}");