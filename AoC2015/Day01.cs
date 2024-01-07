namespace AoC2015
{
    internal class Day01
    {
        public static int Part1(string input) => input.Sum(c => c == '(' ? 1 : -1);
        public static int Part2(string input)
        {
            int floor = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                    floor++;
                else
                    floor--;

                if (floor < 0)
                    return i + 1;
            }
            return floor;
        }
    }
}
