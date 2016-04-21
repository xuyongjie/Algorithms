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
            //KMP myKmp = new KMP("xuyongjie");
            //string text = "fgshgsxuyongjiedgfagxuyongfsgdsxuyongjiexuyongjiefdsgsdf";
            //var result = myKmp.GetAllMatchesIndex(text);
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            LeetCode5 lc = new LeetCode5();
            Console.WriteLine(lc.LongestPalindrome2("aadfgagawertrewq"));
            Console.ReadLine();
        }
    }
}
