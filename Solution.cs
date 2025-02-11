using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectCapital_
{
    public class Solution
    {
            public static bool DetectCapitalUse(string word)
            {
                int isValidCapitalization = 0;
                int length = word.Length;

                for (int i = 0; i < length; i++)
                {
                    if (char.IsUpper(word[i]))
                    {
                        isValidCapitalization++;
                    }
                }

                if (isValidCapitalization == 0)
                    return true;

                if (isValidCapitalization == length)
                    return true;

                if (isValidCapitalization == 1 && char.IsUpper(word[0]))
                    return true;

                return false;
            }
    }
}
