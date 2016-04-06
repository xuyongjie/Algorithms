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
            //Solution solution = new Solution();
            //int[] nums = new int[4] { 11, 15, 2, 7 };
            //int[] result=solution.TwoSum(nums, 9);
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            LeetCode2 solution = new LeetCode2();
            ListNode node1 = new ListNode(9);
            node1.next = new ListNode(8);
            node1.next.next = null;
            ListNode node2 = new ListNode(1);
            node2.next = null;
            ListNode result=solution.AddTwoNumbers(node1, node2);
            while(result!=null)
            {
                Console.Write(result.val);
                result = result.next;
            }
            Console.ReadLine();
        }
    }
}
