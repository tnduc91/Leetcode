using System;
using System.Text;

namespace LeetCode
{
    public static class LongestCommonPrefixClass
    {
        public static string LongestCommonPrefix(string[] strs) {
            if (strs.Length == 0){
                return "";
            }

            if (strs.Length == 1){
                return strs[0];
            }

            var common = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                common = LongestCommonPrefix(common, strs[i]);
            }
            return common;
        }

        private static string LongestCommonPrefix(string s1, string s2)
        {
            var minLength = s1.Length > s2.Length ? s2.Length : s1.Length;

            var i = 0;
            while (i < minLength)
            {
                if (s1[i] == s2[i])
                {
                    i ++;
                }else{
                    break;
                }
            }
            
            return s1.Substring(0, i);
        }
    }
}