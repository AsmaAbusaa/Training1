using System.Collections.Generic;

namespace Training1
{
    class Class2
    {
        public IList<IList<int>> Generate(int numRows)
        {
            int[][] main = new int[numRows][];
            main[0] = new int[1] { 1 };

            for (int i = 1; i < main.Length; i++)
            {
                main[i] = new int[i + 1];
                main[i][0] = 1;
                main[i][i] = 1;

                if (i >= 2)
                    for (int j = 1; j <= main[i].Length / 2; j++)
                    {
                        main[i][j] = main[i - 1][j] + main[i - 1][j - 1];
                        main[i][i - j] = main[i][j];
                    }
            }

            return main;

        }
    }
}
