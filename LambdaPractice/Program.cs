namespace LambdaPractice;

internal class Program {
    private static void Main(string[] args) {
        var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4, };
        Predicate<int> judge = (int n) => {
            if(n % 2 == 0) {
                return true;
            }
            else{
                return false;
            }
        };
        var count = Count(numbers, judge);
        Console.WriteLine(count);
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