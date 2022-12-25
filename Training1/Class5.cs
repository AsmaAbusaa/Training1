using System.Collections.Generic;

namespace Training1
{
    class Class5
    {
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            List<char> list = new List<char>(magazine);
            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (list.Contains(ransomNote[i]))
                {
                    list.Remove(ransomNote[i]);
                }
                else return false;

            }
            return true;
        }

    }
}
