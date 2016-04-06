using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsImplementation
{
    class KMP
    {
        public string Pattern { get; private set; }
        public int[] Next { get; private set; }
        public KMP(string pattern)
        {
            this.Pattern = pattern;
            this.Next = GetNextArray(this.Pattern);
        }

        private int[] GetNextArray(string pattern)
        {
            int[] next = new int[pattern.Length];
            return next;
        }

        private int HandleNextArray(string pattern,int[] next,int i)
        {
            return 0;
        }

        public List<int> GetAllMatchesIndex(string text)
        {
            return null;
        }

    }
}
