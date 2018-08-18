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
            var z = new int[m.Length];
            for (int i = 0; i < m.Length; i++)
            {
                z[i] = Int32.Parse(m.Substring(i, 1));
            }
            var ans = new int[len];
            var ts = 0;

            var dic = new Dictionary<string, int>();
            for (int i = 97; i <= 122; i++)
                dic.Add(((char)i).ToString(), i - 96);

            for (int i = 0; i < len; i++)
            {
                if (ts >= m.Length)
                {
                    ts = 0;
                }
                if (i <= m.Length - 1)
                {
                    ans[i] = dic[str.Substring(i, 1)] + z[i];
                }
                else
                {
                    var test = str.Substring(i, 1);
                    ans[i] = dic[str.Substring(i, 1)] + z[ts];
                    ts++;
                }
            }

            return ans;
        }
    }
}