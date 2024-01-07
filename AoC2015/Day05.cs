namespace AoC2015
{
    internal class Day05
    {
        public static int Part1(string[] input)
        {
            string[] filters = ["ab", "cd", "pq", "xy"];
            char[] vowels = ['a', 'e', 'i', 'o', 'u'];
            int sum = 0;

            foreach(var line in input)
            {
                if (filters.Any(line.Contains))
                    continue;

                int vowelCount = 0;
                bool twice = false;
                for (int i = 0; i < line.Length; i++)
                {
                    if (vowels.Contains(line[i]))
                        vowelCount++;
                    if (i == 0)
                        continue;
                    if (line[i - 1] == line[i])
                        twice = true;
                }

                if (twice && vowelCount >= 3)
                    sum++;
            }
            return sum;
        }
        public static int Part2(string[] input)
        {
            int sum = 0;
            foreach(var line in input)
            {
                var pairs = new List<string>();
                for (int i = 0; i < line.Length - 1; i++)
                    pairs.Add(line.Substring(i, 2));

                bool doublePair = false;
                for (int i = 0; i < pairs.Count; i++)
                {
                    string prev = i == 0 ? "" : pairs[i - 1];
                    string next = i == pairs.Count - 1 ? "" : pairs[i + 1];

                    int comp = 2;
                    if (pairs[i] == prev)
                        continue;
                    if (pairs[i] == next)
                        comp++;
                   
                    if (pairs.Count(pair => pair == pairs[i]) >= comp)
                    {
                        doublePair = true;
                        break;
                    }
                }

                bool betweenPat = false;
                for (int i = 1; i < line.Length - 1; i++)
                    if (line[i - 1] == line[i + 1])
                        betweenPat = true;

                if (betweenPat && doublePair)
                    sum++;
            }

            return sum;
        }
    }
}
