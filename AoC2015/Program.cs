using System.Diagnostics;

namespace AoC2015
{
    internal class Program
    {
        public static void Main()
        {
            var sw = Stopwatch.StartNew();
            var input = File.ReadAllLines("input06.txt");
            Console.WriteLine(Day06.Part2(input));
            Console.WriteLine(sw.Elapsed);
            Day06.test();
        }
    }
}