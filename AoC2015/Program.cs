using System.Net.Http;
using System.Web;
using System.Runtime.CompilerServices;

namespace AoC2015
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var input = File.ReadAllText("input04.txt");
            Console.WriteLine(Day04.Part2(input));
        }
    }
}