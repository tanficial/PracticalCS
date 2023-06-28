namespace LambdaPractice;

internal class Program {
    private static void Main(string[] args) {
        var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4, };
        var count = Count(numbers, n => n % 2 == 0);
        Console.WriteLine(count);

        // List<T> 와 람다식
        var list = new List<string> {
            "Seoul", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
        };

        var exists = list.Exists(s => s[0] == 'A');
        Console.WriteLine(exists);

        var name = list.Find(s => s.Length == 6);
        Console.WriteLine(name);

        var index = list.FindIndex(s => s == "Berlin");
        Console.WriteLine(index);

        var names = list.FindAll(s => s.Length <= 5);
        foreach (var s in names) {
            Console.WriteLine(s);
        }

        var removedCount = list.RemoveAll(s => s.Contains("on"));
        Console.WriteLine(removedCount);

        list.ForEach(s => Console.WriteLine(s));
        // list.ForEach(Console.WriteLine);

        var lowerList = list.ConvertAll(s => s.ToLower());
        lowerList.ForEach(s => Console.WriteLine(s));

        var numStrList = new List<string> {
            "1", "2", "3",
        };

        var numList = numStrList.ConvertAll(s => int.Parse(s));
        numList.ForEach(n => Console.WriteLine(n.GetType()));
        numStrList.ForEach(n => Console.WriteLine(n.GetType()));
    }

    // Action<T1, T2>
    //   - 리턴값이 없는 delegate
    // Func<T1, T2, Tresult>
    //   - 리턴값이 있는 delegate
    // Predicate<T1, T2>
    //   - 리턴값이 무조건 bool 인 delegate
    static public int Count(int[] numbers, Predicate<int> judge) {
        int count = 0;
        foreach (var n in numbers) {
            if (judge(n) == true) {
                count++;
            }
        }

        return count;
    }
}