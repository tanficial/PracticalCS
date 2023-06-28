namespace LambdaPractice;

internal class Program {
    public delegate bool Judgement(int value);
    private static void Main(string[] args) {
        var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4, };
        var count = Count(numbers, 5, IsEven);
        Console.WriteLine(count);
    }

    static public int Count(int[] numbers, int num, Judgement judge) {
        int count = 0;
        foreach (var n in numbers) {
            if (judge(n) == true) {
                count++;
            }
        }

        return count;
    }

    static public bool IsEven(int n){
        return n %2 == 0;
    }
}