using System.Linq;

internal class Program
{
    /*
    ** 열거
    ** 필터링
    ** 사상 : 컬렉션 안에서 조건을 만족하는 요소를(필요하다면 가공해서) 꺼내는 처리
    ** 시퀀스 : IEnumerable<T>
    ** 지연 실행 : 호출 시점에 실행되지 않고 실제 값이 필요할 때 실행
    ** 즉시 실행 : 호출 시점에 실행
    ** 확장 메서드 : 수정하기 어려운 코드나 클래스에 메서드를 추가할 때 사용하는 기능, Linq to Object는 Inumerable<T> 클래스의 확장 메서드로 구현됨
    **   - 정적 클래스의 정적 메서드로 선언
    **   - 첫번째 인자로 확장하고자 하는 클래스를 적고 그 앞에 this 키워드를 붙인다.
    **   - 두번째 인자부터 메서드의 인자임.
    */

    private static void Main(string[] args)
    {
        var names = new List<string> {
            "Seoul", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
        };

        var query = names.Where(s => s.Length <= 5);

        foreach (var n in query) {
            Console.WriteLine(n);
        }

        Console.WriteLine("-----------");

        var query2 = names
        .Where(s => s.Length <= 5)
        .Select(s => s.ToLower());

        foreach (var n in query2) {
            Console.WriteLine(n);
        }

        Console.WriteLine("-----------");

        var query3 = names.Select(s => s.Length);

        foreach (var n in query3) {
            Console.WriteLine(n);
        }

        Console.WriteLine("-----------");

        names[0] = "Busan";

        foreach (var n in query) {
            Console.WriteLine(n);
        }

        Console.WriteLine("-----------");

        Console.WriteLine($"{query.Count()}");
        names.Add("WHATT");
        Console.WriteLine($"{query.Count()}");
        
        Console.WriteLine("-----------");

        var query4 = names.Where(s =>s.Length <= 5).ToList();
        foreach (var n in query4) {
            Console.WriteLine(n);
        }
        names.Add("Ulsan");
        foreach (var n in query4) {
            Console.WriteLine(n);
        }


    }
}