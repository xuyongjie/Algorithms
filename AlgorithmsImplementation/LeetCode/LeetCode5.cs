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
            int max = 1;
            int resultIndex = 0;
            int former = 1;
            int i, j,start,end;
            for (i = 1; i < s.Length; i++)
            {

                if (i-former-1>=0&&s[i] == s[i - former - 1])
                {
                    former = former+2;
                }
                else
                {
                    for(j=i-former;j<i;j++)
                    {
                        if(s[j]==s[i])
                        {
                            start = j + 1;
                            end = i - 1;
                            while(start<end-1)
                            {
                                if(s[start]!=s[j])
                                {
                                    break;
                                }
                            }

                            if(start>=end-1)
                            {
                                former = i - j+1;
                                break;
                            }
                        }
                    }

                    if(j==i)
                    {
                        former = 1;
                    }
                }

                if (former > max)
                {
                    max = former;
                    resultIndex = i;
                }
            }
            return s.Substring(resultIndex - max+1, max);
        }
    }
}
