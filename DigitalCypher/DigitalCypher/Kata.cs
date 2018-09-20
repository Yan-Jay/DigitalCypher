using System;
using System.Collections.Generic;

namespace DigitalCypher
{
    public class Kata
    {
        public static int[] Encode(string str, int n)
        {
            var inputStrLength = str.Length;
            var inputNumberToString = n.ToString();
            var inputNumberArray = new int[inputNumberToString.Length];
            var nCount = 0;
            var ans = new int[inputStrLength];

            AddEachInputNumberToArray(inputNumberToString, inputNumberArray);

            var dic = AnDictionaryForMappingEnglishLetterAndNumber();

            DigitalCypher(str, inputStrLength, nCount, inputNumberToString, ans, dic, inputNumberArray);
            return ans;
        }

        private static void DigitalCypher(string str, int inputStrLength, int nCount, string inputNumberToString, int[] ans,
            Dictionary<string, int> dic, int[] inputNumberArray)
        {
            for (int i = 0; i < inputStrLength; i++)
            {
                if (nCount >= inputNumberToString.Length) //英文字串長度超出相加數字長度，使用nCount來計算應相加數字的哪個位數
                    nCount = 0;
                if (i <= inputNumberToString.Length - 1) //英文字串長度區塊在相加數字長度的區間內
                    ans[i] = dic[str.Substring(i, 1)] + inputNumberArray[i];
                else //使用nCount來紀錄目前該用相加數字的哪個進位做加減
                {
                    ans[i] = dic[str.Substring(i, 1)] + inputNumberArray[nCount];
                    nCount++;
                }
            }
        }

        private static void AddEachInputNumberToArray(string inputNumberToString, int[] inputNumberArray)
        {
            for (int i = 0; i < inputNumberToString.Length; i++)
            {
                inputNumberArray[i] = Int32.Parse(inputNumberToString.Substring(i, 1));
            }
        }

        private static Dictionary<string, int> AnDictionaryForMappingEnglishLetterAndNumber()
        {
            var dic = new Dictionary<string, int>();
            for (int i = 97; i <= 122; i++)
                dic.Add(((char) i).ToString(), i - 96);
            return dic;
        }
    }
}