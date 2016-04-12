using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsImplementation.LeetCode
{
    class LeetCode309
    {
        public int MaxProfit(int[] prices)
        {
            int max = 0;
            int substractSum = 0;
            int length = prices.Length;
            for (int i = 1; i < length; i++)
            {
                substractSum += Math.Max(0, prices[i] - prices[i - 1]);
                max = substractSum > max ? substractSum : max;
            }
            return max;
        }
    }
}
