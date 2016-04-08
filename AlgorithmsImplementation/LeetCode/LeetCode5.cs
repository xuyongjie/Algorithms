using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsImplementation.LeetCode
{
    class LeetCode5
    {
        private bool[,] flag;
        public string LongestPalindrome(string s)
        {

            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            flag = new bool[s.Length, s.Length];
            int i, j,maxlength=1,maxStart=0;
            for(i=0;i<s.Length;i++)
            {
                flag[i,i] = true;
            }

            for(i=0;i<s.Length-1;i++)
            {
                for(j=i+1;j<s.Length;j++)
                {
                    if(s[i]==s[j])
                    {
                        if(j==i+1)
                        {
                            flag[i, j] = true;
                            if(j-i+1>maxlength)
                            {
                                maxlength = j - i + 1;
                                maxStart = i;
                            }
                            continue;
                        }
                        if(flag[i+1,j-1])
                        {
                            flag[i, j] = true;
                            if (j - i + 1 > maxlength)
                            {
                                maxlength = j - i + 1;
                                maxStart = i;
                            }
                        }
                        else
                        {
                            flag[i, j] = false;
                        }
                    }
                    else
                    {
                        flag[i, j] = false;
                    }
                }
            }
            
            return s.Substring(maxStart, maxlength);
        }
    }
}
