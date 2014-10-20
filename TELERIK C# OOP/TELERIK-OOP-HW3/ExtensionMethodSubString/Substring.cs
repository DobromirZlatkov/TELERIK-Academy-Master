using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodSubString
{
    public static class Substring
    {
        public static StringBuilder GetSubstring(this StringBuilder originalBuilder, int index, int lenght)
        {
            var result = new StringBuilder();
            if (index + lenght > originalBuilder.Length)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if (index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                for (int i = index; i < lenght + index; i++)
                {
                    result.Append(originalBuilder[i]);
                }
                return result;
            }            
        }
        public static StringBuilder GetSubstring(this StringBuilder originalBuilder, int index)
        {
            return originalBuilder.GetSubstring(index, originalBuilder.Length - index);
            
        }
    }
}
