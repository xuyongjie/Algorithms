using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsImplementation.LeetCode
{
    //Jump Game
    //Given an array of non-negative integers, you are initially positioned at the first index of the array.

    //Each element in the array represents your maximum jump length at that position.

    //Determine if you are able to reach the last index.

    //For example:
    //A = [2, 3, 1, 1, 4], return true.

    //A = [3, 2, 1, 0, 4], return false.
    class LeetCode55
    {
        public bool CanJump(int[] nums)
        {
            bool[] can = new bool[nums.Length];
            can[0] = true;
            for(int i=1;i<nums.Length;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    if(can[i-j]&&nums[i-j]>=j)
                    {
                        can[i] = true;
                    }
                }
            }
            return can[nums.Length-1];
        }
    }
}
