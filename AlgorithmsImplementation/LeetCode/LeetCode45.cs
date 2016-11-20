using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsImplementation.LeetCode
{
    class LeetCode45
    {
        /// <summary>
        /// Time limited error
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int Jump(int[] nums)
        {
            int[] M = new int[nums.Length];
            for(int i=0;i<M.Length;i++)
            {
                M[i] = int.MaxValue;
            }
            M[0] = 0;
            for(int i=1;i<nums.Length;i++)
            {
                for(int j=0;j<i;j++)
                {
                    if(j+nums[j]>=i)
                    {
                        M[i] = Math.Min(M[i], M[j] + 1);
                    }
                }
            }
            return M[nums.Length - 1];
        }

        public int Jump2(int[] nums)
        {
            int[] maxReachable = new int[nums.Length];//存储当前位置下最大可达位置
            maxReachable[0] = nums[0];
            int step = 0;
            int formerMax = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                maxReachable[i] = Math.Max(maxReachable[i - 1], maxReachable[i - 1] >= i ? i + nums[i] : maxReachable[i - 1]);
                if(i==formerMax)
                {
                    step++;
                    formerMax=nums[i];
                }
            }

            return step;
        }
    }
}
