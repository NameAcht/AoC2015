namespace AoC2015
{
    internal class Program
    {
        public static void Main()
        {
            var input = File.ReadAllLines("input05.txt");
            Console.WriteLine(Day05.Part2(input));
        }
    }
}