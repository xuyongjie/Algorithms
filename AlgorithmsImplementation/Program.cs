using AlgorithmsImplementation.LeetCode;
using System;

namespace AlgorithmsImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            //LeetCode388 lt = new LeetCode388();
            //Console.WriteLine(lt.LengthLongestPath("dir\n\tsubdir1\n\t\tfile1.ext\n\t\tsubsubdir1\n\tsubdir2\n\t\tsubsubdir2\n\t\t\tfile2.ext"));
            LeetCode55 lt = new LeetCode55();
            Console.WriteLine(lt.CanJump(new int[] { 2, 3, 1, 1, 4 }));
            Console.WriteLine(lt.CanJump(new int[] { 3, 2, 1, 0, 4 }));
            Console.ReadLine();
        }
    }
}
