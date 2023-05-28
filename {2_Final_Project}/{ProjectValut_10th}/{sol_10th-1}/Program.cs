using System.Reflection;

// typeof() 메서드를 이용하여 Profile 클래스의 타입 정보를 얻음
Type type = typeof(Profile);

// GetProperty() 메서드를 이용하여 Name 프로퍼티의 정보를 얻음
PropertyInfo name = type.GetProperty("Name");

// GetProperty() 메서드를 이용하여 Phone 프로퍼티의 정보를 얻음
PropertyInfo Phone = type.GetProperty("Phone");

// GetMethod() 메서드를 이용하여 Print 메서드의 정보를 얻음
MethodInfo method = type.GetMethod("Print");

// Activator 클래스의 CreateInstance() 함수를 이용하여 type 형식의 객체를
// 생성하는데 Name에는 "류현진", Phone에는 "552-3245"로 초기화
Object profile = Activator.CreateInstance(type, "류현진", "552-3245");

// GetValue() 메서드를 이용하여 name, phone 프로퍼티의 내용을 출력
Console.WriteLine($"{name.GetValue(profile, null)}, {Phone.GetValue(profile, null)}");

// Activator 클래스의 CreateInstance() 함수를 이용하여 type 형식의 객체를 생성
profile = Activator.CreateInstance(type);

// SetValue() 메서드를 이용하여 name 프로퍼티에 "추신수" 설정
name.SetValue(profile, "추신수", null);

// SetValue() 메서드를 이용하여 phone 프로퍼티에 "997-5511" 설정
Phone.SetValue(profile, "997-5511", null);

//Invoke() 메서드를 이용하여 Print() 메서드를 호출
method.Invoke(profile, null);

class Profile
{
	public string Name { get; set; }
	public string Phone { get; set; }
	// 인수가 없는 생성자 함수 
	public Profile()
	{
		Name = "";
		Phone = "";
	}
	public Profile(string name, string phone)
	{
		this.Name = name;
		this.Phone = phone;
	}

	public void Print()
	{
		Console.WriteLine($"{Name}, {Phone}");
	}
}