using System;
using System.Linq;
using System.Linq.Expressions;

namespace TheHighestProfitWins
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Highest Profit Wins!");

            AreEqual(new[] {20, 20}, MinMax(new[] {20}));
            AreEqual(new[] {-1, 20}, MinMax(new[] {1, 2, 5, -1, 12, 20}));
            AreEqual(new[] {1, 5}, MinMax(new[] {1, 2, 3, 4, 5}));
            AreEqual(new[] {-3, 5}, MinMax(new[] {1, 2, -3, 4, 5}));
        }

        public static void AreEqual<T>(T input, T output)
        {
            if (input.Equals(output))
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("          ");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("          ");
            }
            Console.ResetColor();
        }

        public static int[] MinMax(int[] list)
        {
            return new[] { list.Min(), list.Max() };
        }
    }
}
