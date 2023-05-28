using System.Reflection;
using System.Reflection.Emit;

// AssemblyBuilder를 이용하여 동적으로 어셈블리를 생성
AssemblyBuilder newAssembly =
	AssemblyBuilder.DefineDynamicAssembly(
		new AssemblyName("CalculatorAssembly"), AssemblyBuilderAccess.Run);

// ModuleBuilder를 이용하여 어셈블리 안에 모듈을 생성
ModuleBuilder newModule = newAssembly.DefineDynamicModule("Calculator");

// TypeBuilder를 이용하여 모듈 안에 형식(클래스)을 생성
TypeBuilder newType = newModule.DefineType("Sum1To100");

// MethodBuilder를 이용하여 클래스 안에 메서드를 생성
MethodBuilder newMethod = 
	newType.DefineMethod("Calculate", MethodAttributes.Public,
	typeof(int),	// 반환 형식
	new Type[0]);	// 매개 변수


// ILGenerator를 이용하여 메서드 안에 CPU가 실행할 IL 명령을 생성
ILGenerator generator = newMethod.GetILGenerator();

// 32비트 정수 1를 계산 스택에 넣음
generator.Emit(OpCodes.Ldc_I4, 1);

for (int i = 2; i <= 100; i++)
{
	// 32비트 정수 i를 계산 스택에 넣음
	generator.Emit(OpCodes.Ldc_I4, i);
	// 스택에 있는 두 수를 꺼내서 더한 후 다시 스택에 넣음
	generator.Emit(OpCodes.Add);
}

// 계산 스택에 담겨 있는 값을 반환
generator.Emit(OpCodes.Ret);

// 새로운 클래스 (Sum1To100)를 CLR에 제출
newType.CreateType();

// 이 형식의 인스턴스를 동적으로 생성하고 Calculate 메서드 호출
object sum1To100 = Activator.CreateInstance(newType);
MethodInfo Calculate = sum1To100.GetType().GetMethod("Calculate");
Console.WriteLine(Calculate.Invoke(sum1To100, null));
