using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsImplementation.LeetCode
{
    class LeetCode377
    {
        private int[] sorted;
        private int solutions;
        public int CombinationSum4(int[] nums, int target)
        {
            sorted = nums;
            solutions = 0;
            DFS(target);
            return solutions;
        }

        private void DFS(int target)
        {
            if (target == 0)
            {
                solutions++;
                return;
            }
            else if (target < 0)
            {
                return;
            }
            else
            {
                for (int i = 0; i < sorted.Length; i++)
                {
                    DFS(target - sorted[i]);
                }
            }
        }
    }
}
