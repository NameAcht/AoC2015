namespace AoC2015
{
    internal class Day02
    {
        public static int Part1(string[] input)
        {
            int sum = 0;
            foreach (var line in input)
            {
                var nums = line.Split('x').ToList().ConvertAll(int.Parse);
                var areas = new int[nums.Count];
                for (int i = 0; i < nums.Count; i++)
                    areas[i] = 2 * nums[i] * nums[(i + 1) % nums.Count];
                sum += areas.Sum() + areas.Min() / 2;
            }
            return sum;
        }
        public static int Part2(string[] input)
        {
            int sum = 0;
            foreach (var line in input)
            {
                var nums = line.Split('x').ToList().ConvertAll(int.Parse);
                nums.Sort();
                sum += 2 * nums.Min() + 2 * nums[nums.Count / 2] + nums.Aggregate((a, b) => a * b);
            }
            return sum;
        }
    }
}
