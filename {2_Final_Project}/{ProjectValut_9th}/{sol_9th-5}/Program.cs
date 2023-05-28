Profile[] arrProfile =
{
	new Profile() {Name="김태희", Height=158},
	new Profile() {Name="정우성", Height=186},
	new Profile() {Name="고현정", Height=172},
	new Profile() {Name="하정우", Height=184},
	new Profile() {Name="강호동", Height=182}
};

Product[] arrProduct =
{
	new Product() {Title="비트", Actor="정우성"},
	new Product() {Title="아리리스", Actor="김태희"},
	new Product() {Title="장옥정", Actor="김태희"},
	new Product() {Title="모래시계", Actor="고현정"},
	new Product() {Title="히트", Actor="하정우"}
};

var listProfile = from profile in arrProfile
					  // arrProfile의 Name 과 arrProduct의 Actor가 같은
					  // 조건으로 내부 조인 실행
				  join product in arrProduct on profile.Name equals product.Actor
				  // 내부 조인 후 배우 이름, 작품명, 신장을 가진 새로운 형식을 만듦.
				  select new
				  {
					  Name = profile.Name,
					  Title = product.Title,
					  Height = profile.Height
				  };

Console.WriteLine("*** 내부 조인 결과 ***");
foreach (var profile in listProfile)
{
	// 내부 조인 후 배우 이름, 작품명, 신장을 출력
	Console.WriteLine($"이름 : {profile.Name}, 작품 : {profile.Title}, 신장 : {profile.Height}cm");
}

listProfile = from profile in arrProfile
					  // arrProfile의 Name 과 arrProduct의 Actor가 같은 조건으로
					  // 조인 실행 후 그 결과를 임시 컬렉션(ps)에 저장
				  join product in arrProduct on profile.Name equals product.Actor into ps
				  // 임시 컬렉션에 대해 DefaultEmpty 연산을 수행하여
				  // 비어 있는 연산 결과에 비어 있는 값을 "없음"으로 채워 넣음.
				  from product in ps.DefaultIfEmpty(new Product() { Title="없음"})
				  // 외부 조인 후 배우 이름, 작품명, 신장을 가진 새로운 형식을 만듦.
				  select new
				  {
					  Name = profile.Name,
					  Title = product.Title,
					  Height = profile.Height
				  };

Console.WriteLine();
Console.WriteLine("*** 외부 조인 결과 ***");
foreach (var profile in listProfile)
{
	// 외부 조인 후 배우 이름, 작품명, 신장을 출력
	Console.WriteLine($"이름 : {profile.Name}, 작품 : {profile.Title}, 신장 : {profile.Height}cm");
}

class Profile
{
	public string Name
	{ get; set; }
	public int Height
	{ get; set; }
}
class Product
{
	public string Title
	{ get; set; }
	public string Actor
	{ get; set; }
}