using OOPBasic;
using System.Configuration;

// 1.1 클래스
Product yakkwa = new Product(123, "약과", 180);
Product chapssal = new Product(235, "찹쌀떡", 160);

int price = yakkwa.Price;

int taxIncluded = yakkwa.GetPriceIncludingTax();

int yakkwaTax = yakkwa.GetTax();
int chapssalTax = chapssal.GetTax();

Console.WriteLine($"{price} {taxIncluded} {yakkwaTax} {chapssalTax}");

// 1.2 구조체
MyClass myClass = new MyClass {
    X = 1,
    Y = 2
};

MyStruct myStruct = new MyStruct {
    X = 1,
    Y = 2
};

// 1.3 값형과 참조형
MyPointStruct aSt = new MyPointStruct(10, 20);
MyPointStruct bSt = aSt;

Console.WriteLine($"as : {aSt.X}, {aSt.Y}");
Console.WriteLine($"bs : {bSt.X}, {bSt.Y}");

aSt.X = 80;
Console.WriteLine($"as : {aSt.X}, {aSt.Y}");
Console.WriteLine($"bs : {bSt.X}, {bSt.Y}");


MyPointClass aCls = new MyPointClass(10, 20);
MyPointClass bCls = aCls;

Console.WriteLine($"aCls : {aCls.X}, {aCls.Y}");
Console.WriteLine($"bCls : {bCls.X}, {bCls.Y}");

aCls.X = 80;
Console.WriteLine($"aCls : {aCls.X}, {aCls.Y}");
Console.WriteLine($"bCls : {bCls.X}, {bCls.Y}");

// 1.4 정적 멤버와 정적 클래스
// static 속성
DateTime today = DateTime.Today;
// static 메서드
Console.WriteLine($"오늘은 {today.Month}월 {today.Day}일 입니다.");

// 1.5 네임스페이스

// 1.6 상속
Employee employee = new Employee{
    Id = 100,
    Name = "홍길동",
    BirthDay = new DateTime(1992, 4, 5),
    DivisionName = "제1영업부",
};

Console.WriteLine($"{employee.Name}({employee.GetAge()})는 {employee.DivisionName}에 소속되어 있습니다.");

// is-a 관계
Person person = employee;
// object : System.Object 클래스의 별칭
object obj = employee;