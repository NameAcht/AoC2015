namespace AoC2015
{
    static class Day06
    {
        static void Toggle(this bool[][] lights, int x1, int y1, int x2, int y2)
        {
            for (int row = x1; row <= x2; row++)
                for (int col = y1; col <= y2; col++)
                    lights[row][col] = !lights[row][col];
        }
        static void TurnOff(this bool[][] lights, int x1, int y1, int x2, int y2)
        {
            for (int row = x1; row <= x2; row++)
                for (int col = y1; col <= y2; col++)
                    lights[row][col] = false;
        }
        static void TurnOn(this bool[][] lights, int x1, int y1, int x2, int y2)
        {
            for (int row = x1; row <= x2; row++)
                for (int col = y1; col <= y2; col++)
                    lights[row][col] = true;
        }
        static void Increase(this int[][] lights, int x1, int y1, int x2, int y2, int b)
        {
            for (int row = x1; row <= x2; row++)
                for (int col = y1; col <= y2; col++)
                    lights[row][col] += b;
        }
        static void Decrease(this int[][] lights, int x1, int y1, int x2, int y2)
        {
            for (int row = x1; row <= x2; row++)
                for (int col = y1; col <= y2; col++)
                    if (lights[row][col] > 0)
                        lights[row][col]--;
        }
        public static int Part1(string[] input)
        {
            var lights = new bool[1000][];
            for(int i = 0; i < lights.Length; i++)
                lights[i] = new bool[1000];

            foreach(var line in input)
            {
                var split = line.Split([' ', ',']);
                int x1 = int.Parse(split[split.Length - 5]);
                int y1 = int.Parse(split[split.Length - 4]);
                int x2 = int.Parse(split[split.Length - 2]);
                int y2 = int.Parse(split[split.Length - 1]);

                if (split[0] == "toggle")
                    lights.Toggle(x1, y1, x2, y2);
                else if (split[1] == "off")
                    lights.TurnOff(x1, y1, x2, y2);
                else 
                    lights.TurnOn(x1, y1, x2, y2);
            }
            int count = 0;
            foreach (var row in lights)
                foreach (var b in row)
                    count += b ? 1 : 0;

            return count;
        }
        public static int Part2(string[] input)
        {
            var lights = new int[1000][];
            for (int i = 0; i < lights.Length; i++)
                lights[i] = new int[1000];

            foreach (var line in input)
            {
                var split = line.Split([' ', ',']);
                int x1 = int.Parse(split[split.Length - 5]);
                int y1 = int.Parse(split[split.Length - 4]);
                int x2 = int.Parse(split[split.Length - 2]);
                int y2 = int.Parse(split[split.Length - 1]);

                if (split[0] == "toggle")
                    lights.Increase(x1, y1, x2, y2, 2);
                else if (split[1] == "off")
                    lights.Decrease(x1, y1, x2, y2);
                else
                    lights.Increase(x1, y1, x2, y2, 1);
            }
            int sum = 0;
            foreach (var row in lights)
                foreach (var b in row)
                    sum += b;

            return sum;
        }
    }
}
