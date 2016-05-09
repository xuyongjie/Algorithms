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
            LeetCode321 lc = new LeetCode321();
            int[] nums1 = { 6,7 };
            int[] nums2 = {6,0,4 };
            lc.MaxNumber(nums1, nums2, 5);
            Console.ReadLine();
        }
    }
}
