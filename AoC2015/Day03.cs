namespace AoC2015
{
    internal class Day03
    {
        public static int Part1(string input)
        {
            var seen = new HashSet<(int row, int col)>();
            (int row, int col) pos = (0, 0);
            seen.Add(pos);

            foreach (var c in input)
            {
                pos = c switch
                {
                    '^' => (pos.row - 1, pos.col),
                    '>' => (pos.row, pos.col + 1),
                    'v' => (pos.row + 1, pos.col),
                    '<' => (pos.row, pos.col - 1),
                    _ => throw new NotImplementedException()
                };
                seen.Add(pos);
            }

            return seen.Count;
        }
        public static int Part2(string input)
        {
            var seen = new HashSet<(int row, int col)>();
            (int row, int col) posOne = (0, 0);
            (int row, int col) posTwo = (0, 0);
            seen.Add(posOne);

            for (int i = 0; i < input.Length; i++)
            {
                var currPos = i % 2 == 0 ? posOne : posTwo;
                currPos = input[i] switch
                {
                    '^' => (currPos.row - 1, currPos.col),
                    '>' => (currPos.row, currPos.col + 1),
                    'v' => (currPos.row + 1, currPos.col),
                    '<' => (currPos.row, currPos.col - 1),
                    _ => throw new NotImplementedException()
                };
                posOne = i % 2 == 0 ? currPos : posOne;
                posTwo = i % 2 == 0 ? posTwo : currPos;
                seen.Add(currPos);
            }

            return seen.Count;
        }
    }
}
