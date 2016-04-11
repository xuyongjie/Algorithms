using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsImplementation.LeetCode
{
    class LeetCode5
    {
        private int[,] flag;
        public string LongestPalindrome(string s)
        {

            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            flag = new int[s.Length, s.Length];
            int i, j,maxlength=1,maxStart=0;
            for(i=0;i<s.Length;i++)
            {
                for(j=0;j<s.Length;j++)
                {
                    if(i==j)
                    {
                        flag[i, j] = 1;
                    }
                    else
                    {
                        flag[i, j] = -1;
                    }
                }
            }

            for(i=0;i<s.Length-1;i++)
            {
                for(j=i+1;j<s.Length;j++)
                {
                    flag[i,j]=IsPalindrome(s, i, j);
                    if(flag[i,j]==1)
                    {
                        if(j - i + 1 > maxlength)
                        {
                            maxlength = j - i + 1;
                            maxStart = i;
                        }
                    }
                }
            }
            
            return s.Substring(maxStart, maxlength);
        }

        private int IsPalindrome(string s,int i,int j)
        {
            if(flag[i,j]!=-1)
            {
                return flag[i, j];
            }
            if (s[i] == s[j])
            {
                if (j == i + 1)
                {
                    return 1;
                }
                return IsPalindrome(s, i + 1, j - 1);
            }
            else
            {
                return 0;
            }
        }
    }
}
