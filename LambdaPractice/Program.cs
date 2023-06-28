namespace LambdaPractice;

internal class Program {
    private static void Main(string[] args) {
        var count = Count(5);
        Console.WriteLine(count);
    }

    static public int Count(int num) {
        var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4, };
        int count = 0;
        foreach (var n in numbers) {
            if (n == num) {
                count++;
            }
        }

        return count;
    }
}