using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training1
{
    class Class4
    {   
        public static int FirstUniqChar(string s)
        {
            Dictionary<int, char> index = new Dictionary<int, char>();
            List<char> list = new List<char>();
            List<char> repeated = new List<char>();


            for (int i = 0; i < s.Length; i++)
            {
                if (!list.Contains(s.ElementAt(i)))
                {

                    list.Add(s.ElementAt(i));
                    index.Add(i, s.ElementAt(i));
                }
                else
                {
                    repeated.Add(s.ElementAt(i));
                }

            }
            foreach (var d in index)
                if (!repeated.Contains(d.Value))
                    return d.Key;

            return -1;
        }

        public int AcceptedSolution(string s)
        {
            HashSet<char> CharsBlackList = new HashSet<char>();
            HashSet<char> UniqChars = new HashSet<char>();
            foreach (char c in s)
            {
                if (UniqChars.Contains(c))
                {
                    CharsBlackList.Add(c);
                    UniqChars.Remove(c);
                }
                else if (!CharsBlackList.Contains(c))
                {
                    UniqChars.Add(c);
                }

            }

            for (int i = 0; i < s.Length; i++)
            {
                if (UniqChars.Contains(s[i]))
                {
                    return i;
                }
            }

            return -1;
        }

    }
}
