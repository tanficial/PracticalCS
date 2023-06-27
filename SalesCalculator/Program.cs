using System.IO;

namespace SalesCalculator;

internal class Program {
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var sales = ReadSales("./sales.csv");

        foreach (var s in sales) {
            Console.WriteLine($"{s.ShopName} {s.ProductCategory} {s.Amount}");
        }

        SalesCounter salesCounter = new SalesCounter(sales);

        var amountPerStore = salesCounter.GetPerStoreSales();
        foreach (KeyValuePair<string, int> obj in amountPerStore) {
            Console.WriteLine($"{obj.Key} {obj.Value}");
        }
    }

    // File.ReadAllLines : 작은 파일에만 쓰자. 큰 파일에는 못쓰는 함수
    // 객체 이니셜라이저 : new Class{ prop1 = 1, prop2 = 2, prop3 = 3};
    // 객체 이니셜라이저를 사용하지 않으면 라인 사이에 다른 코드가 들어갈 수 있어 가독성을 해친다.
    static List<Sale> ReadSales(string filePath) {
        List<Sale> sales = new List<Sale>();
        string[] lines = File.ReadAllLines(filePath);
        foreach (string line in lines) {
            string[] items = line.Split(",");
            Sale sale = new Sale {
                ShopName = items[0],
                ProductCategory = items[1],
                Amount = int.Parse(items[2]),
            };
            sales.Add(sale);
        }

        return sales;
    }
}