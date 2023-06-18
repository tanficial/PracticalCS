namespace DistanceConverter;

class Program
{
    private static void Main(string[] args)
    {
        if(args.Length >= 1 && args[0].ToLower() == "--tom"){
            // 피트에서 미터로의 환산표
            PrintFeetToMeterList(1, 10);
        }else if(args.Length >= 1 && args[0].ToLower() == "--tof"){
            // 미터에서 피트로의 환산표
            PrintMeterToFeetList(1, 10);
        }
    }

    static void PrintFeetToMeterList(int start, int stop) {
        for(int feet = start; feet <= stop; feet++) {
            double meter = FeetConverter.ToMeter(feet);
            Console.WriteLine($"{feet} ft = {meter:0.0000} m");
        }
    }

    static void PrintMeterToFeetList(int start, int stop) {
        for(int meter = start; meter <= stop; meter++) {
            double feet = FeetConverter.FromMeter(meter);
            Console.WriteLine($"{meter} m = {feet:0.0000} ft");
        }
    }
}