using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsImplementation.LeetCode
{
    class LeetCode5
    {
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            string after = HandleText(s,'#');
            int i,maxlength=1,maxStart=0;
            int currentLength = 1, currentStart = 0;
            for(i=0;i<s.Length;i++)
            {
                GetPalindromeLength(after, i,out currentStart,out currentLength);
                if(currentLength>maxlength)
                {
                    maxlength = currentLength;
                    maxStart = currentStart;
                }
            }
            return s.Substring(maxStart, maxlength);
        }

        private void GetPalindromeLength(string s,int i,out int start,out int l)
        {
            int left=i-1, right=i+1;
            int length = 1;
            while(left>=0&&right<s.Length)
            {
                if(s[left]==s[right])
                {
                    length += 2;
                }
                else
                {
                    break;
                }
            }
            start = left/2;
            l = length/2;
        }

        /// <summary>
        /// 在字符串s中插入字符c
        /// </summary>
        /// <param name="s"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        private string HandleText(string s,char c)
        {
            StringBuilder builder = new StringBuilder();
            for(int i=0;i<s.Length;i++)
            {
                builder.Append('#').Append(s[i]);
            }
            builder.Append('#');
            return builder.ToString();
        }
    }
}
