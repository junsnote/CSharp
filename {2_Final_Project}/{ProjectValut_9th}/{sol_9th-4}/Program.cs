Student[] students = new Student[5];
students[0] = new Student()
{
	Name = "김태희",
	Score = new int[] { 89, 90, 45, 77 }
};
students[1] = new Student()
{
	Name = "정우성",
	Score = new int[] { 92,66,88,33 }
};
students[2] = new Student()
{
	Name = "고현정",
	Score = new int[] { 85,95,73,82 }
};
students[3] = new Student()
{
	Name = "이문세",
	Score = new int[] { 77,20,66,84 }
};
students[4] = new Student()
{
	Name="강호동",
	Score = new int[] { 37,70,43,65 }
};

// 점수가 60점 미만이 있는 학생을 뽑아낸다.
var failedStudent = from st in students
					from s in st.Score
					where s <= 60	// 점수가 60점 미만
					// 60점 미만인 학생 이름과 성적 (변수명 failScore)을
					// 가진 새로운 형식을 만듦.
					select new { st.Name, failScore = s };

// 60점 미만 학생의 점수와 이름을 출력
foreach (var st in failedStudent)
	Console.WriteLine($"낙제 점수 : {st.failScore}, 낙제생 : {st.Name}");

class Student
{
	public string Name
	{
		get;set;
	}
	public int[] Score
	{
		get; set;
	}
}