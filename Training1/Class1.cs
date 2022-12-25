using System.Collections.Generic;
using System.Linq;

namespace Training1
{
    class Class1
    {
        public static int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            List<int> copy = new List<int>();
            List<int> copy1 = new List<int>();

            foreach (var num in mat)
            {

                copy1 = (from n in num
                         select n).ToList();
                copy.AddRange(copy1);

            }

            if (copy.Count == (r * c))
            {
                int[][] temp;
                temp = new int[r][];

                for (int i = 0; i < r; i++)
                {
                    if (copy != null)
                    {
                        temp[i] = (from n in copy select n).Take(c).ToArray();
                        copy.RemoveRange(0, c);
                    }
                }
                return temp;
            }
            return mat;
        }
    }
}
