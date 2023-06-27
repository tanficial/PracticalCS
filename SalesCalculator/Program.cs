using System.IO;

namespace SalesCalculator;

internal class Program {
    private static void Main(string[] args)
    {
        SalesCounter salesCounter = new SalesCounter(SalesCounter.ReadSales("./sales.csv"));

        var amountPerStore = salesCounter.GetPerStoreSales();
        foreach (KeyValuePair<string, int> obj in amountPerStore) {
            Console.WriteLine($"{obj.Key} {obj.Value}");
        }
    }

}