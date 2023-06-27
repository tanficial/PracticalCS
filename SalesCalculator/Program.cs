using System.IO;

namespace SalesCalculator;

internal class Program {
    private static void Main(string[] args)
    {
        // var 사용법
        // 우변의 변수형이 분명한 경우 사용
        // 엄밀하게 형을 지정하지 않아도 될 경우 사용
        // 우변의 형이 분명하지 않을 때는 X
        // 변수 이름을 변수형에 의존하지 말 것.
        // 변수 이름에 포함된 형이름이 맞다는 보장이 없으므로 코드 읽을 때 혼란에 빠질 수 있음.
        // dynamic 대신 var 사용하지 말 것
        // for, foreach문에서 루프 변수형에 사용 가능
        var salesCounter = new SalesCounter("./sales.csv");

        var amountPerStore = salesCounter.GetPerStoreSales();
        foreach (KeyValuePair<string, int> obj in amountPerStore) {
            Console.WriteLine($"{obj.Key} {obj.Value}");
        }
    }

}