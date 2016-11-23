using AlgorithmsImplementation.Common.Map.BFS;
using AlgorithmsImplementation.Common.Map.DFS;
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
            //LeetCode55 lt = new LeetCode55();
            //Console.WriteLine(lt.CanJump2(new int[] { 3, 0, 8, 2, 0, 0, 1}));
            //Console.WriteLine(lt.CanJump(new int[] { 3, 2, 1, 0, 4 }));
            //Console.WriteLine("This is BFS");
            //BFSTest test = new BFSTest();
            //test.DoBFS();
            //Console.WriteLine("\n\nThis is DFS");
            //DFSTest dfs = new DFSTest();
            //dfs.DoDFS();
            LeetCode453 lt = new LeetCode453();
            lt.MinMoves(new int[] { 1, 2, 3 });
            //Console.WriteLine(lt.ReverseVowels("hello"));
            Console.ReadLine();
        }
    }
}
