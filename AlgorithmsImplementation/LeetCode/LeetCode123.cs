﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsImplementation.LeetCode
{
    class LeetCode123
    {
        public int MaxProfit(int[] prices)
        {
            int length = prices.Length;
            if(length==0)
            {
                return 0;
            }
            int[] hold = new int[length];
            hold[0] = -prices[0];
            int[] notHold = new int[length];
            notHold[0] = 0;
            for(int i=1;i<length;i++)
            {
                hold[i] = Math.Max(hold[i - 1], notHold[i - 1] - prices[i]);
                notHold[i] = Math.Max(notHold[i - 1], hold[i - 1] + prices[i]);
            }
            return notHold[length - 1];
        }
    }
}
