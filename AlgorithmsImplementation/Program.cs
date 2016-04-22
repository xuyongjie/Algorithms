using AlgorithmsImplementation.HDOJ;
using AlgorithmsImplementation.LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            LeetCode322 lc = new LeetCode322();
            int[] coins = { 1};
            int amount = 3;
            Console.WriteLine(lc.CoinChange(coins, amount));
            Console.ReadLine();
        }
    }
}
