using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LeetCode451 {
    public string FrequencySort(string s) {
        Dictionary<char,int> dic=new Dictionary<char,int>();
        foreach (var c in s)
        {
            if(dic.ContainsKey(c))
            {
                dic[c]++;
            }else
            {
                dic.Add(c,1);
            }
        }
        dic.Sort();
    }
}