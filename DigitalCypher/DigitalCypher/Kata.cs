using System;
using System.Collections.Generic;

namespace DigitalCypher
{
    public class Kata
    {
        public static int[] Encode(string str, int n)
        {
            var len = str.Length;
            var m = n.ToString();
            var nIndex = new int[m.Length];
            var nCount = 0;
            var ans = new int[len];

            for (int i = 0; i < m.Length; i++)
            {
                nIndex[i] = Int32.Parse(m.Substring(i, 1));
            }

            var dic = new Dictionary<string, int>();
            for (int i = 97; i <= 122; i++)
                dic.Add(((char)i).ToString(), i - 96);

            for (int i = 0; i < len; i++)
            {
                if (nCount >= m.Length)
                    nCount = 0;
                if (i <= m.Length - 1)
                    ans[i] = dic[str.Substring(i, 1)] + nIndex[i];
                else
                {
                    var test = str.Substring(i, 1);
                    ans[i] = dic[str.Substring(i, 1)] + nIndex[nCount];
                    nCount++;
                }
            }
            return ans;
        }
    }
}