namespace AoC2015
{
    internal class Day01
    {
        public static int Part1(string input) => input.Sum(c => c == '(' ? 1 : -1);
        public static int Part2(string input)
        {
            int floor = 0;
            int i = 0;
            for (i = 0; floor >= 0; i++)
                floor += input[i] == '(' ? 1 : -1;
            return i;
        }
    }
}
