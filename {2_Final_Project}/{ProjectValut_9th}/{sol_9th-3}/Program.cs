using System.Linq.Expressions;

// Constant() 팩토리 메서드로 상숫값 3인 const1 객체 선언
Expression const1 = Expression.Constant(3);
// Parameter() 팩토리 메서드로 형식 int, 변수명 x인 param1 객체 선언
Expression param1 = Expression.Parameter(typeof(int), "x");

// Multiply() 메서드로 exp1에 3*x를 구현 (const1, param1 사용)
Expression exp1 = Expression.Multiply(const1, param1);

// Constant() 팩토리 메서드로 상숫값 5인 const2 객체 선언
Expression const2 = Expression.Constant(5);
// Parameter() 팩토리 메서드로 형식 int, 변수명 y인 param1 객체 선언
Expression param2 = Expression.Parameter(typeof(int), "y");

// Add() 메서드로 exp2에 y+5를 구현 (const2, param2 사용)
Expression exp2 = Expression.Add(const2, param2);

// Divide() 메서드로 exp3에 (y+5)/x를 구현 (epx2, param1 사용)
Expression exp3 = Expression.Divide(exp2, param1);

// Subtract() 메서드로 exp에 3*x-(y+5)/x를 구현 (exp1, exp3 사용)
Expression exp = Expression.Subtract(exp1, exp3);

Expression<Func<int, int, int>> expression =
	Expression<Func<int, int, int>>.Lambda<Func<int, int, int>>(
		exp, new ParameterExpression[]
		{
			(ParameterExpression)param1,
			(ParameterExpression)param2
		});

// 람다식을 실행 가능한 코드로 컴파일
Func<int, int, int> comExp = expression.Compile();

// 컴파일한 무명 함수를 실행(매개 변수값 x는 5, y는 10)
Console.WriteLine($"3 * 5 - (5 + 10) / 5 : {comExp(5, 10)}");