using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CifradoPokemon
{
    public class EqualStrings
    {
        public static string makeStringEqual(String str, String keyword)
        {
            StringBuilder sb = new StringBuilder("");
            if (str.Length > keyword.Length)
            {

                int j = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == ' ')
                    {
                        sb.Append(' ');
                    }
                    else
                    {
                        sb.Append(keyword[j]);
                        j++;
                        j %= keyword.Length;
                    }
                }
            }
            return sb.ToString();
        }
    }
}
