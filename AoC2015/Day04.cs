using System.Security.Cryptography;
using System.Text;

namespace AoC2015
{
    internal class Day04
    {
        public static int Part1(string input)
        {
            for (int i = 0; ; i++)
            {
                var bytes = MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(input.Trim() + i)).Take(3).ToList();
                if (bytes[0..2].Sum(Convert.ToInt32) == 0 && bytes[2] < 10)
                    return i;
            }
        }
        public static int Part2(string input)
        {
            for (int i = 0; ; i++)
                if (MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(input.Trim() + i)).Take(3).Sum(Convert.ToInt32) == 0)
                    return i;
        }
    }
}
