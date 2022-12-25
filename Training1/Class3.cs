namespace Training1
{
    class Class3
    {
        public static bool IsAnagram(string s, string t)
        {
            int[] str1 = new int[26];
            int[] str2 = new int[26];
            if (s.Length == t.Length)
                for (int i = 0; i < s.Length; i++)
                {
                    str1[s[i] - 97]++;
                    str2[t[i] - 97]++;
                }
            else return false;

            for (int i = 0; i < 26; i++)
            {
                if (str1[i] != str2[i])
                    return false;
            }
            return true;

        }
    }
}

