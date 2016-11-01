using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsImplementation.LeetCode
{
    class LeetCode45
    {
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
    }
}
