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
            //KMP myKmp = new KMP("xuyongjie");
            //string text = "fgshgsxuyongjiedgfagxuyongfsgdsxuyongjiexuyongjiefdsgsdf";
            //var result = myKmp.GetAllMatchesIndex(text);
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //LeetCode5 lc = new LeetCode5();
            //Console.WriteLine(lc.LongestPalindrome2("aadfgagawertrewq"));
            HDOJ2602 hdoj = new HDOJ2602();
            int T = int.Parse(Console.ReadLine());
            int N, V;
            while(T>0)
            {
                string t = Console.ReadLine();
                string[] arr = t.Split(new char[] { ' ' });
                N = int.Parse(arr[0]);
                V = int.Parse(arr[1]);
                int[] value = new int[N];
                int[] volume = new int[N];
                string v = Console.ReadLine();
                string[] vArr= v.Split(new char[] { ' ' });
                for(int i=0;i<N;i++)
                {
                    value[i] = int.Parse(vArr[i]);
                }

                string vol = Console.ReadLine();
                string[] volArr = vol.Split(new char[] { ' ' });
                for (int i = 0; i < N; i++)
                {
                    volume[i] = int.Parse(volArr[i]);
                }

                Console.WriteLine(hdoj.GetMaxValue(10, value, volume));
                T--;
            }
            Console.ReadLine();
        }
    }
}
